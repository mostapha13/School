#pragma checksum "C:\Users\mostapha\source\repos\IranSmartSchool\SchoolSystem\Views\Home\IndexPartial\SchoolAddress.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4dd6c1cbfb52cea2a2811ca7904d3df7842f1e97"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_IndexPartial_SchoolAddress), @"mvc.1.0.view", @"/Views/Home/IndexPartial/SchoolAddress.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4dd6c1cbfb52cea2a2811ca7904d3df7842f1e97", @"/Views/Home/IndexPartial/SchoolAddress.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"115745a9cdd022c73a79d01a0c8e65bb2248762e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_IndexPartial_SchoolAddress : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""col-12 d-none scrollingContent"">
<div class=""box-shadow"">
    <div class=""box-body"">
        <div class=""container-fluid p-0"" style=""text-align:right;direction:rtl;"">

            <div class=""titleBox"">
                <h1>مشخصات مکانی مدرسه</h1>
                <span></span>
            </div>
            <p class=""hint"">
                اطلاعات مکانی مدرسه با توجه به داده های وزارت آموزش و پرورش در ادامه آمده است. خواهشمند است چنانچه موردی نیاز به اصلاح دارد با استفاده از گزینه ""ویرایش"" اقدام به تغییر آن نموده و سپس گزینه ""ثبت/ ادامه"" را کلیک نمائید.
            </p>

            <div class=""row"">
                <div class=""col-12"" style=""text-align:right;"">

                    <lable class=""lable"">موقعیت مدرسه روی نقشه</lable>

                    <div class=""item-box-container"">
