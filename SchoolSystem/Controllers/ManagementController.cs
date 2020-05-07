using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using SchoolSystem.Models;
using SchoolSystem.Models.Management;
using SchoolSystem.PublicClass;

namespace SchoolSystem.Controllers
{
    public class ManagementController : Controller
    {
        private readonly SqlConnection connection;
        public ManagementController(IConfiguration configuration)
        {
            connection = new SqlConnection(configuration.GetSection("ConnectionString").Value);
        }

        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        public async Task<IActionResult> SchoolDetails(string mainCode)
        {
            var result = await connection.QueryFirstAsync<SchoolDetails>(@"exec [SchoolDetailsByMainCode] @mainCode", new { mainCode });
            ViewBag.mainCode = mainCode;
            return View(result);
        }

        [Authorize(Roles = "Management")]
        public async Task<IActionResult> SchoolConfirm(string mainCode, string status)
        {
            if (string.IsNullOrEmpty(mainCode) || string.IsNullOrEmpty(status))
            {
                return BadRequest("هیچ دیتایی ارسال نشده است");
            }

            var result = await connection.ExecuteAsync(@"update FormData set [Status] = @status 
                                                       where id in (select max(id) from formdata where MainCode = @mainCode)",
                                                       new { mainCode, status });

            if (result > 0)
            {
                return Ok();
            }

            return NotFound();
        }

        [AllowAnonymous]
        public async Task<IActionResult> GenerateToken(string username = "", string password = "")
        {
            var userId = await connection.QueryFirstOrDefaultAsync<int>(@"select id from users where username=@username and password=@password", new { username, password });

            if (userId == 0)
            {
                return BadRequest("نام کاربری و یا رمزعبور صحیح نمی باشد");
            }

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("1qaz!QAZ2wsx@WSX"));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var jwt = new JwtSecurityToken(
                expires: DateTime.UtcNow.AddMinutes(60),
                claims: new[] {
                    new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString()),
                    new Claim(ClaimTypes.Role,"Management"),
                    new Claim("UserId",userId.ToString())
                },
                signingCredentials: creds);

