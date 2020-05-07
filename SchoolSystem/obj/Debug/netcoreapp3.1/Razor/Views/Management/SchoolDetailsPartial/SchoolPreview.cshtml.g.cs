#pragma checksum "C:\Users\mostapha\source\repos\IranSmartSchool\SchoolSystem\Views\Management\SchoolDetailsPartial\SchoolPreview.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f9dc1594c05c896ac4f2d768bd22c4d7516a7dd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Management_SchoolDetailsPartial_SchoolPreview), @"mvc.1.0.view", @"/Views/Management/SchoolDetailsPartial/SchoolPreview.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 2 "C:\Users\mostapha\source\repos\IranSmartSchool\SchoolSystem\Views\_ViewImports.cshtml"
using SchoolSystem.Models.Home;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mostapha\source\repos\IranSmartSchool\SchoolSystem\Views\_ViewImports.cshtml"
using SchoolSystem.Models.Management;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f9dc1594c05c896ac4f2d768bd22c4d7516a7dd", @"/Views/Management/SchoolDetailsPartial/SchoolPreview.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"115745a9cdd022c73a79d01a0c8e65bb2248762e", @"/Views/_ViewImports.cshtml")]
    public class Views_Management_SchoolDetailsPartial_SchoolPreview : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SchoolDetails>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<style>
    .lable {
        display: block;
        font-weight: 600;
    }

    .cell-item {
        border: 1px solid gray;
        padding: 5px;
        font-size: 16px;
        line-height:30px;
    }
</style>

