#pragma checksum "D:\.net route\Vedios\Eng Ahmed Nasr\07 ASP.NET Core MVC\Session 02\Demos\All.Solution\Presentation.Layer\Views\Department\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "22da1b07a8d3857bd2e2a25c59324d032bdd6874"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Department_Index), @"mvc.1.0.view", @"/Views/Department/Index.cshtml")]
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
#line 1 "D:\.net route\Vedios\Eng Ahmed Nasr\07 ASP.NET Core MVC\Session 02\Demos\All.Solution\Presentation.Layer\Views\_ViewImports.cshtml"
using Presentation.Layer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\.net route\Vedios\Eng Ahmed Nasr\07 ASP.NET Core MVC\Session 02\Demos\All.Solution\Presentation.Layer\Views\_ViewImports.cshtml"
using Data.Access.Layer.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\.net route\Vedios\Eng Ahmed Nasr\07 ASP.NET Core MVC\Session 02\Demos\All.Solution\Presentation.Layer\Views\_ViewImports.cshtml"
using Presentation.Layer.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\.net route\Vedios\Eng Ahmed Nasr\07 ASP.NET Core MVC\Session 02\Demos\All.Solution\Presentation.Layer\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22da1b07a8d3857bd2e2a25c59324d032bdd6874", @"/Views/Department/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8311963430a9ff03492bbc86ef21d571b24c4c0d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Department_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DepartmentViewModel>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ButtonPartialView", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\.net route\Vedios\Eng Ahmed Nasr\07 ASP.NET Core MVC\Session 02\Demos\All.Solution\Presentation.Layer\Views\Department\Index.cshtml"
  
    ViewData["Title"] = "All Departments";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "D:\.net route\Vedios\Eng Ahmed Nasr\07 ASP.NET Core MVC\Session 02\Demos\All.Solution\Presentation.Layer\Views\Department\Index.cshtml"
 if (TempData["Message"] is not null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div id=\"alertDiv\" class=\"alert alert-danger mt-3\">\r\n        ");
#nullable restore
#line 10 "D:\.net route\Vedios\Eng Ahmed Nasr\07 ASP.NET Core MVC\Session 02\Demos\All.Solution\Presentation.Layer\Views\Department\Index.cshtml"
   Write(TempData["Message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 12 "D:\.net route\Vedios\Eng Ahmed Nasr\07 ASP.NET Core MVC\Session 02\Demos\All.Solution\Presentation.Layer\Views\Department\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>All Departments</h1>\r\n<br />\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "22da1b07a8d3857bd2e2a25c59324d032bdd68746171", async() => {
                WriteLiteral("Create New Department");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 21 "D:\.net route\Vedios\Eng Ahmed Nasr\07 ASP.NET Core MVC\Session 02\Demos\All.Solution\Presentation.Layer\Views\Department\Index.cshtml"
 if (Model.Count() > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table class=\"table table-striped table-hover mt-2\">\r\n        <thead>\r\n            <tr>\r\n");
            WriteLiteral("                <td>");
#nullable restore
#line 27 "D:\.net route\Vedios\Eng Ahmed Nasr\07 ASP.NET Core MVC\Session 02\Demos\All.Solution\Presentation.Layer\Views\Department\Index.cshtml"
               Write(Html.DisplayNameFor(D=>D.Code));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                <td>");
#nullable restore
#line 28 "D:\.net route\Vedios\Eng Ahmed Nasr\07 ASP.NET Core MVC\Session 02\Demos\All.Solution\Presentation.Layer\Views\Department\Index.cshtml"
               Write(Html.DisplayNameFor(D=>D.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>Date Of Creation </td>\r\n                <td>Details </td>\r\n                <td>Update </td>\r\n                <td>Delete </td>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 36 "D:\.net route\Vedios\Eng Ahmed Nasr\07 ASP.NET Core MVC\Session 02\Demos\All.Solution\Presentation.Layer\Views\Department\Index.cshtml"
             foreach (var department in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 39 "D:\.net route\Vedios\Eng Ahmed Nasr\07 ASP.NET Core MVC\Session 02\Demos\All.Solution\Presentation.Layer\Views\Department\Index.cshtml"
                   Write(department.Code);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 40 "D:\.net route\Vedios\Eng Ahmed Nasr\07 ASP.NET Core MVC\Session 02\Demos\All.Solution\Presentation.Layer\Views\Department\Index.cshtml"
                   Write(department.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 41 "D:\.net route\Vedios\Eng Ahmed Nasr\07 ASP.NET Core MVC\Session 02\Demos\All.Solution\Presentation.Layer\Views\Department\Index.cshtml"
                   Write(department.DateOfCreation.ToString("MM/dd/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "22da1b07a8d3857bd2e2a25c59324d032bdd687410068", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 42 "D:\.net route\Vedios\Eng Ahmed Nasr\07 ASP.NET Core MVC\Session 02\Demos\All.Solution\Presentation.Layer\Views\Department\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = department.Id.ToString();

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </tr>\r\n");
#nullable restore
#line 44 "D:\.net route\Vedios\Eng Ahmed Nasr\07 ASP.NET Core MVC\Session 02\Demos\All.Solution\Presentation.Layer\Views\Department\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 47 "D:\.net route\Vedios\Eng Ahmed Nasr\07 ASP.NET Core MVC\Session 02\Demos\All.Solution\Presentation.Layer\Views\Department\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"mt-4 alert alert-warning d-flex justify-content-center\">\r\n\r\n        <h3>There are No Departments!!</h3>\r\n    </div>\r\n");
#nullable restore
#line 54 "D:\.net route\Vedios\Eng Ahmed Nasr\07 ASP.NET Core MVC\Session 02\Demos\All.Solution\Presentation.Layer\Views\Department\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Script", async() => {
                WriteLiteral(@"
    <script>
        // Get the reference to the div element
        const alertDiv = document.getElementById('alertDiv');

        // Function to hide the div
        function hideDiv() {
            alertDiv.style.display = 'none';
        }

        // Hide the div after 5 seconds (5000 milliseconds)
        setTimeout(hideDiv, 3000);
    </script>
");
            }
            );
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DepartmentViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
