#pragma checksum "C:\Users\User\Desktop\7.18期末GitHub(更新版)\Medical\Views\Product\OrderDetailList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2f738bd4d0f7674d3e5d049bf25f941a5924e838"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_OrderDetailList), @"mvc.1.0.view", @"/Views/Product/OrderDetailList.cshtml")]
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
#line 1 "C:\Users\User\Desktop\7.18期末GitHub(更新版)\Medical\Views\_ViewImports.cshtml"
using Medical;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\7.18期末GitHub(更新版)\Medical\Views\_ViewImports.cshtml"
using Medical.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f738bd4d0f7674d3e5d049bf25f941a5924e838", @"/Views/Product/OrderDetailList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24de361111f0b04cb59052ed4f6ecd3219f4a4fd", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_OrderDetailList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Medical.ViewModel.OrderDetailViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\User\Desktop\7.18期末GitHub(更新版)\Medical\Views\Product\OrderDetailList.cshtml"
  
    ViewData["Title"] = "list";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Hero Start -->
<div class=""container-fluid bg-primary py-5 hero-header mb-5"">
    <div class=""row py-3"">
        <div class=""col-12 text-center"">
            <h3 class=""display-3 text-white animated zoomIn"">訂單</h3>
        </div>
    </div>
</div>
<!-- Hero End -->
<hr />

<div class=""card"">
    <div class=""card-body p-0"">
        <div class=""table-responsive"">
            <table class=""table m-0"">
                <thead>
                    <tr>
                        <th><font style=""vertical-align: inherit;""><font style=""vertical-align: inherit;"">產品編號</font></font></th>
                        <th><font style=""vertical-align: inherit;""><font style=""vertical-align: inherit;"">商品名稱</font></font></th>
                        <th><font style=""vertical-align: inherit;""><font style=""vertical-align: inherit;"">商品照片</font></font></th>
                        <th><font style=""vertical-align: inherit;""><font style=""vertical-align: inherit;"">購買日期</font></font></th>
                        <");
            WriteLiteral("th><font style=\"vertical-align: inherit;\"><font style=\"vertical-align: inherit;\">");
#nullable restore
#line 29 "C:\Users\User\Desktop\7.18期末GitHub(更新版)\Medical\Views\Product\OrderDetailList.cshtml"
                                                                                                     Write(Html.DisplayNameFor(model => model.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("</font></font></th>\r\n                        <th><font style=\"vertical-align: inherit;\"><font style=\"vertical-align: inherit;\">購買者</font></font></th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
#nullable restore
#line 34 "C:\Users\User\Desktop\7.18期末GitHub(更新版)\Medical\Views\Product\OrderDetailList.cshtml"
                      
                        int count = 0;
                        foreach (var item in Model)
                        {
                            count++;


#line default
#line hidden
#nullable disable
            WriteLiteral("                           <tr>\r\n                               <td>\r\n                                   ");
#nullable restore
#line 42 "C:\Users\User\Desktop\7.18期末GitHub(更新版)\Medical\Views\Product\OrderDetailList.cshtml"
                              Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                               </td>\r\n                               <td>\r\n                                   ");
#nullable restore
#line 45 "C:\Users\User\Desktop\7.18期末GitHub(更新版)\Medical\Views\Product\OrderDetailList.cshtml"
                              Write(Html.DisplayFor(modelItem => item.Product.ProductName));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                               </td>
                               <td>
                                   這裡是照片
                               </td>
                               <td>
                                   <div class=""sparkbar"" data-color=""#00a65a"" data-height=""20""><font style=""vertical-align: inherit;""><font style=""vertical-align: inherit;""> ");
#nullable restore
#line 51 "C:\Users\User\Desktop\7.18期末GitHub(更新版)\Medical\Views\Product\OrderDetailList.cshtml"
                                                                                                                                                                         Write(Html.DisplayFor(modelItem => item.Order.OrderDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</font></font></div>\r\n                               </td>\r\n                               <td><span class=\"badge badge-primary\"><font style=\"vertical-align: inherit;\"><font style=\"vertical-align: inherit;\">");
#nullable restore
#line 53 "C:\Users\User\Desktop\7.18期末GitHub(更新版)\Medical\Views\Product\OrderDetailList.cshtml"
                                                                                                                                              Write(Html.DisplayFor(modelItem => item.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("-套件未套 反白</font></font></span></td>\r\n                               <td><span class=\"badge badge-primary\"><font style=\"vertical-align: inherit;\"><font style=\"vertical-align: inherit;\">");
#nullable restore
#line 54 "C:\Users\User\Desktop\7.18期末GitHub(更新版)\Medical\Views\Product\OrderDetailList.cshtml"
                                                                                                                                              Write(Html.DisplayFor(modelItem => item.Member.MemberName));

#line default
#line hidden
#nullable disable
            WriteLiteral("-套件未套 反白</font></font></span></td>\r\n                               <td>\r\n                                   ");
#nullable restore
#line 56 "C:\Users\User\Desktop\7.18期末GitHub(更新版)\Medical\Views\Product\OrderDetailList.cshtml"
                              Write(Html.ActionLink("新增評論", "createReview", new { id = item.Product.ProductId }, new { @class = "btn btn-primary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                               </td>\r\n                           </tr>\r\n");
#nullable restore
#line 59 "C:\Users\User\Desktop\7.18期末GitHub(更新版)\Medical\Views\Product\OrderDetailList.cshtml"
                          
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>           \r\n    </div>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2f738bd4d0f7674d3e5d049bf25f941a5924e8389574", async() => {
                WriteLiteral("回到上一頁");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</div>
<!-- Modal -->
<!--<div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">新增產品評論</h5>
                <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
            </div>
            <div class=""modal-body"">
                <form>
                    <div class=""mb-3"">
                        <label for=""recipient-name"" class=""col-form-label"">分數</label>
                        <input type=""text"" class=""form-control"" id=""recipient-name"">
                    </div>
                    <div class=""mb-3"">
                        <label for=""message-text"" class=""col-form-label"">評論</label>
                        <textarea class=""form-control"" id=""message-text""></textarea>
                    </div>
                </form>");
            WriteLiteral(@"
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-bs-dismiss=""modal"">Close</button>
                <button type=""button"" class=""btn btn-primary"">Send message</button>
            </div>
        </div>
    </div>
</div>-->

");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        var exampleModal = document.getElementById('exampleModal')
        exampleModal.addEventListener('show.bs.modal', function (event) {
            // Button that triggered the modal
            var button = event.relatedTarget
            // Extract info from data-bs-* attributes
            var recipient = button.getAttribute('data-bs-whatever')
            // If necessary, you could initiate an AJAX request here
            // and then do the updating in a callback.
            //
            // Update the modal's content.
            var modalTitle = exampleModal.querySelector('.modal-title')
            var modalBodyInput = exampleModal.querySelector('.modal-body input')

            modalTitle.textContent = 'New message to ' + recipient
            modalBodyInput.value = recipient
        })

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Medical.ViewModel.OrderDetailViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