<div class=""box-shadow"">

    <div class=""box-header"">
        مشخصات مدرسه
    </div>

    <div class=""box-body"">

        <div class=""container-fluid p-0 text-right"" style=""direction:rtl;"">

            <div class=""row"">

                <div class=""col-4"">

                    <label class=""lable"">کد مدرسه</label>
                    <div id=""SchoolCode"" class=""cell-item""");
            BeginWriteAttribute("style", " style=\"", 644, "\"", 711, 2);
            WriteAttributeValue("", 652, "background-color:", 652, 17, true);
#nullable restore
#line 31 "C:\Users\mostapha\source\repos\IranSmartSchool\SchoolSystem\Views\Management\SchoolDetailsPartial\SchoolPreview.cshtml"
WriteAttributeValue("", 669, Model.SchoolCodeEdit ? "yellow":"white", 669, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 31 "C:\Users\mostapha\source\repos\IranSmartSchool\SchoolSystem\Views\Management\SchoolDetailsPartial\SchoolPreview.cshtml"
                                                                                                                          Write(Model.SchoolCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("&nbsp;</div>\r\n\r\n                </div>\r\n\r\n                <div class=\"col-4\">\r\n                    <label class=\"lable\">عنوان مدرسه</label>\r\n                    <div class=\"cell-item\"");
            BeginWriteAttribute("style", " style=\"", 913, "\"", 974, 2);
            WriteAttributeValue("", 921, "background-color:", 921, 17, true);
#nullable restore
#line 37 "C:\Users\mostapha\source\repos\IranSmartSchool\SchoolSystem\Views\Management\SchoolDetailsPartial\SchoolPreview.cshtml"
WriteAttributeValue("", 938, Model.NameEdit ? "yellow":"white", 938, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 37 "C:\Users\mostapha\source\repos\IranSmartSchool\SchoolSystem\Views\Management\SchoolDetailsPartial\SchoolPreview.cshtml"
                                                                                                    Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("&nbsp;</div>\r\n\r\n                </div>\r\n\r\n                <div class=\"col-4\">\r\n                    <label class=\"lable\">نوع</label>\r\n                    <div class=\"cell-item\"");
            BeginWriteAttribute("style", " style=\"", 1162, "\"", 1225, 2);
            WriteAttributeValue("", 1170, "background-color:", 1170, 17, true);
#nullable restore
#line 43 "C:\Users\mostapha\source\repos\IranSmartSchool\SchoolSystem\Views\Management\SchoolDetailsPartial\SchoolPreview.cshtml"
WriteAttributeValue("", 1187, Model.SubSetEdit ? "yellow":"white", 1187, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 43 "C:\Users\mostapha\source\repos\IranSmartSchool\SchoolSystem\Views\Management\SchoolDetailsPartial\SchoolPreview.cshtml"
                                                                                                      Write(Model.SubSet);

#line default
#line hidden
#nullable disable
            WriteLiteral("&nbsp;</div>\r\n\r\n                </div>\r\n\r\n            </div>\r\n\r\n            <div class=\"row\">\r\n\r\n                <div class=\"col-4\">\r\n\r\n                    <label class=\"lable\">جنسیت</label>\r\n                    <div class=\"cell-item\"");
            BeginWriteAttribute("style", " style=\"", 1474, "\"", 1537, 2);
            WriteAttributeValue("", 1482, "background-color:", 1482, 17, true);
#nullable restore
#line 54 "C:\Users\mostapha\source\repos\IranSmartSchool\SchoolSystem\Views\Management\SchoolDetailsPartial\SchoolPreview.cshtml"
WriteAttributeValue("", 1499, Model.GenderEdit ? "yellow":"white", 1499, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 54 "C:\Users\mostapha\source\repos\IranSmartSchool\SchoolSystem\Views\Management\SchoolDetailsPartial\SchoolPreview.cshtml"
                                                                                                      Write(Model.Gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("&nbsp;</div>\r\n\r\n                </div>\r\n\r\n                <div class=\"col-4\">\r\n                    <label class=\"lable\">نوبت تحصیلی</label>\r\n                    <div class=\"cell-item\">");
#nullable restore
#line 60 "C:\Users\mostapha\source\repos\IranSmartSchool\SchoolSystem\Views\Management\SchoolDetailsPartial\SchoolPreview.cshtml"
                                      Write(Model.StudyTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("&nbsp;</div>\r\n\r\n                </div>\r\n\r\n                <div class=\"col-4\">\r\n                    <label class=\"lable\">دوره تحصیلی</label>\r\n                    <div class=\"cell-item\"");
            BeginWriteAttribute("style", " style=\"", 1935, "\"", 1998, 2);
            WriteAttributeValue("", 1943, "background-color:", 1943, 17, true);
#nullable restore
#line 66 "C:\Users\mostapha\source\repos\IranSmartSchool\SchoolSystem\Views\Management\SchoolDetailsPartial\SchoolPreview.cshtml"
WriteAttributeValue("", 1960, Model.PeriodEdit ? "yellow":"white", 1960, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 66 "C:\Users\mostapha\source\repos\IranSmartSchool\SchoolSystem\Views\Management\SchoolDetailsPartial\SchoolPreview.cshtml"
                                                                                                      Write(Model.Period);

#line default
#line hidden
#nullable disable
            WriteLiteral("&nbsp;</div>\r\n\r\n                </div>\r\n\r\n            </div>\r\n\r\n            <div class=\"row\">\r\n\r\n                <div class=\"col-4\">\r\n\r\n                    <label class=\"lable\">تعداد پایه تحصیلی</label>\r\n                    <div class=\"cell-item\"");
            BeginWriteAttribute("style", " style=\"", 2259, "\"", 2326, 2);
            WriteAttributeValue("", 2267, "background-color:", 2267, 17, true);
#nullable restore
#line 77 "C:\Users\mostapha\source\repos\IranSmartSchool\SchoolSystem\Views\Management\SchoolDetailsPartial\SchoolPreview.cshtml"
WriteAttributeValue("", 2284, Model.BasicCountEdit ? "yellow":"white", 2284, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 77 "C:\Users\mostapha\source\repos\IranSmartSchool\SchoolSystem\Views\Management\SchoolDetailsPartial\SchoolPreview.cshtml"
                                                                                                          Write(Model.BasicCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("&nbsp;</div>\r\n\r\n                </div>\r\n\r\n                <div class=\"col-4\">\r\n                    <label class=\"lable\">تعداد معلم</label>\r\n                    <div class=\"cell-item\"");
            BeginWriteAttribute("style", " style=\"", 2527, "\"", 2596, 2);
            WriteAttributeValue("", 2535, "background-color:", 2535, 17, true);
#nullable restore
#line 83 "C:\Users\mostapha\source\repos\IranSmartSchool\SchoolSystem\Views\Management\SchoolDetailsPartial\SchoolPreview.cshtml"
WriteAttributeValue("", 2552, Model.TeacherCountEdit ? "yellow":"white", 2552, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 83 "C:\Users\mostapha\source\repos\IranSmartSchool\SchoolSystem\Views\Management\SchoolDetailsPartial\SchoolPreview.cshtml"
                                                                                                            Write(Model.TeacherCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("&nbsp;</div>\r\n\r\n                </div>\r\n\r\n                <div class=\"col-4\">\r\n                    <label class=\"lable\">تعداد دانش آموزان</label>\r\n                    <div class=\"cell-item\"");
            BeginWriteAttribute("style", " style=\"", 2806, "\"", 2872, 2);
            WriteAttributeValue("", 2814, "background-color:", 2814, 17, true);
#nullable restore
#line 89 "C:\Users\mostapha\source\repos\IranSmartSchool\SchoolSystem\Views\Management\SchoolDetailsPartial\SchoolPreview.cshtml"
WriteAttributeValue("", 2831, Model.StudyTimeEdit ? "yellow":"white", 2831, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 89 "C:\Users\mostapha\source\repos\IranSmartSchool\SchoolSystem\Views\Management\SchoolDetailsPartial\SchoolPreview.cshtml"
                                                                                                         Write(Model.StudentCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("&nbsp;</div>\r\n\r\n                </div>\r\n\r\n            </div>\r\n\r\n            <div class=\"row\">\r\n\r\n                <div class=\"col-4\">\r\n\r\n                    <label class=\"lable\">تلفن 1</label>\r\n                    <div class=\"cell-item\"");
            BeginWriteAttribute("style", " style=\"", 3128, "\"", 3190, 2);
            WriteAttributeValue("", 3136, "background-color:", 3136, 17, true);
#nullable restore
#line 100 "C:\Users\mostapha\source\repos\IranSmartSchool\SchoolSystem\Views\Management\SchoolDetailsPartial\SchoolPreview.cshtml"
WriteAttributeValue("", 3153, Model.Tell1Edit ? "yellow":"white", 3153, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 100 "C:\Users\mostapha\source\repos\IranSmartSchool\SchoolSystem\Views\Management\SchoolDetailsPartial\SchoolPreview.cshtml"
                                                                                                     Write(Model.Tell1);

#line default
#line hidden
#nullable disable
            WriteLiteral("&nbsp;</div>\r\n\r\n                </div>\r\n\r\n                <div class=\"col-4\">\r\n                    <label class=\"lable\">تلفن 2</label>\r\n                    <div class=\"cell-item\"");
            BeginWriteAttribute("style", " style=\"", 3382, "\"", 3444, 2);
            WriteAttributeValue("", 3390, "background-color:", 3390, 17, true);
#nullable restore
#line 106 "C:\Users\mostapha\source\repos\IranSmartSchool\SchoolSystem\Views\Management\SchoolDetailsPartial\SchoolPreview.cshtml"
WriteAttributeValue("", 3407, Model.Tell2Edit ? "yellow":"white", 3407, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 106 "C:\Users\mostapha\source\repos\IranSmartSchool\SchoolSystem\Views\Management\SchoolDetailsPartial\SchoolPreview.cshtml"
                                                                                                     Write(Model.Tell2);

#line default
#line hidden
#nullable disable
            WriteLiteral("&nbsp;</div>\r\n\r\n                </div>\r\n\r\n                <div class=\"col-4\">\r\n                    <label class=\"lable\">تلفن 3</label>\r\n                    <div class=\"cell-item\"");
            BeginWriteAttribute("style", " style=\"", 3636, "\"", 3698, 2);
            WriteAttributeValue("", 3644, "background-color:", 3644, 17, true);
#nullable restore
#line 112 "C:\Users\mostapha\source\repos\IranSmartSchool\SchoolSystem\Views\Management\SchoolDetailsPartial\SchoolPreview.cshtml"
WriteAttributeValue("", 3661, Model.Tell3Edit ? "yellow":"white", 3661, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 112 "C:\Users\mostapha\source\repos\IranSmartSchool\SchoolSystem\Views\Management\SchoolDetailsPartial\SchoolPreview.cshtml"
                                                                                                     Write(Model.Tell3);

#line default
#line hidden
#nullable disable
            WriteLiteral("&nbsp;</div>\r\n\r\n                </div>\r\n\r\n            </div>\r\n\r\n            <div class=\"row\">\r\n\r\n                <div class=\"col-4\">\r\n\r\n                    <label class=\"lable\">کدپستی</label>\r\n                    <div class=\"cell-item\"");
            BeginWriteAttribute("style", " style=\"", 3947, "\"", 4014, 2);
            WriteAttributeValue("", 3955, "background-color:", 3955, 17, true);
#nullable restore
#line 123 "C:\Users\mostapha\source\repos\IranSmartSchool\SchoolSystem\Views\Management\SchoolDetailsPartial\SchoolPreview.cshtml"
WriteAttributeValue("", 3972, Model.PostalCodeEdit ? "yellow":"white", 3972, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 123 "C:\Users\mostapha\source\repos\IranSmartSchool\SchoolSystem\Views\Management\SchoolDetailsPartial\SchoolPreview.cshtml"
                                                                                                          Write(Model.PostalCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("&nbsp;</div>\r\n\r\n                </div>\r\n\r\n                <div class=\"col-4\">\r\n                    <label class=\"lable\">اینترنت / سیار</label>\r\n                    <div class=\"cell-item\"");
            BeginWriteAttribute("style", " style=\"", 4219, "\"", 4290, 2);
            WriteAttributeValue("", 4227, "background-color:", 4227, 17, true);
#nullable restore
#line 129 "C:\Users\mostapha\source\repos\IranSmartSchool\SchoolSystem\Views\Management\SchoolDetailsPartial\SchoolPreview.cshtml"
WriteAttributeValue("", 4244, Model.MobileInternetEdit ? "yellow":"white", 4244, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 129 "C:\Users\mostapha\source\repos\IranSmartSchool\SchoolSystem\Views\Management\SchoolDetailsPartial\SchoolPreview.cshtml"
                                                                                                              Write(Model.MobileInternet);

#line default
#line hidden
#nullable disable
            WriteLiteral("&nbsp;</div>\r\n\r\n                </div>\r\n\r\n                <div class=\"col-4\">\r\n                    <label class=\"lable\">اینترنت / ثابت</label>\r\n                    <div class=\"cell-item\"");
            BeginWriteAttribute("style", " style=\"", 4499, "\"", 4560, 2);
            WriteAttributeValue("", 4507, "background-color:", 4507, 17, true);
#nullable restore
#line 135 "C:\Users\mostapha\source\repos\IranSmartSchool\SchoolSystem\Views\Management\SchoolDetailsPartial\SchoolPreview.cshtml"
WriteAttributeValue("", 4524, Model.ADSLEdit ? "yellow":"white", 4524, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 135 "C:\Users\mostapha\source\repos\IranSmartSchool\SchoolSystem\Views\Management\SchoolDetailsPartial\SchoolPreview.cshtml"
                                                                                                    Write(Model.ADSL);

#line default
#line hidden
#nullable disable
            WriteLiteral("&nbsp;</div>\r\n\r\n                </div>\r\n\r\n            </div>\r\n\r\n            <div class=\"row\">\r\n\r\n                <div class=\"col-4\">\r\n                    <label class=\"lable\">عکس 1</label>\r\n                    <div");
            BeginWriteAttribute("style", " style=\"", 4787, "\"", 5001, 15);
            WriteAttributeValue("", 4795, "height:", 4795, 7, true);
            WriteAttributeValue(" ", 4802, "200px;width:", 4803, 13, true);
            WriteAttributeValue(" ", 4815, "100%;border:", 4816, 13, true);
            WriteAttributeValue(" ", 4828, "1px", 4829, 4, true);
            WriteAttributeValue(" ", 4832, "solid", 4833, 6, true);
            WriteAttributeValue(" ", 4838, "gray;border-radius:", 4839, 20, true);
            WriteAttributeValue(" ", 4858, "5px", 4859, 4, true);
            WriteAttributeValue(" ", 4862, "5px;padding:", 4863, 13, true);
            WriteAttributeValue(" ", 4875, "10px;background-repeat:", 4876, 24, true);
            WriteAttributeValue(" ", 4899, "no-repeat;background-size:", 4900, 27, true);
            WriteAttributeValue(" ", 4926, "100%", 4927, 5, true);
            WriteAttributeValue(" ", 4931, "100%;background-position:", 4932, 26, true);
            WriteAttributeValue(" ", 4957, "center;background-image:url(", 4958, 29, true);
#nullable restore
#line 145 "C:\Users\mostapha\source\repos\IranSmartSchool\SchoolSystem\Views\Management\SchoolDetailsPartial\SchoolPreview.cshtml"
WriteAttributeValue("", 4986, Model.Image1, 4986, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4999, ");", 4999, 2, true);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n                </div>\r\n\r\n                <div class=\"col-4\">\r\n                    <label class=\"lable\">عکس 2</label>\r\n                    <div");
            BeginWriteAttribute("style", " style=\"", 5154, "\"", 5368, 15);
            WriteAttributeValue("", 5162, "height:", 5162, 7, true);
            WriteAttributeValue(" ", 5169, "200px;width:", 5170, 13, true);
            WriteAttributeValue(" ", 5182, "100%;border:", 5183, 13, true);
            WriteAttributeValue(" ", 5195, "1px", 5196, 4, true);
            WriteAttributeValue(" ", 5199, "solid", 5200, 6, true);
            WriteAttributeValue(" ", 5205, "gray;border-radius:", 5206, 20, true);
            WriteAttributeValue(" ", 5225, "5px", 5226, 4, true);
            WriteAttributeValue(" ", 5229, "5px;padding:", 5230, 13, true);
            WriteAttributeValue(" ", 5242, "10px;background-repeat:", 5243, 24, true);
            WriteAttributeValue(" ", 5266, "no-repeat;background-size:", 5267, 27, true);
            WriteAttributeValue(" ", 5293, "100%", 5294, 5, true);
            WriteAttributeValue(" ", 5298, "100%;background-position:", 5299, 26, true);
            WriteAttributeValue(" ", 5324, "center;background-image:url(", 5325, 29, true);
#nullable restore
#line 150 "C:\Users\mostapha\source\repos\IranSmartSchool\SchoolSystem\Views\Management\SchoolDetailsPartial\SchoolPreview.cshtml"
WriteAttributeValue("", 5353, Model.Image2, 5353, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5366, ");", 5366, 2, true);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n                </div>\r\n\r\n                <div class=\"col-4\">\r\n                    <label class=\"lable\">عکس 3</label>\r\n                    <div");
            BeginWriteAttribute("style", " style=\"", 5521, "\"", 5735, 15);
            WriteAttributeValue("", 5529, "height:", 5529, 7, true);
            WriteAttributeValue(" ", 5536, "200px;width:", 5537, 13, true);
            WriteAttributeValue(" ", 5549, "100%;border:", 5550, 13, true);
            WriteAttributeValue(" ", 5562, "1px", 5563, 4, true);
            WriteAttributeValue(" ", 5566, "solid", 5567, 6, true);
            WriteAttributeValue(" ", 5572, "gray;border-radius:", 5573, 20, true);
            WriteAttributeValue(" ", 5592, "5px", 5593, 4, true);
            WriteAttributeValue(" ", 5596, "5px;padding:", 5597, 13, true);
            WriteAttributeValue(" ", 5609, "10px;background-repeat:", 5610, 24, true);
            WriteAttributeValue(" ", 5633, "no-repeat;background-size:", 5634, 27, true);
            WriteAttributeValue(" ", 5660, "100%", 5661, 5, true);
            WriteAttributeValue(" ", 5665, "100%;background-position:", 5666, 26, true);
            WriteAttributeValue(" ", 5691, "center;background-image:url(", 5692, 29, true);
#nullable restore
#line 155 "C:\Users\mostapha\source\repos\IranSmartSchool\SchoolSystem\Views\Management\SchoolDetailsPartial\SchoolPreview.cshtml"
WriteAttributeValue("", 5720, Model.Image3, 5720, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5733, ");", 5733, 2, true);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n                </div>\r\n\r\n            </div>\r\n\r\n            <div class=\"row\">\r\n\r\n                <div class=\"col-12\">\r\n\r\n                    <label class=\"lable\">توضیحات</label>\r\n                    <div class=\"cell-item\"");
            BeginWriteAttribute("style", " style=\"", 5966, "\"", 6030, 2);
            WriteAttributeValue("", 5974, "background-color:", 5974, 17, true);
#nullable restore
#line 165 "C:\Users\mostapha\source\repos\IranSmartSchool\SchoolSystem\Views\Management\SchoolDetailsPartial\SchoolPreview.cshtml"
WriteAttributeValue("", 5991, Model.CommentEdit ? "yellow":"white", 5991, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 165 "C:\Users\mostapha\source\repos\IranSmartSchool\SchoolSystem\Views\Management\SchoolDetailsPartial\SchoolPreview.cshtml"
                                                                                                       Write(Model.Comment);

#line default
#line hidden
#nullable disable
            WriteLiteral("&nbsp;</div>\r\n\r\n\r\n                </div>\r\n\r\n            </div>\r\n\r\n            <div class=\"row\">\r\n\r\n                <div class=\"col-12\">\r\n\r\n                    <label class=\"lable\"");
            BeginWriteAttribute("style", " style=\"", 6225, "\"", 6302, 2);
            WriteAttributeValue("", 6233, "background-color:", 6233, 17, true);
#nullable restore
#line 176 "C:\Users\mostapha\source\repos\IranSmartSchool\SchoolSystem\Views\Management\SchoolDetailsPartial\SchoolPreview.cshtml"
WriteAttributeValue("", 6250, Model.LatEdit || Model.LngEdit ? "yellow":"white", 6250, 52, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">موقعیت مدرسه روی نقشه</label>
                    <div style=""margin:auto;height:500px;width:100%;"" id=""mapid""></div>

                </div>

            </div>

            <div class=""row"">

                <div class=""col-4"">

                    <label class=""lable"">استان</label>
                    <div class=""cell-item""");
            BeginWriteAttribute("style", " style=\"", 6644, "\"", 6710, 2);
            WriteAttributeValue("", 6652, "background-color:", 6652, 17, true);
