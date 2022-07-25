#pragma checksum "C:\Medical0725\Medical\Areas\Admin\Views\AdminDoctor\depEdit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "63e744f8f0f2dd83869ddd8ee3c101b51c5825f1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AdminDoctor_depEdit), @"mvc.1.0.view", @"/Areas/Admin/Views/AdminDoctor/depEdit.cshtml")]
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
#line 1 "C:\Medical0725\Medical\Areas\_ViewImports.cshtml"
using Medical;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Medical0725\Medical\Areas\_ViewImports.cshtml"
using Medical.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63e744f8f0f2dd83869ddd8ee3c101b51c5825f1", @"/Areas/Admin/Views/AdminDoctor/depEdit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24de361111f0b04cb59052ed4f6ecd3219f4a4fd", @"/Areas/_ViewImports.cshtml")]
    public class Areas_Admin_Views_AdminDoctor_depEdit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Medical0725\Medical\Areas\Admin\Views\AdminDoctor\depEdit.cshtml"
  
    ViewData["Title"] = "depEdit";
    Layout = "~/Areas/Admin/Admin_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("-->\r\n");
            WriteLiteral(@"<!--<h1>depEdit</h1>

<h4>CDoctorDetailViewModel</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""depEdit"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <select id=""select1"">選擇科別</select>
            <div class=""form-group"">
                <label asp-for=""DeptCategoryName"" class=""control-label""></label>
                <input asp-for=""DeptCategoryName"" class=""form-control"" id=""dpc"" />
                <span asp-validation-for=""DeptCategoryName"" class=""text-danger""></span>
            </div>
            <select id=""select2"">選擇專長</select>
            <div class=""form-group"">
                <label asp-for=""DepName"" class=""control-label""></label>
                <input asp-for=""DepName"" class=""form-control"" id=""dpn"" />
                <span asp-validation-for=""DepName"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Create"" class=""btn");
            WriteLiteral(" btn-primary\" />\r\n            </div>\r\n            <div>");
#nullable restore
#line 31 "C:\Medical0725\Medical\Areas\Admin\Views\AdminDoctor\depEdit.cshtml"
            Write(Html.ActionLink("刪除科別", "depDelete", new { deps = Model }, new { @class = "btn btn-primary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            <div>");
#nullable restore
#line 32 "C:\Medical0725\Medical\Areas\Admin\Views\AdminDoctor\depEdit.cshtml"
            Write(Html.ActionLink("刪除專長", "depDelete", new { deps = Model }, new { @class = "btn btn-primary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        </form>\r\n    </div>\r\n</div>\r\n\r\n<div>\r\n    <a asp-action=\"Index\">Back to List</a>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 42 "C:\Medical0725\Medical\Areas\Admin\Views\AdminDoctor\depEdit.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
                WriteLiteral(@"    <script>
    const selDepC = document.querySelector(""#select1"");
    const selDep = document.querySelector(""#select2"");
    const txtDpc = document.querySelector(""#dpc"");
    const txtDpn = document.querySelector(""#dpn"");
    selDepC.addEventListener(""change"", () =>
    {
        txtDpc.value = selDepC.value;
        getDep();
    })
    getDepC();
    selDep.addEventListener(""change"", () => {
        txtDpn.value = selDep.value;
    })
    async function getDepC()
    {
        $(""#select1"").empty();
        const depCs = await fetch('");
#nullable restore
#line 60 "C:\Medical0725\Medical\Areas\Admin\Views\AdminDoctor\depEdit.cshtml"
                              Write(Url.Content("~/Doctor/getDepC"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"').then(response => response.json());
        depCs.forEach((DeptCategoryName) =>
        {
            const opt = new Option(DeptCategoryName, DeptCategoryName);

            selDepC.options.add(opt);

        })
        const str = new Option(""新增科別"", ""depC"");
        selDepC.options.add(str);
        getDep();
    }
    async function getDep()
    {
        depStr =  selDepC.options[selDepC.selectedIndex].value;
        $(""#select2"").empty();
        const deps = await fetch('");
#nullable restore
#line 76 "C:\Medical0725\Medical\Areas\Admin\Views\AdminDoctor\depEdit.cshtml"
                             Write(Url.Content("~/Doctor/getDep"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"'+`?depCName=${depStr}`).then(response => response.json());
        console.log(deps);
        deps.forEach((DeptName) => {
            const opt = new Option(DeptName, DeptName);

            selDep.options.add(opt);

        })
        const str = new Option(""新增專長"", ""dep"");
        selDep.options.add(str);
    }
    </script>
");
            }
            );
            WriteLiteral("-->\r\n");
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
