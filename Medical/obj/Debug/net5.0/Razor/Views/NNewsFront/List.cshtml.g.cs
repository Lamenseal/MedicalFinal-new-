#pragma checksum "C:\Users\USER\Source\Repos\MedicalFinal-new-\Medical\Views\NNewsFront\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "36e87f4affb64afcb1f649c89483889c13dbcd25"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_NNewsFront_List), @"mvc.1.0.view", @"/Views/NNewsFront/List.cshtml")]
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
#line 1 "C:\Users\USER\Source\Repos\MedicalFinal-new-\Medical\Views\_ViewImports.cshtml"
using Medical;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\USER\Source\Repos\MedicalFinal-new-\Medical\Views\_ViewImports.cshtml"
using Medical.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36e87f4affb64afcb1f649c89483889c13dbcd25", @"/Views/NNewsFront/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24de361111f0b04cb59052ed4f6ecd3219f4a4fd", @"/Views/_ViewImports.cshtml")]
    public class Views_NNewsFront_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Medical.ViewModel.NNewsViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("..."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\USER\Source\Repos\MedicalFinal-new-\Medical\Views\NNewsFront\List.cshtml"
  
    ViewData["Title"] = "List";

#line default
#line hidden
#nullable disable
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
            WriteLiteral("<div class=\"container-fluid\">\r\n    <div class=\"row\">\r\n        <div class=\"col-3 mb-4\">\r\n            <div class=\" \">\r\n");
            WriteLiteral("                <div class=\"input-group\" style=\"display:block; text-align:left;margin-block:30px\">\r\n                    ");
#nullable restore
#line 24 "C:\Users\USER\Source\Repos\MedicalFinal-new-\Medical\Views\NNewsFront\List.cshtml"
               Write(Html.TextBox("txtKeyword", "", new { @class = "font-weight-bold", style = "font-size:20px;border-radius:15px;", @placeholder = "search..." }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <button type=\"submit\" class=\"btn btn-lg btn-default \">\r\n                        <i class=\"fa fa-search\">查詢</i>\r\n                    </button>\r\n                </div>\r\n\r\n");
            WriteLiteral("                <div style=\"margin-block:20px\">\r\n                    <a>\r\n                        <i");
            BeginWriteAttribute("class", " class=\"", 1187, "\"", 1195, 0);
            EndWriteAttribute();
            WriteLiteral(" style=\"font-size: 20px; font-weight: bold;text-align:left\">熱搜關鍵字 : </i>\r\n                    </a>\r\n                </div>\r\n");
            WriteLiteral(@"                <div style=""margin:10px"">
                    <button class=""col-3 btn btn-outline-primary"" style=""border-radius:15px"">1</button>
                    <button class=""col-3 btn btn-outline-primary"" style=""border-radius:15px"">1</button>
                    <button class=""col-3 btn btn-outline-primary"" style=""border-radius:15px"">1</button>
                </div>
                <div style=""margin:10px"">
                    <button class=""col-3 btn btn-outline-primary"" style=""border-radius:15px"">1</button>
                    <button class=""col-3 btn btn-outline-primary"" style=""border-radius:15px"">1</button>
                    <button class=""col-3 btn btn-outline-primary"" style=""border-radius:15px"">1</button>
                </div>

");
            WriteLiteral("                <div style=\"margin-block:20px\">\r\n                    <a>\r\n                        <i");
            BeginWriteAttribute("class", " class=\"", 2295, "\"", 2303, 0);
            EndWriteAttribute();
            WriteLiteral(@" style=""font-size: 20px; font-weight: bold;text-align:left"">另類搜尋 : </i>
                    </a>
                </div>

                <div class=""card-input"" style=""margin-left:10px;margin-block:10px"">
                    <input type=""button"" href=""......"" class=""btn btn-outline-primary"" value=""名人分享"" style=""border-radius:15px;font-size:24px;font-weight:bold"" />
                </div>
                <div class=""card-input"" style=""margin-left:10px;margin-block:10px"">
                    <input type=""button"" href=""......"" class=""btn btn-outline-primary"" value=""新聞報導"" style=""border-radius:15px;font-size:24px;font-weight:bold"" />
                </div>
            </div>
        </div>
");
            WriteLiteral("        <div class=\"col-9\">\r\n            <div class=\"container-fluid\">\r\n                <div class=\"row\">\r\n\r\n");
#nullable restore
#line 70 "C:\Users\USER\Source\Repos\MedicalFinal-new-\Medical\Views\NNewsFront\List.cshtml"
                     foreach (var item in Model)
                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-4 mb-4\">\r\n                            <div class=\"card h-100\">\r\n");
            WriteLiteral("                                <div>\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "36e87f4affb64afcb1f649c89483889c13dbcd258144", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3567, "~/uploads/", 3567, 10, true);
#nullable restore
#line 77 "C:\Users\USER\Source\Repos\MedicalFinal-new-\Medical\Views\NNewsFront\List.cshtml"
AddHtmlAttributeValue("", 3577, item.NewsPicturePath, 3577, 21, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </div>\r\n                                <div class=\"card-body\">\r\n");
            WriteLiteral("                                    <a>\r\n                                        <i class=\"card-title\" style=\"font-size: 30px; font-weight: bold;\">");
#nullable restore
#line 82 "C:\Users\USER\Source\Repos\MedicalFinal-new-\Medical\Views\NNewsFront\List.cshtml"
                                                                                                     Write(item.NewsTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</i>\r\n                                    </a>\r\n");
            WriteLiteral("                                    <a style=\"float: right; text-align: right;\">\r\n                                        <i class=\"fa fa-calendar\">");
#nullable restore
#line 86 "C:\Users\USER\Source\Repos\MedicalFinal-new-\Medical\Views\NNewsFront\List.cshtml"
                                                             Write(item.CreateDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</i>\r\n                                    </a>\r\n");
            WriteLiteral("                                </div>\r\n");
            WriteLiteral(@"                                <div class=""card-input"" style=""margin-left:10px;margin-block:10px"">
                                    <input type=""button"" href=""......"" class=""btn btn-outline-primary"" value=""Read more..."" />
                                </div>
                            </div>
                        </div>
");
#nullable restore
#line 97 "C:\Users\USER\Source\Repos\MedicalFinal-new-\Medical\Views\NNewsFront\List.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n\r\n            <th>\r\n                ");
#nullable restore
#line 113 "C:\Users\USER\Source\Repos\MedicalFinal-new-\Medical\Views\NNewsFront\List.cshtml"
           Write(Html.DisplayNameFor(model => model.NewsCategory.NewsCategoryName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 116 "C:\Users\USER\Source\Repos\MedicalFinal-new-\Medical\Views\NNewsFront\List.cshtml"
           Write(Html.DisplayNameFor(model => model.NewsTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 119 "C:\Users\USER\Source\Repos\MedicalFinal-new-\Medical\Views\NNewsFront\List.cshtml"
           Write(Html.DisplayNameFor(model => model.NewsContent));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 122 "C:\Users\USER\Source\Repos\MedicalFinal-new-\Medical\Views\NNewsFront\List.cshtml"
           Write(Html.DisplayNameFor(model => model.NewsPicturePath));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 125 "C:\Users\USER\Source\Repos\MedicalFinal-new-\Medical\Views\NNewsFront\List.cshtml"
           Write(Html.DisplayNameFor(model => model.CreateDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 131 "C:\Users\USER\Source\Repos\MedicalFinal-new-\Medical\Views\NNewsFront\List.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n\r\n                <td>\r\n                    ");
#nullable restore
#line 136 "C:\Users\USER\Source\Repos\MedicalFinal-new-\Medical\Views\NNewsFront\List.cshtml"
               Write(Html.DisplayFor(modelItem => item.NewsCategory.NewsCategoryName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 139 "C:\Users\USER\Source\Repos\MedicalFinal-new-\Medical\Views\NNewsFront\List.cshtml"
               Write(Html.DisplayFor(modelItem => item.NewsTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 142 "C:\Users\USER\Source\Repos\MedicalFinal-new-\Medical\Views\NNewsFront\List.cshtml"
               Write(Html.DisplayFor(modelItem => item.NewsContent));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 145 "C:\Users\USER\Source\Repos\MedicalFinal-new-\Medical\Views\NNewsFront\List.cshtml"
               Write(Html.DisplayFor(modelItem => item.NewsPicturePath));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 148 "C:\Users\USER\Source\Repos\MedicalFinal-new-\Medical\Views\NNewsFront\List.cshtml"
               Write(Html.DisplayFor(modelItem => item.CreateDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 151 "C:\Users\USER\Source\Repos\MedicalFinal-new-\Medical\Views\NNewsFront\List.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Medical.ViewModel.NNewsViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