#nullable restore
#line 188 "C:\Users\mostapha\source\repos\IranSmartSchool\SchoolSystem\Views\Management\SchoolDetailsPartial\SchoolPreview.cshtml"
WriteAttributeValue("", 6669, Model.OstanNameEdit ? "yellow":"white", 6669, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 188 "C:\Users\mostapha\source\repos\IranSmartSchool\SchoolSystem\Views\Management\SchoolDetailsPartial\SchoolPreview.cshtml"
                                                                                                         Write(Model.OstanName);

#line default
#line hidden
#nullable disable
            WriteLiteral("&nbsp;</div>\r\n\r\n                </div>\r\n\r\n                <div class=\"col-4\">\r\n                    <label class=\"lable\">شهرستان</label>\r\n                    <div class=\"cell-item\"");
            BeginWriteAttribute("style", " style=\"", 6907, "\"", 6978, 2);
            WriteAttributeValue("", 6915, "background-color:", 6915, 17, true);
#nullable restore
#line 194 "C:\Users\mostapha\source\repos\IranSmartSchool\SchoolSystem\Views\Management\SchoolDetailsPartial\SchoolPreview.cshtml"
WriteAttributeValue("", 6932, Model.ShahrestanNameEdit ? "yellow":"white", 6932, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 194 "C:\Users\mostapha\source\repos\IranSmartSchool\SchoolSystem\Views\Management\SchoolDetailsPartial\SchoolPreview.cshtml"
                                                                                                              Write(Model.ShahrestanName);

#line default
#line hidden
#nullable disable
            WriteLiteral("&nbsp;</div>\r\n\r\n                </div>\r\n\r\n                <div class=\"col-4\">\r\n                    <label class=\"lable\">بخش</label>\r\n                    <div class=\"cell-item\"");
            BeginWriteAttribute("style", " style=\"", 7176, "\"", 7243, 2);
            WriteAttributeValue("", 7184, "background-color:", 7184, 17, true);
#nullable restore
#line 200 "C:\Users\mostapha\source\repos\IranSmartSchool\SchoolSystem\Views\Management\SchoolDetailsPartial\SchoolPreview.cshtml"
WriteAttributeValue("", 7201, Model.BakhshNameEdit ? "yellow":"white", 7201, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 200 "C:\Users\mostapha\source\repos\IranSmartSchool\SchoolSystem\Views\Management\SchoolDetailsPartial\SchoolPreview.cshtml"
                                                                                                          Write(Model.BakhshName);

#line default
#line hidden
#nullable disable
            WriteLiteral("&nbsp;</div>\r\n\r\n                </div>\r\n\r\n            </div>\r\n\r\n            <div class=\"row\">\r\n\r\n                <div class=\"col-4\">\r\n\r\n                    <label class=\"lable\">دهستان</label>\r\n                    <div class=\"cell-item\"");
            BeginWriteAttribute("style", " style=\"", 7497, "\"", 7566, 2);
            WriteAttributeValue("", 7505, "background-color:", 7505, 17, true);
#nullable restore
#line 211 "C:\Users\mostapha\source\repos\IranSmartSchool\SchoolSystem\Views\Management\SchoolDetailsPartial\SchoolPreview.cshtml"
WriteAttributeValue("", 7522, Model.DehestanNameEdit ? "yellow":"white", 7522, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 211 "C:\Users\mostapha\source\repos\IranSmartSchool\SchoolSystem\Views\Management\SchoolDetailsPartial\SchoolPreview.cshtml"
                                                                                                            Write(Model.DehestanName);

#line default
#line hidden
#nullable disable
            WriteLiteral("&nbsp;</div>\r\n\r\n                </div>\r\n\r\n                <div class=\"col-4\">\r\n                    <label class=\"lable\">روستا</label>\r\n                    <div class=\"cell-item\"");
            BeginWriteAttribute("style", " style=\"", 7764, "\"", 7830, 2);
            WriteAttributeValue("", 7772, "background-color:", 7772, 17, true);
#nullable restore
#line 217 "C:\Users\mostapha\source\repos\IranSmartSchool\SchoolSystem\Views\Management\SchoolDetailsPartial\SchoolPreview.cshtml"
WriteAttributeValue("", 7789, Model.AbadiNameEdit ? "yellow":"white", 7789, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 217 "C:\Users\mostapha\source\repos\IranSmartSchool\SchoolSystem\Views\Management\SchoolDetailsPartial\SchoolPreview.cshtml"
                                                                                                         Write(Model.AbadiName);

#line default
#line hidden
#nullable disable
            WriteLiteral("&nbsp;</div>\r\n\r\n                </div>\r\n\r\n                <div class=\"col-4\">\r\n                    <label class=\"lable\">کد آماری</label>\r\n                    <div class=\"cell-item\"");
            BeginWriteAttribute("style", " style=\"", 8028, "\"", 8093, 2);
            WriteAttributeValue("", 8036, "background-color:", 8036, 17, true);
#nullable restore
#line 223 "C:\Users\mostapha\source\repos\IranSmartSchool\SchoolSystem\Views\Management\SchoolDetailsPartial\SchoolPreview.cshtml"
WriteAttributeValue("", 8053, Model.AmarcodeEdit ? "yellow":"white", 8053, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 223 "C:\Users\mostapha\source\repos\IranSmartSchool\SchoolSystem\Views\Management\SchoolDetailsPartial\SchoolPreview.cshtml"
                                                                                                        Write(Model.Amarcode);

#line default
#line hidden
#nullable disable
            WriteLiteral("&nbsp;</div>\r\n\r\n                </div>\r\n\r\n            </div>\r\n            <div class=\"row\">\r\n\r\n                <div class=\"col-4\">\r\n\r\n                    <label class=\"lable\">کد منطقه</label>\r\n                    <div class=\"cell-item\"");
            BeginWriteAttribute("style", " style=\"", 8345, "\"", 8410, 2);
            WriteAttributeValue("", 8353, "background-color:", 8353, 17, true);
#nullable restore
#line 233 "C:\Users\mostapha\source\repos\IranSmartSchool\SchoolSystem\Views\Management\SchoolDetailsPartial\SchoolPreview.cshtml"
WriteAttributeValue("", 8370, Model.AreaCodeEdit ? "yellow":"white", 8370, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 233 "C:\Users\mostapha\source\repos\IranSmartSchool\SchoolSystem\Views\Management\SchoolDetailsPartial\SchoolPreview.cshtml"
                                                                                                        Write(Model.AreaCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("&nbsp;</div>\r\n\r\n                </div>\r\n\r\n                <div class=\"col-4\">\r\n                    <label class=\"lable\">نام منطقه</label>\r\n                    <div class=\"cell-item\"");
            BeginWriteAttribute("style", " style=\"", 8608, "\"", 8673, 2);
            WriteAttributeValue("", 8616, "background-color:", 8616, 17, true);
#nullable restore
#line 239 "C:\Users\mostapha\source\repos\IranSmartSchool\SchoolSystem\Views\Management\SchoolDetailsPartial\SchoolPreview.cshtml"
WriteAttributeValue("", 8633, Model.AreaNameEdit ? "yellow":"white", 8633, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 239 "C:\Users\mostapha\source\repos\IranSmartSchool\SchoolSystem\Views\Management\SchoolDetailsPartial\SchoolPreview.cshtml"
                                                                                                        Write(Model.AreaName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"&nbsp;</div>

                </div>

                <div class=""col-4"">
                </div>

            </div>

            <div class=""row"">

                <div class=""col-12"">

                    <label class=""lable"">آدرس</label>
                    <div class=""cell-item""");
            BeginWriteAttribute("style", " style=\"", 8987, "\"", 9051, 2);
            WriteAttributeValue("", 8995, "background-color:", 8995, 17, true);
#nullable restore
#line 253 "C:\Users\mostapha\source\repos\IranSmartSchool\SchoolSystem\Views\Management\SchoolDetailsPartial\SchoolPreview.cshtml"
WriteAttributeValue("", 9012, Model.AddressEdit ? "yellow":"white", 9012, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 253 "C:\Users\mostapha\source\repos\IranSmartSchool\SchoolSystem\Views\Management\SchoolDetailsPartial\SchoolPreview.cshtml"
                                                                                                       Write(Model.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"&nbsp;</div>

                </div>

            </div>


            <div class=""row"">
                <div class=""col-12"">
                    <br />
                    <br />
                    <div style=""display:flex;flex-direction:row-reverse;justify-content:space-between;"">
                        <button id=""btnConfirm"" class=""btn btn-lg btn-outline-success"">تایید</button>
                        <button id=""btnReject"" class=""btn btn-lg btn-outline-danger"">عدم تایید</button>
                    </div>


                </div>
            </div>

        </div>

    </div>

</div>


<script>

    $(""#btnConfirm"").on(""click"", function () {

        Swal.fire({
            title: """",
            html: ""<span style='font-family:Behdad;'><span style='font-size:18px;'>"" + ""آیا برای تایید مطمئن هستید؟"" + ""</span></span>"",
            icon: 'warning',
            showCancelButton: true,
            focusCancel:true,
            cancelButtonText : ""خیر"",
            con");
            WriteLiteral(@"firmButtonText: ""بله"",
        }).then((result) => {
            if (result.value) {

                var mainCode = $(""#hiddenMainCode"").val();
                schoolConfirm(mainCode, 4);

            }
        })

    });

    $(""#btnReject"").on(""click"", function () {

        Swal.fire({
            title: """",
            html: ""<span style='font-family:Behdad;'><span style='font-size:18px;'>"" + ""آیا برای عدم تایید مطمئن هستید؟"" + ""</span></span>"",
            icon: 'warning',
            showCancelButton: true,
            focusCancel: true,
            cancelButtonText: ""خیر"",
            confirmButtonText: ""بله"",
        }).then((result) => {
            if (result.value) {
                var mainCode = $(""#hiddenMainCode"").val();
                schoolConfirm(mainCode, 5);
            }
        })

    });

    function schoolConfirm(mainCode, status) {

        var t = localStorage.getItem(""Token"");

        $.ajax({
            url: ""/Management/SchoolConfirm?main");
            WriteLiteral(@"Code="" + mainCode + ""&status="" + status,
            method: ""POST"",
            headers: {
                ""Authorization"": t
            },
            success: function (res) {
                Swal.fire({
                    title: '',
                    html: ""<span style='font-family:Behdad'><span style='font-size:15px;'>عملیات موفقیت انجام شد</span></span>"",
                    type: 'success',
                    showCancelButton: false,
                    showConfirmButton: true,
                    confirmButtonText: ""بستن""
                });
            },
            error: function (err) {
                Swal.fire({
                    title: '',
                    html: ""<span style='font-family:Behdad;'><span style='font-size:18px;'>عملیات خطا مواجه شد</span></span>"",
                    type: 'error',
                    showCancelButton: false,
                    showConfirmButton: false
                });
            }
        });
    }

</script>


");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SchoolDetails> Html { get; private set; }
    }
}
#pragma warning restore 1591
