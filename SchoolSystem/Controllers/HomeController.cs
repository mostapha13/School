using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IdentityModel.Tokens.Jwt;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Dapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CodeFixes;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using SchoolSystem.Models.Home;
using SMSOnline;

namespace SchoolSystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly SqlConnection connection;
        private readonly List<SignatureCaptcha> signatureCaptchas;
        private readonly List<VerificationCode> verifications;
        private readonly bool debug = true;

        public HomeController(IConfiguration configuration, List<SignatureCaptcha> signatureCaptchas, List<VerificationCode> verifications)
        {
            connection = new SqlConnection(configuration.GetSection("ConnectionString").Value);
            this.signatureCaptchas = signatureCaptchas;
            this.verifications = verifications;
        }
 
        public async Task<IActionResult> Index()
        {
            return View();
        }
        public async Task<IActionResult> Captcha()
        {
            signatureCaptchas.RemoveAll(c => c.Expire.CompareTo(DateTime.Now) < 0);

            Random rnd = new Random();

            var id = rnd.Next(1, 50);
            var result = await connection.QueryFirstAsync<Captcha>(@"select [Value],[Base64] from Captcha where Id = @id", new { id });

            var signatureCaptcha = new SignatureCaptcha()
            {
                PrivateKey = result.Value,
                PublicKey = (long)(rnd.NextDouble() * 111111111111),
                Expire = DateTime.Now.AddMinutes(30)
            };

            signatureCaptchas.Add(signatureCaptcha);

            return Json(new CaptchaVM()
            {
                PublicKey = signatureCaptcha.PublicKey,
                Image = result.Base64
            });
        }

        [Authorize(Roles = "DataEntry")]
        [HttpGet, HttpPost]
        public async Task<JsonResult> GetAllSchoolByManagerMobile(string mobile)
        {
            var result = await connection.QueryAsync(@"exec [GetAllSchoolByManagerMobile] 
                                                       @mobile", new { mobile });

            return Json(result);

        }

        [Authorize(Roles = "DataEntry")]
        [HttpGet, HttpPost]
        public async Task<JsonResult> GetSchoolByMainCode(string mainCode)
        {
            var result = await connection.QueryAsync(@"exec [GetSchoolByMainCode] 
                                                       @mainCode", new { mainCode });

            return Json(result);

        }

        [Authorize(Roles = "DataEntry")]
        [HttpPost]
        public async Task<IActionResult> SaveForm([FromForm]FormData input)
        {
            var rowId = (await connection.QueryAsync<int>(@"exec [SaveFormData] 
                                                       @mainCode,@schoolCode,@name,@areaName,@areaCode,
                                                       @period,@subSet,@gender,@address,@tell1,@tell2,@tell3,@teacherCount,
                                                       @studyTime,@postalCode,@mobileInternet,@adsl,@studentCount,@basicCount,
                                                       @managerName,@managerMobile,@managerNationalCode,@lat,@lng,@amarcode,
                                                       @comment", input)).FirstOrDefault();

            if (rowId > 0 && input?.Images?.Count > 0)
            {
                foreach (var image in input.Images)
                {
                    try
                    {
                        await connection.ExecuteAsync(@"Insert Into [FormDataImage] (Image,FormDataId) 
                                                values(@image,@rowId)", new { image, rowId });
                    }
                    catch (Exception ex)
                    {
                    }
                }
            }

            return Ok();
        }

        [AllowAnonymous]
        [HttpGet, HttpPost]
        public async Task<JsonResult> GetAllOstanName(string q)
        {
            var result = await connection.QueryAsync(@"exec [SearchAmarText] 
                                                       @text,@field,@amarcode", new { text = q ?? "", field = "Ostan", amarcode = "1398" });

            return Json(new { results = result });
        }

        [AllowAnonymous]
        [HttpGet, HttpPost]
        public async Task<JsonResult> GetAllShahrestanName(string q, string amarcode)
        {
            var result = await connection.QueryAsync(@"exec [SearchAmarText] 
                                                       @text,@field,@amarcode", new { text = q ?? "", field = "Shahrestan", amarcode });

            return Json(new { results = result });
        }

        [AllowAnonymous]
        [HttpGet, HttpPost]
        public async Task<JsonResult> GetAllBakhshName(string q, string amarcode)
        {
            var result = await connection.QueryAsync(@"exec [SearchAmarText] 
                                                       @text,@field,@amarcode", new { text = q ?? "", field = "Bakhsh", amarcode });

            return Json(new { results = result });
        }

        [AllowAnonymous]
        [HttpGet, HttpPost]
        public async Task<JsonResult> GetAllDehestanName(string q, string amarcode)
        {
            var result = await connection.QueryAsync(@"exec [SearchAmarText] 
                                                       @text,@field,@amarcode", new { text = q ?? "", field = "Dehestan", amarcode });

            return Json(new { results = result });
        }

        [AllowAnonymous]
        [HttpGet, HttpPost]
        public async Task<JsonResult> GetAllAbadiName(string q, string amarcode)
        {
            var result = await connection.QueryAsync(@"exec [SearchAmarText] 
                                                       @text,@field,@amarcode", new { text = q ?? "", field = "Abadi", amarcode });

            return Json(new { results = result });
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> CheckExistMobile(string mobile, string captcha, long publicKey)
        {
            signatureCaptchas.RemoveAll(c => c.Expire.CompareTo(DateTime.Now) < 0);

            var exist = signatureCaptchas.Exists(c => c.PrivateKey == captcha && c.PublicKey == publicKey);

            if (!exist)
            {
                return BadRequest("کد امنیتی وارد شده صحیح نمی باشد");
            }
            else if (string.IsNullOrEmpty(mobile))
            {
                return BadRequest("تلفن همراه وارد نشده است");
            }

            var managerMobile = "";

            try
            {
                managerMobile = await connection.QueryFirstAsync<string>("select top 1 ManagerMobile from FormData where ManagerMobile = @mobile", new { mobile });
            }
            catch (Exception)
            {
                return NotFound("تلفن همراه یافت نشد");
            }

            if (string.IsNullOrEmpty(managerMobile))
            {
                return NotFound("تلفن همراه یافت نشد");
            }

            if (debug)
            {
                return Ok();
            }

            var result = "";
            result = await SendMessage(mobile);

            if (string.IsNullOrEmpty(result))
            {
                return Ok();
            }

            return StatusCode(StatusCodes.Status503ServiceUnavailable, result);
        }

        [NonAction]
        private async Task<string> SendMessage(string mobile)
        {
            Random rnd = new Random();
            var code = rnd.Next(100000, 999999);
            verifications.Add(new VerificationCode()
            {
                Mobile = mobile,
                Code = code.ToString(),
                Expire = DateTime.Now.AddSeconds(65)
            });

            SMSOnline.SendSoapClient client = new SMSOnline.SendSoapClient();

            var time = new TimeSpan(0, 50, 0);
            client.Endpoint.Binding.CloseTimeout = time;
            client.Endpoint.Binding.OpenTimeout = time;
            client.Endpoint.Binding.ReceiveTimeout = time;
            client.Endpoint.Binding.SendTimeout = time;

            ArrayOfString mobiles = new ArrayOfString();
            mobiles.AddRange(new string[] { mobile });

            ArrayOfLong recId = new ArrayOfLong();
            ArrayOfbyte status = new ArrayOfbyte();

            var result = await client.SendSmsAsync("int1", "int123", mobiles, "50001450", $"سامانه به روز رسانی اطلاعات مدارس\n {code}", false, "", recId, status);
            var id = result?.Body?.SendSmsResult;

            switch (id)
            {
                case 0:
                    return "نام کاربری یا رمز عبور صحیح نمی باشد";
                case 1:
                    return "";
                //return "پیامک ارسال شد";
                case 2:
                    return "اعتبار کافی نیست";
                case 3:
                    return "محدودیت در ارسال روزانه";
                case 4:
                    return "محدودیت در حجم ارسال";
                case 5:
                    return "شماره فرستنده معتبر نیست و یا غیرفعال می باشد";
                case 6:
                    return "شماره موبایل صحیح جهت ارسال وجود ندارد";
                case 7:
                    return "متن پیامک خالی می باشد";
                case 8:
                    return "کاربر ارسال کننده و یا سازنده ی آن غیر فعال می باشد";
                case 9:
                    return "تعداد شماره موبایل ها بیشتر از حد مجاز می باشد";
                case 100:
                    return "شما مجاز به استفاده از وب سرویس نمی باشید";
                default:
                    return "";
            }
        }

        [AllowAnonymous]
        [HttpGet]
        public IActionResult GenerateToken(string mobile, string code)
        {
            verifications.RemoveAll(c => c.Expire.CompareTo(DateTime.Now) < 0);
            var exist = verifications.Exists(c => c.Mobile == mobile && c.Code == code);

            if (exist || debug)
            {
                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("1qaz!QAZ2wsx@WSX"));
                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                var jwt = new JwtSecurityToken(
                    expires: DateTime.UtcNow.AddMinutes(60),
                    claims: new[] { new Claim(
                        JwtRegisteredClaimNames.Jti,
                        Guid.NewGuid().ToString()),
                        new Claim("Mobile", mobile),new Claim(ClaimTypes.Role,"DataEntry") },
                    signingCredentials: creds);

                string t = new JwtSecurityTokenHandler().WriteToken(jwt);

                return Ok(t);
            }

            return BadRequest("کد وارد شده صحیح نمی باشد");
        }
    }
}