");
            WriteLiteral(@"                            <div style=""margin:auto;height:500px;width:100%;"" id=""mapid""></div>

                    </div>

                    <div class=""row"">

                        <div class=""col-md-6"">

                            <lable class=""lable"">استان</lable>

                            <div class=""item-box-container"">

                                <div class=""item-box"">

                                    <div class=""item-box-screen-select-box""></div>

                                    <select id=""ddOstan"" class=""select2"" style=""width:100%;"">
                                    </select>


                                </div>

                                <button class=""btn-edit btn btn-sm btn-outline-primary mr-2"">ویرایش</button>

                            </div>

                        </div>

                        <div class=""col-md-6"">
                            <lable class=""lable"">شهرستان</lable>

                            <div class=""it");
            WriteLiteral(@"em-box-container"">

                                <div class=""item-box"">
                                    <div id=""itemBoxScreenShahrestan"" class=""item-box-screen-select-box""></div>


                                    <select id=""ddShahrestan"" class=""select2"" style=""width:100%;"">
                                    </select>

                                </div>

                                <button  id=""btnShahrestan"" class=""btn-edit btn btn-sm btn-outline-primary mr-2"">ویرایش</button>

                            </div>
                        </div>

                    </div>

                    <div class=""row"">

                        <div class=""col-md-6"">
                            <lable class=""lable"">بخش</lable>

                            <div class=""item-box-container"">

                                <div class=""item-box"">
                                    <div id=""itemBoxScreenBakhsh"" class=""item-box-screen-select-box""></div>

                      ");
            WriteLiteral(@"              <select id=""ddBakhsh"" class=""select2"" style=""width:100%;"">
                                    </select>

                                </div>

                                <button  id=""btnBakhsh"" class=""btn-edit btn btn-sm btn-outline-primary mr-2"">ویرایش</button>

                            </div>
                        </div>

                        <div class=""col-md-6"">
                            <lable class=""lable"">دهستان</lable>

                            <div class=""item-box-container"">

                                <div class=""item-box"">
                                    <div id=""itemBoxScreenDehestan"" class=""item-box-screen-select-box""></div>

                                    <select id=""ddDehestan"" class=""select2"" style=""width:100%;"">
                                    </select>


                                </div>

                                <button  id=""btnDehestan"" class=""btn-edit btn btn-sm btn-outline-primary mr-2"">ویرایش</but");
            WriteLiteral(@"ton>

                            </div>

                        </div>

                    </div>

                    <div class=""row"">

                        <div class=""col-md-6"">
                            <lable class=""lable"">روستا</lable>

                            <div class=""item-box-container"">

                                <div class=""item-box"">
                                    <div id=""itemBoxScreenRoosta"" class=""item-box-screen-select-box""></div>


                                    <select id=""ddRoosta"" class=""select2"" style=""width:100%;"">
                                    </select>


                                </div>

                                <button  id=""btnRoosta"" class=""btn-edit btn btn-sm btn-outline-primary mr-2"">ویرایش</button>

                            </div>

                        </div>


                        <div class=""col-md-6"">
                            <lable class=""lable"">کد آبادی</lable>
                    ");
            WriteLiteral(@"        <div id=""divAmarcode"" style=""
                                        border: 2px solid #D0CCE4;
                                        background: #e2e2e2;
                                        border-radius: 25px;
                                        padding: 12px 16px;
                            "">
                                0
                            </div>
                        </div>

                    </div>

                    <div class=""row"">
                        <div class=""col-12"" style=""text-align:right;"">

                            <lable class=""lable"">آدرس</lable>

                            <div class=""item-box-container"">

                                <div class=""item-box"">
                                    <div class=""item-box-screen-area-box""></div>

                                    <textarea id=""txtSchoolAddress"" rows=""3"" class=""area-box"" style=""resize:none;"">
                                    </textarea>
                 ");
            WriteLiteral(@"               </div>

                                <button class=""btn-edit btn btn-sm btn-outline-primary mr-2"">ویرایش</button>

                            </div>

                        </div>
                    </div>

                    <div class=""row"">
                        <div class=""col-12"">
                            <br />
                            <br />
                            <div style=""display:flex;flex-direction:row-reverse;justify-content:space-between;"">
                                <button id=""btnAcceptAddress"" class=""btn btn-outline-primary btn-lg"">ثبت / ادامه</button>
                                <button class=""btn-prev btn btn-outline-warning btn-lg"">برگشت</button>
                            </div>
                        </div>
                    </div>

                </div>
            </div>
        </div>
    </div>
</div>

<script>

    $(""#btnAcceptAddress"").on(""click"", function () {

        var data = $(""#ddOstan"").select2(");
            WriteLiteral(@"'data');
        console.log(data, ""select2"");

        resetEdit();
        var displayParent = $(this).closest("".box-shadow"").parent();
        $(displayParent).addClass(""d-none"");
        $(displayParent).next().removeClass(""d-none"");
        nextStep(7);
        $(window).scrollTop(0);

    });
   
    
    $(""#ddOstan"").select2({
        dir: ""rtl"",
        ajax: {
            url: '/Home/GetAllOstanName',
            dataType: 'json'
        },
        language: {
            noResults: function () {
                return ""یافت نشد"";
            },
            searching: function () {
                return ""در حال جستجو"";
            }
        }
    });

    $('#ddOstan').on(""select2:select"", function (e) {

        $('#ddShahrestan').val(null).trigger('change');
        $('#ddBakhsh').val(null).trigger('change');
        $('#ddDehestan').val(null).trigger('change');
        $('#ddRoosta').val(null).trigger('change');

        $('#btnShahrestan').prop('disabled', fa");
            WriteLiteral(@"lse);
        $('#btnBakhsh').prop('disabled', true);
        $('#btnDehestan').prop('disabled', true);
        $('#btnRoosta').prop('disabled', true);

        $('#itemBoxScreenShahrestan').removeClass('d-none');
        $('#itemBoxScreenBakhsh').removeClass('d-none');
        $('#itemBoxScreenDehestan').removeClass('d-none');
        $('#itemBoxScreenRoosta').removeClass('d-none');

        var data = e.params.data;
        mymap.setView([data.Lng,data.Lat], 6);
        $('#divAmarcode').html(e.params.data.id);

    });

    $(""#ddShahrestan"").select2({
        dir: ""rtl"",
        ajax: {
            url: function () {
                var amarcode = $('#ddOstan').val();
                return ""/Home/GetAllShahrestanName?amarcode="" + amarcode;
            },
            dataType: 'json'
        },
        language: {
            noResults: function () {
                return ""یافت نشد"";
            },
            searching: function () {
                return ""در حال جستجو"";
");
            WriteLiteral(@"            }
        }
    });

    $('#ddShahrestan').on(""select2:select"", function (e) {

        var data = e.params.data;
        $('#ddBakhsh').val(null).trigger('change');
        $('#ddDehestan').val(null).trigger('change');
        $('#ddRoosta').val(null).trigger('change');

        $('#btnBakhsh').prop('disabled', false);
        $('#btnDehestan').prop('disabled', true);
        $('#btnRoosta').prop('disabled', true);

        $('#itemBoxScreenBakhsh').removeClass('d-none');
        $('#itemBoxScreenDehestan').removeClass('d-none');
        $('#itemBoxScreenRoosta').removeClass('d-none');

        var data = e.params.data;
        mymap.setView([data.Lng,data.Lat],10);
        $('#divAmarcode').html(e.params.data.id);
    });

    $(""#ddBakhsh"").select2({
        dir: ""rtl"",
        ajax: {
            url: function () {
                var amarcode = $('#ddShahrestan').val();
                return '/Home/GetAllBakhshName?amarcode=' + amarcode;
            },
       ");
            WriteLiteral(@"     dataType: 'json'
        },
        language: {
            noResults: function () {
                return ""یافت نشد"";
            },
            searching: function () {
                return ""در حال جستجو"";
            }
        }
    });

    $('#ddBakhsh').on(""select2:select"", function (e) {

        var data = e.params.data;
        $('#ddDehestan').val(null).trigger('change');
        $('#ddRoosta').val(null).trigger('change');

        $('#btnDehestan').prop('disabled', false);
        $('#btnRoosta').prop('disabled', true);

        $('#itemBoxScreenDehestan').removeClass('d-none');
        $('#itemBoxScreenRoosta').removeClass('d-none');

        var data = e.params.data;
        mymap.setView([data.Lng,data.Lat], 11);
        $('#divAmarcode').html(e.params.data.id);

    });

    $(""#ddDehestan"").select2({
        dir: ""rtl"",
        ajax: {
            url: function () {
                var amarcode = $('#ddBakhsh').val();
                return '/Home/Get");
            WriteLiteral(@"AllDehestanName?amarcode=' + amarcode;
            },
            dataType: 'json'
        },
        language: {
            noResults: function () {
                return ""یافت نشد"";
            },
            searching: function () {
                return ""در حال جستجو"";
            }
        }
    });

    $('#ddDehestan').on(""select2:select"", function (e) {

        var data = e.params.data;
        $('#ddRoosta').val(null).trigger('change');

        $('#btnRoosta').prop('disabled', false);

        $('#itemBoxScreenRoosta').removeClass('d-none');


        var data = e.params.data;
        mymap.setView([data.Lng,data.Lat], 12);
        $('#divAmarcode').html(e.params.data.id);

    });

    $(""#ddRoosta"").select2({
        dir: ""rtl"",
        ajax: {
            url: function () {
                var amarcode = $('#ddDehestan').val();
                return '/Home/GetAllAbadiName?amarcode=' + amarcode;
            },
            dataType: 'json'
        },
    ");
            WriteLiteral(@"    language: {
            noResults: function () {
                return ""یافت نشد"";
            },
            searching: function () {
                return ""در حال جستجو"";
            }
        }
    });

    $('#ddRoosta').on(""select2:select"", function (e) {

        var data = e.params.data;
        mymap.setView([data.Lng,data.Lat], 15);
        $('#divAmarcode').html(e.params.data.id);

    });

</script>


</div>

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
