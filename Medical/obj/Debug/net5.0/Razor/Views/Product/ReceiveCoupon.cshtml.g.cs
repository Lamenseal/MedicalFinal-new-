#pragma checksum "C:\Users\User\source\repos\MedicalFinal-new-\Medical\Views\Product\ReceiveCoupon.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae50709cca5e3774001bfbf94c6989a544f21868"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_ReceiveCoupon), @"mvc.1.0.view", @"/Views/Product/ReceiveCoupon.cshtml")]
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
#line 1 "C:\Users\User\source\repos\MedicalFinal-new-\Medical\Views\_ViewImports.cshtml"
using Medical;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\source\repos\MedicalFinal-new-\Medical\Views\_ViewImports.cshtml"
using Medical.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae50709cca5e3774001bfbf94c6989a544f21868", @"/Views/Product/ReceiveCoupon.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24de361111f0b04cb59052ed4f6ecd3219f4a4fd", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_ReceiveCoupon : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Medical.ViewModel.CGetCouponViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/Product/ReceiveCoupon"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin:0;padding:0;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("myform"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\User\source\repos\MedicalFinal-new-\Medical\Views\Product\ReceiveCoupon.cshtml"
  
    ViewData["Title"] = "ReceiveCoupon2";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""mt-5"" style="" width: 100%;min-height:60em; background-color: rgb(236, 236, 236)"">

    <div class=""container-fluid bg-primary py-5 hero-header mb-5"">
        <div class=""row py-3"">
            <div class=""col-12 text-center"">
                <h3 class=""display-3 text-white animated zoomIn"">折價券專區</h3>
            </div>
        </div>
    </div>

    <div class=""container mt-2"" style=""padding:1em;"">
        <div class=""row"" style=""padding-left:3em;"">
            <div class=""col col-md-5"">
                <div style=""width: 100%; height: 26em;background-image: url('../images/購物廣告.jpg'); background-size: 100% 100%; ""></div>
                <div class=""mt-5"" style=""width: 100%; height: 12em; background-image: url('../images/廣告2.jpg'); background-size: 100% 100%; ""></div>



            </div>
            <div class=""col col-md-7"" style=""padding-left:5em"">

");
#nullable restore
#line 28 "C:\Users\User\source\repos\MedicalFinal-new-\Medical\Views\Product\ReceiveCoupon.cshtml"
                   string yesorno = "立即 領取";
                    string btnYesNo = "";
                    foreach (var item in Model)
                    {
                        if (item.couponDetail != null)
                        {
                            btnYesNo = "btnTaken";

                            yesorno = "您已 領取";
                        }
                        else
                        {
                            yesorno = "立即 領取";
                            btnYesNo = "btnNotTaken";
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <!-- ======================  折價券模型 Start ========================-->\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ae50709cca5e3774001bfbf94c6989a544f218686878", async() => {
                WriteLiteral(@"
                            <div class=""row"" style=""width: 95%; height: 12em; margin-bottom: 2em; max-height: 30%; background-image: url('../images/pngtree-simple-blue-business-coupon-background-image_229938.jpg'); background-size: 100% 100%; "">
                                <div class=""col col-md-9 row"" style=""margin: auto;height: 100%;border-right: 1px dashed black;"">
                                    <div class=""row"" style=""height: 90%;width:100%;border: 2px solid rgb(210, 210, 210);margin: auto;"">
                                        <div class=""col col-md-4"" style=""height: 100%;margin: auto; text-align: center;display: flex;justify-content: center;"">
                                            <p style=""margin: auto;height: 80%;width:100%;vertical-align: middle;color: black;""><span style=""font-size: 5em;color: black;"">");
#nullable restore
#line 49 "C:\Users\User\source\repos\MedicalFinal-new-\Medical\Views\Product\ReceiveCoupon.cshtml"
                                                                                                                                                                      Write(item.CouponDiscountNum);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</span>$</p>
                                        </div>
                                        <div class=""col col-md-8"" style=""height: 100%;text-align: center;display: flex;justify-content: center;"">
                                            <p style=""margin: auto;height: 60%;width:100%;vertical-align: middle;font-size: 2em;"">消費滿<span style=""color: goldenrod;font-size: 36px;"">");
#nullable restore
#line 52 "C:\Users\User\source\repos\MedicalFinal-new-\Medical\Views\Product\ReceiveCoupon.cshtml"
                                                                                                                                                                                Write(item.CouponRequireNum);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>元可用折價券</p>\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n                                <input type=\"hidden\" name=\"MemberId\"");
                BeginWriteAttribute("value", " value=\"", 3284, "\"", 3303, 1);
#nullable restore
#line 56 "C:\Users\User\source\repos\MedicalFinal-new-\Medical\Views\Product\ReceiveCoupon.cshtml"
WriteAttributeValue("", 3292, item.MemId, 3292, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                <input type=\"hidden\" name=\"CouponId\"");
                BeginWriteAttribute("value", " value=\"", 3377, "\"", 3406, 1);
#nullable restore
#line 57 "C:\Users\User\source\repos\MedicalFinal-new-\Medical\Views\Product\ReceiveCoupon.cshtml"
WriteAttributeValue("", 3385, item.coupon.CouponId, 3385, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                                <input type=""hidden"" name=""CouponUsed"" value=""False"" />
                                <div class=""col col-md-3 row"" style=""margin: auto;height: 100%;"">

                                    <div style=""height: 90%;width:100%;border: 2px dashed rgb(210, 210, 210);margin: auto; text-align: center;display: flex;justify-content: center;"">
                                        <p style=""margin: auto;height: 60%;width:100%; min-width:100%;vertical-align: middle;color: white;font-size: 28px;""><button type=""button"" style=""color: goldenrod; font-size: 30px; border: 0;""");
                BeginWriteAttribute("class", " class=\"", 4017, "\"", 4055, 3);
                WriteAttributeValue("", 4025, "btn", 4025, 3, true);
                WriteAttributeValue(" ", 4028, "btn-outline-dark", 4029, 17, true);
#nullable restore
#line 62 "C:\Users\User\source\repos\MedicalFinal-new-\Medical\Views\Product\ReceiveCoupon.cshtml"
WriteAttributeValue(" ", 4045, btnYesNo, 4046, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 62 "C:\Users\User\source\repos\MedicalFinal-new-\Medical\Views\Product\ReceiveCoupon.cshtml"
                                                                                                                                                                                                                                                                          Write(yesorno);

#line default
#line hidden
#nullable disable
                WriteLiteral("</button></p>\r\n                                    </div>\r\n\r\n                                </div>\r\n\r\n                            </div>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        <!-- ======================  折價券模型 End ========================-->\r\n");
#nullable restore
#line 70 "C:\Users\User\source\repos\MedicalFinal-new-\Medical\Views\Product\ReceiveCoupon.cshtml"
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script src=""//cdn.jsdelivr.net/npm/sweetalert2@11""></script>

    <script>

        $("".btnTaken"").attr(""disabled"", ""disabled"");
        $("".btnTaken"").css(""color"", ""#E0E0E0"");

       


        $('.btnNotTaken').on(""click"", function () {

            let myform = $(event.target).parents(""form"");



            let timerInterval
            Swal.fire({
                icon: 'success',
                title: '成功',
                html: '已將此優惠券加入您的帳號',
                timer: 1000,
                timerProgressBar: true,
                didOpen: () => {
                    Swal.showLoading()
                    const b = Swal.getHtmlContainer().querySelector('b')
                    timerInterval = setInterval(() => {
                        b.textContent = Swal.getTimerLeft()
                    }, 100)
                },
                willClose: () => {
                    clearInterval(timerInterval)
                }
            }).then((result) => {
              ");
                WriteLiteral(@"  /* Read more about handling dismissals below */
                if (result.dismiss === Swal.DismissReason.timer) {
                    console.log('I was closed by the timer')
                }
            })

            setTimeout(function () { myform.submit(); }, 1000);
        })

        $.ajax({


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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Medical.ViewModel.CGetCouponViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
