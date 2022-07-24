#pragma checksum "D:\Medical0724\Medical\Views\ArticleFront\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0531605f3f567f5eeb896b7b4eb4690120d3c99f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ArticleFront_List), @"mvc.1.0.view", @"/Views/ArticleFront/List.cshtml")]
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
#line 1 "D:\Medical0724\Medical\Views\_ViewImports.cshtml"
using Medical;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Medical0724\Medical\Views\_ViewImports.cshtml"
using Medical.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0531605f3f567f5eeb896b7b4eb4690120d3c99f", @"/Views/ArticleFront/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24de361111f0b04cb59052ed4f6ecd3219f4a4fd", @"/Views/_ViewImports.cshtml")]
    public class Views_ArticleFront_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Medical.ViewModel.AArticleViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/carousel-1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("..."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Medical0724\Medical\Views\ArticleFront\List.cshtml"
  
    ViewData["Title"] = "List";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            DefineSection("css", async() => {
                WriteLiteral(" \r\n\r\n\r\n");
            }
            );
            WriteLiteral(@"

<!-- Hero Start -->
<div class=""container-fluid bg-primary py-5 hero-header mb-5"">
    <div class=""row py-3"">
        <div class=""col-12 text-center"">
            <h3 class=""display-3 text-white animated zoomIn"">衛教文章</h3>
        </div>
    </div>
</div>
<!-- Hero End -->


");
            WriteLiteral("<div class=\"input-group\" style=\"display:block; text-align:center;margin-block:50px\">\r\n    ");
#nullable restore
#line 28 "D:\Medical0724\Medical\Views\ArticleFront\List.cshtml"
Write(Html.TextBox("txtKeyword", "", new { @class = "font-weight-bold", style = "font-size:26px;border-radius:15px;", @placeholder = "search..." }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <button type=\"submit\" class=\"btn btn-lg btn-default\">\r\n        <i class=\"fa fa-search\">查詢</i>\r\n    </button>\r\n</div>\r\n\r\n");
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"col-md-3\">\r\n");
            WriteLiteral(@"        <div class=""card card-primary"" id=""change_card"">
            <div class=""card-header"">
                <a class=""card-title"">Expandable</a>
                <div class=""card-tools"" style=""float:right;text-align:right"">
                    <button type=""button"" class=""btn btn-tool"" data-card-widget=""collapse"" id=""button1"">
");
            WriteLiteral("                        <i class=\"fas fa-minus\" id=\"change_pm\" ></i>\r\n                    </button>\r\n                </div>\r\n            </div>\r\n");
            WriteLiteral("            <div class=\"card-body\" style=\"display: block;\" id=\"change_underBar\">\r\n                The body of the card\r\n            </div>\r\n        </div>\r\n    </div>\r\n  </div>\r\n\r\n");
            WriteLiteral("\r\n<div class=\"row row-cols-1 row-cols-md-3\">\r\n    <div class=\"col mb-4\">\r\n        <div class=\"card h-100\">\r\n");
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0531605f3f567f5eeb896b7b4eb4690120d3c99f6505", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            <div class=\"card-body\">\r\n");
            WriteLiteral("                <a>\r\n                    <i class=\"card-title\" style=\"font-size: 30px; font-weight: bold;\">Card title</i>\r\n                </a>\r\n");
            WriteLiteral("                <a style=\"float: right; text-align: right;\">\r\n                    <i class=\"fa fa-calendar\">2022/07/12 </i>\r\n                </a>\r\n");
            WriteLiteral("                <p class=\"card-text\">This is a longer card with supporting text below as a natural lead-in to additional content. This content is a little bit longer.</p>\r\n            </div>\r\n");
            WriteLiteral(@"            <div class=""card-input"" style=""margin-left:10px;margin-block:10px"">
                <input type=""button"" href=""......"" class=""btn btn-outline-primary"" value=""Read more..."" />
            </div>
        </div>
    </div>

    <div class=""col mb-4"">
        <div class=""card h-100"">
");
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0531605f3f567f5eeb896b7b4eb4690120d3c99f8738", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            <div class=\"card-body\">\r\n");
            WriteLiteral("                <a>\r\n                    <i class=\"card-title\" style=\"font-size: 30px; font-weight: bold;\">Card title</i>\r\n                </a>\r\n");
            WriteLiteral("                <a style=\"float: right; text-align: right;\">\r\n                    <i class=\"fa fa-calendar\">2022/07/12 </i>\r\n                </a>\r\n");
            WriteLiteral("                <p class=\"card-text\">This is a longer card with supporting text below as a natural lead-in to additional content. This content is a little bit longer.</p>\r\n            </div>\r\n");
            WriteLiteral(@"            <div class=""card-input"" style=""margin-left:10px;margin-block:10px"">
                <input type=""button"" href=""......"" class=""btn btn-outline-primary"" value=""Read more..."" />
            </div>
        </div>
    </div>
    <div class=""col mb-4"">
        <div class=""card h-100"">
");
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0531605f3f567f5eeb896b7b4eb4690120d3c99f10969", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            <div class=\"card-body\">\r\n");
            WriteLiteral("                <a>\r\n                    <i class=\"card-title\" style=\"font-size: 30px; font-weight: bold;\">Card title</i>\r\n                </a>\r\n");
            WriteLiteral("                <a style=\"float: right; text-align: right;\">\r\n                    <i class=\"fa fa-calendar\">2022/07/12 </i>\r\n                </a>\r\n");
            WriteLiteral("                <p class=\"card-text\">This is a longer card with supporting text below as a natural lead-in to additional content. This content is a little bit longer.</p>\r\n            </div>\r\n");
            WriteLiteral("            <div class=\"card-input\" style=\"margin-left:10px;margin-block:10px\">\r\n                <input type=\"button\" href=\"......\" class=\"btn btn-outline-primary\" value=\"Read more...\" />\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n");
#nullable restore
#line 131 "D:\Medical0724\Medical\Views\ArticleFront\List.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <label class=\"btn btn-block btn-outline-secondary btn-lg\" style=\"font-size:20px\">關鍵字 : </label>\r\n");
#nullable restore
#line 134 "D:\Medical0724\Medical\Views\ArticleFront\List.cshtml"
Write(Html.TextBox("txtKeyword", "", new { @class = "font-weight-bold", style = "font-size:25px;border-radius:15px" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <button type=\"submit\" class=\"btn btn-block btn-secondary btn-lg\">查詢</button>\r\n");
#nullable restore
#line 136 "D:\Medical0724\Medical\Views\ArticleFront\List.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 137 "D:\Medical0724\Medical\Views\ArticleFront\List.cshtml"
  
    int count = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""card"">
        <div class=""card-header"">
            <h3 class=""card-title"">篇名</h3>
        </div>

        <div class=""card-body"">
            <div id=""example2_wrapper"" class=""dataTables_wrapper dt-bootstrap4"">
                <div class=""row""><div class=""col-sm-12 col-md-6""></div><div class=""col-sm-12 col-md-6""></div></div><div class=""row"">
                    <div class=""col-sm-12"">
                        <table id=""example2"" class=""table table-bordered table-hover dataTable dtr-inline"" aria-describedby=""example2_info"">
                            <thead>
                                <tr>
                                    <th class=""sorting sorting_asc"" tabindex=""0"" aria-controls=""example2"" rowspan=""1"" colspan=""1"" aria-sort=""ascending"" aria-label=""Rendering engine: activate to sort column descending"">序</th>
                                    <th class=""sorting"" tabindex=""0"" aria-controls=""example2"" rowspan=""1"" colspan=""1"" aria-label=""Browser: activate to sort column asc");
            WriteLiteral(@"ending"">發佈日期</th>
                                    <th class=""sorting"" tabindex=""0"" aria-controls=""example2"" rowspan=""1"" colspan=""1"" aria-label=""Platform(s): activate to sort column ascending"">醫生</th>
                                    <th class=""sorting"" tabindex=""0"" aria-controls=""example2"" rowspan=""1"" colspan=""1"" aria-label=""Engine version: activate to sort column ascending"">疾病</th>
                                    <th class=""sorting"" tabindex=""0"" aria-controls=""example2"" rowspan=""1"" colspan=""1"" aria-label=""CSS grade: activate to sort column ascending"">文章內容</th>
                            </thead>
                            <tbody>

");
#nullable restore
#line 159 "D:\Medical0724\Medical\Views\ArticleFront\List.cshtml"
                                 foreach (var item in Model)
                                {
                                    count++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr class=\"odd\">\r\n                                        <td class=\"dtr-control sorting_1 font-weight-bold\" tabindex=\"0\" style=\"width:5%\">");
#nullable restore
#line 163 "D:\Medical0724\Medical\Views\ArticleFront\List.cshtml"
                                                                                                                    Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td style=\"width:10%\" class=\"font-weight-bold\">");
#nullable restore
#line 164 "D:\Medical0724\Medical\Views\ArticleFront\List.cshtml"
                                                                                  Write(Html.DisplayFor(modelItem => item.CreateDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td style=\"width:10%\" class=\"font-weight-bold\">");
#nullable restore
#line 165 "D:\Medical0724\Medical\Views\ArticleFront\List.cshtml"
                                                                                  Write(Html.DisplayFor(modelItem => item.Doctor.DoctorName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td style=\"width:15%\" class=\"font-weight-bold\">");
#nullable restore
#line 166 "D:\Medical0724\Medical\Views\ArticleFront\List.cshtml"
                                                                                  Write(Html.DisplayFor(modelItem => item.Articeltitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td style=\"width:50%\" class=\"font-weight-bold\">");
#nullable restore
#line 167 "D:\Medical0724\Medical\Views\ArticleFront\List.cshtml"
                                                                                  Write(Html.DisplayFor(modelItem => item.ArticleContent));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    </tr>\r\n");
#nullable restore
#line 169 "D:\Medical0724\Medical\Views\ArticleFront\List.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </tbody>\r\n\r\n                        </table>\r\n                    </div>\r\n                </div>\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@" 
    <script>

        var flag = false;
        let change_card = document.querySelector(""#change_card"");
        let change_pm = document.querySelector(""#change_pm"");
        let change_underBar = document.querySelector(""#change_underBar"")

        let button1 = document.querySelector(""#button1"");
        button1.addEventListener(""click"", change);

        function change() {
            if (flag) {
                change_card.setAttribute(""class"", ""card card-primary collapsed-card"")
                change_pm.setAttribute(""class"", ""fas fa-plus"")
                change_underBar.setAttribute(""style"", ""display: none;"")

                flag = !flag;
            }
            else {
                change_card.setAttribute(""class"", ""card card-primary"")
                change_pm.setAttribute(""class"", ""fas fa-minus"")
                change_underBar.setAttribute(""style"", ""display: block;"")
                flag = !flag;
            }
        }



    </script>

");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Medical.ViewModel.AArticleViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