            string t = new JwtSecurityTokenHandler().WriteToken(jwt);
            return Ok(t);

        }

        [Authorize(Roles = "Management")]
        //[AllowAnonymous]
        [HttpGet, HttpPost]
        public async Task<JsonResult> ReportSchoolPerOstan()
        {
            var userId = User.Claims.FirstOrDefault(c => c.Type == "UserId").Value;
            var result = await connection.QueryAsync<ReportSchoolPerOstan>(@"exec [ReportSchoolPerOstan] @userId", new { userId });
            var resultCount = await connection.QueryFirstAsync<int>(@"exec [ReportSchoolPerOstanCount] @userId", new { userId });
            return Json(new
            {
                Data = result,
                Total = resultCount
            });
        }

        [Authorize(Roles = "Management")]
        //[AllowAnonymous]
        [HttpPost, HttpGet]
        public async Task<JsonResult> ReportSchoolPerOstanDetails([DataSourceRequest]DataSourceRequest request, string amarcode = "1398")
        {
            string name = "";
            string isCity = "";
            string managerName = "";
            string managerMobile = "";
            string insertDate = "";
            string status = "";
            int pageNumber = 1;
            int pageSize = 5;
            DateTime? Startdate=DateTime.Now.Date;
            try
            {
                var descriptors = new KendoUtilities().GetAllFilter(request.Filters.FirstOrDefault()).ToList();
                name = descriptors?.FirstOrDefault(x => x.Member == "name")?.Value?.ToString() ?? "";
                isCity = descriptors?.FirstOrDefault(x => x.Member == "isCity")?.Value?.ToString() ?? "";
                managerName = descriptors?.FirstOrDefault(x => x.Member == "managerName")?.Value?.ToString() ?? "";
                managerMobile = descriptors?.FirstOrDefault(x => x.Member == "managerMobile")?.Value?.ToString() ?? "";
                insertDate = descriptors?.FirstOrDefault(x => x.Member == "insertDate")?.Value?.ToString() ?? "";
                status = descriptors?.FirstOrDefault(x => x.Member == "status")?.Value?.ToString() ?? "";
                pageNumber = request.Page;
                pageSize = request.PageSize;
            }
            catch (Exception ex)
            {
            }
 

            if (!(string.IsNullOrWhiteSpace(insertDate) || string.IsNullOrEmpty(insertDate)))
            {

              
                Conversion conv=new Conversion();

                 Startdate= conv.PersianToMiladiCalendar(insertDate);
                
            }

 

            var result = await connection.QueryAsync<ReportSchoolPerOstanDetails>
             (@"exec [ReportSchoolPerOstanDetails] @amarcode,@name,@isCity,@managerName,@managerMobile,@status,@Startdate,@pageNumber,@pageSize",
             new { amarcode, name, isCity, managerName, managerMobile, status, Startdate, pageNumber, pageSize });

            var resultCount = await connection.QueryFirstAsync<int>
                (@"exec [ReportSchoolPerOstanDetailsCount] @amarcode,@name,@isCity,@managerName,@managerMobile,@status,@Startdate",
                new { amarcode, name, isCity, managerName, managerMobile, status, Startdate });
 
            Conversion cn = new Conversion();

            return Json(new
            {
                Data = result,
                Total = resultCount
            });
        }

        [Authorize(Roles = "Management")]
        [HttpGet]
        public async Task<IActionResult> ReportSchoolDownloadExcel()
        {
            var userId = User.Claims.FirstOrDefault(c => c.Type == "UserId").Value;
            var result = await connection.QueryAsync<ReportSchoolExcel>(@"exec [ReportSchoolForExcel] @userId", new { userId });
            var resultCount = result.Count();

            byte[] fileContents = new byte[] { };

            try
            {

                using (var package = new ExcelPackage())
                {
                    var worksheet = package.Workbook.Worksheets.Add("Sheet1");
                    var rowIndex = 1;

                    worksheet.Cells.Style.Fill.PatternType = ExcelFillStyle.None;

                    worksheet.Column(1).Width = 20;
                    worksheet.Column(2).Width = 20;
                    worksheet.Column(3).Width = 25;
                    worksheet.Column(4).Width = 25;
                    worksheet.Column(5).Width = 25;
                    worksheet.Column(6).Width = 25;
                    worksheet.Column(7).Width = 25;
                    worksheet.Column(8).Width = 30;
                    worksheet.Column(9).Width = 25;
                    worksheet.Column(10).Width = 25;
                    worksheet.Column(11).Width = 25;
                    worksheet.Column(12).Width = 25;
                    worksheet.Column(13).Width = 25;
                    worksheet.Column(14).Width = 25;
                    worksheet.Column(15).Width = 25;
                    worksheet.Column(16).Width = 25;
                    worksheet.Column(17).Width = 25;
                    worksheet.Column(18).Width = 25;
                    worksheet.Column(19).Width = 25;
                    worksheet.Column(20).Width = 25;
                    worksheet.Column(21).Width = 25;
                    worksheet.Column(22).Width = 25;
                    worksheet.Column(23).Width = 25;
                    worksheet.Column(24).Width = 25;
                    worksheet.Column(25).Width = 25;
                    worksheet.Column(26).Width = 25;
                    worksheet.Column(27).Width = 25;
                    worksheet.Column(28).Width = 25;
                    worksheet.Column(29).Width = 25;

                    worksheet.Row(1).Height = 50;

                    worksheet.Cells["A1:AD1"].Style.Fill.PatternType = ExcelFillStyle.Solid;
                    worksheet.Cells["A1:AD1"].Style.Fill.BackgroundColor.SetColor(Color.FromArgb(255, 244, 177, 131));
                    worksheet.Cells["A1:AD1"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    worksheet.Cells["A1:AD1"].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                    worksheet.Cells["A1:AD1"].Style.Font.Bold = true;
                    worksheet.Cells["A1:AD1"].Style.Font.Size = 14;

                    worksheet.Cells["A1:AD1"].Style.Border.Top.Style = ExcelBorderStyle.Thin;
                    worksheet.Cells["A1:AD1"].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                    worksheet.Cells["A1:AD1"].Style.Border.Left.Style = ExcelBorderStyle.Thin;
                    worksheet.Cells["A1:AD1"].Style.Border.Right.Style = ExcelBorderStyle.Thin;

                    worksheet.Cells[$"A2:AD{resultCount + 1}"].Style.Fill.PatternType = ExcelFillStyle.Solid;
                    worksheet.Cells[$"A2:AD{resultCount + 1}"].Style.Fill.BackgroundColor.SetColor(Color.FromArgb(255, 251, 229, 213));
                    worksheet.Cells[$"A1:AD{resultCount + 1}"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    worksheet.Cells[$"A1:AD{resultCount + 1}"].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                    worksheet.Cells[$"A2:AD{resultCount + 1}"].Style.Font.Size = 12;

                    worksheet.Cells[$"A1:AD{resultCount + 1}"].Style.Border.Top.Style = ExcelBorderStyle.Thin;
                    worksheet.Cells[$"A1:AD{resultCount + 1}"].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                    worksheet.Cells[$"A1:AD{resultCount + 1}"].Style.Border.Left.Style = ExcelBorderStyle.Thin;
                    worksheet.Cells[$"A1:AD{resultCount + 1}"].Style.Border.Right.Style = ExcelBorderStyle.Thin;

                    worksheet.Cells[rowIndex, 1].Value = "آمارکد";
                    worksheet.Cells[rowIndex, 2].Value = "محل استقرار";
                    worksheet.Cells[rowIndex, 3].Value = "وضعیت";
                    worksheet.Cells[rowIndex, 4].Value = "استان";
                    worksheet.Cells[rowIndex, 5].Value = "شهرستان";
                    worksheet.Cells[rowIndex, 6].Value = "بخش";
                    worksheet.Cells[rowIndex, 7].Value = "دهستان";
                    worksheet.Cells[rowIndex, 8].Value = "روستا";
                    worksheet.Cells[rowIndex, 9].Value = "نام مدیر";
                    worksheet.Cells[rowIndex, 10].Value = "تلفن همراه مدیر";
                    worksheet.Cells[rowIndex, 11].Value = "کد ملی مدیر";
                    worksheet.Cells[rowIndex, 12].Value = "کد مدرسه";
                    worksheet.Cells[rowIndex, 13].Value = "نام مدرسه";
                    worksheet.Cells[rowIndex, 14].Value = "نام منطقه";
                    worksheet.Cells[rowIndex, 15].Value = "کد منطقه";
                    worksheet.Cells[rowIndex, 16].Value = "دوره تحصیلی";
                    worksheet.Cells[rowIndex, 17].Value = "نوع";
                    worksheet.Cells[rowIndex, 18].Value = "جنسیت";
                    worksheet.Cells[rowIndex, 19].Value = "آدرس";
                    worksheet.Cells[rowIndex, 20].Value = "تلفن 1";
                    worksheet.Cells[rowIndex, 21].Value = "تلفن 2";
                    worksheet.Cells[rowIndex, 22].Value = "تلفن 3";
                    worksheet.Cells[rowIndex, 23].Value = "تعداد دانش آموز";
                    worksheet.Cells[rowIndex, 24].Value = "تعداد پایه تحصیلی";
                    worksheet.Cells[rowIndex, 25].Value = "تعداد معلم";
                    worksheet.Cells[rowIndex, 26].Value = "نوبت تحصیلی";
                    worksheet.Cells[rowIndex, 27].Value = "کدپستی";
                    worksheet.Cells[rowIndex, 28].Value = "اینترنت سیار";
                    worksheet.Cells[rowIndex, 29].Value = "اینترنت ثابت";
                    worksheet.Cells[rowIndex, 30].Value = "توضیحات";

                    if (resultCount == 0)
                    {
                        rowIndex += 1;
                        worksheet.Cells[rowIndex, 1].Value = "";
                        worksheet.Cells[rowIndex, 2].Value = "";
                        worksheet.Cells[rowIndex, 3].Value = "";
                        worksheet.Cells[rowIndex, 4].Value = "";
                        worksheet.Cells[rowIndex, 5].Value = "";
                        worksheet.Cells[rowIndex, 6].Value = "";
                        worksheet.Cells[rowIndex, 7].Value = "";
                        worksheet.Cells[rowIndex, 8].Value = "";
                        worksheet.Cells[rowIndex, 9].Value = "";
                        worksheet.Cells[rowIndex, 10].Value = "";
                        worksheet.Cells[rowIndex, 11].Value = "";
                        worksheet.Cells[rowIndex, 12].Value = "";
                        worksheet.Cells[rowIndex, 13].Value = "";
                        worksheet.Cells[rowIndex, 14].Value = "";
                        worksheet.Cells[rowIndex, 15].Value = "";
                        worksheet.Cells[rowIndex, 16].Value = "";
                        worksheet.Cells[rowIndex, 17].Value = "";
                        worksheet.Cells[rowIndex, 18].Value = "";
                        worksheet.Cells[rowIndex, 19].Value = "";
                        worksheet.Cells[rowIndex, 20].Value = "";
                        worksheet.Cells[rowIndex, 21].Value = "";
                        worksheet.Cells[rowIndex, 22].Value = "";
                        worksheet.Cells[rowIndex, 23].Value = "";
                        worksheet.Cells[rowIndex, 24].Value = "";
                        worksheet.Cells[rowIndex, 25].Value = "";
                        worksheet.Cells[rowIndex, 26].Value = "";
                        worksheet.Cells[rowIndex, 27].Value = "";
                        worksheet.Cells[rowIndex, 28].Value = "";
                        worksheet.Cells[rowIndex, 29].Value = "";
                        worksheet.Cells[rowIndex, 30].Value = "";
                    }
                    else
                    {
                        foreach (var row in result)
                        {
                            rowIndex += 1;
                            worksheet.Cells[rowIndex, 1].Value = row.Amarcode;
                            worksheet.Cells[rowIndex, 2].Value = row.IsCity;
                            worksheet.Cells[rowIndex, 3].Value = row.Status;
                            worksheet.Cells[rowIndex, 4].Value = row.OstanName;
                            worksheet.Cells[rowIndex, 5].Value = row.ShahrestanName;
                            worksheet.Cells[rowIndex, 6].Value = row.BakhshName;
                            worksheet.Cells[rowIndex, 7].Value = row.DehestanName;
                            worksheet.Cells[rowIndex, 8].Value = row.AbadiName;
                            worksheet.Cells[rowIndex, 9].Value = row.ManagerName;
                            worksheet.Cells[rowIndex, 10].Value = row.ManagerMobile;
                            worksheet.Cells[rowIndex, 11].Value = row.ManagerNationalCode;
                            worksheet.Cells[rowIndex, 12].Value = row.SchoolCode;
                            worksheet.Cells[rowIndex, 13].Value = row.Name;
                            worksheet.Cells[rowIndex, 14].Value = row.AreaName;
                            worksheet.Cells[rowIndex, 15].Value = row.AreaCode;
                            worksheet.Cells[rowIndex, 16].Value = row.Period;
                            worksheet.Cells[rowIndex, 17].Value = row.SubSet;
                            worksheet.Cells[rowIndex, 18].Value = row.Gender;
                            worksheet.Cells[rowIndex, 19].Value = row.Address;
                            worksheet.Cells[rowIndex, 20].Value = row.Tell1;
                            worksheet.Cells[rowIndex, 21].Value = row.Tell2;
                            worksheet.Cells[rowIndex, 22].Value = row.Tell3;
                            worksheet.Cells[rowIndex, 23].Value = row.StudentCount;
                            worksheet.Cells[rowIndex, 24].Value = row.BasicCount;
                            worksheet.Cells[rowIndex, 25].Value = row.TeacherCount;
                            worksheet.Cells[rowIndex, 26].Value = row.StudyTime;
                            worksheet.Cells[rowIndex, 27].Value = row.PostalCode;
                            worksheet.Cells[rowIndex, 28].Value = row.MobileInternet;
                            worksheet.Cells[rowIndex, 29].Value = row.ADSL;
                            worksheet.Cells[rowIndex, 30].Value = row.Comment;
                        }
                    }

                    worksheet.Cells[$"A1:AD{resultCount + 1}"].Style.Font.Name = "Tahoma";
                    worksheet.Cells[$"A1:AD{resultCount + 1}"].Style.Font.Size = 12;
                    worksheet.Cells[$"A1:AD1"].Style.Font.Bold = true;

                    fileContents = package.GetAsByteArray();
                }

                return File(
                    fileContents: fileContents,
                    contentType: "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                    fileDownloadName: "ReportSchoolExcel.xlsx"
                );
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}