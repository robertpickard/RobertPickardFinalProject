#pragma checksum "S:\My Stuff\School\CS 4790\ISfTE\ISfTE\ISfTE\Pages\Admin\Registration\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4dbd10149b274df403078c3c8a268239a76bcf96"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ISfTE.Pages.Admin.Registration.Pages_Admin_Registration_Index), @"mvc.1.0.razor-page", @"/Pages/Admin/Registration/Index.cshtml")]
namespace ISfTE.Pages.Admin.Registration
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
#line 1 "S:\My Stuff\School\CS 4790\ISfTE\ISfTE\ISfTE\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "S:\My Stuff\School\CS 4790\ISfTE\ISfTE\ISfTE\Pages\_ViewImports.cshtml"
using ISfTE;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "S:\My Stuff\School\CS 4790\ISfTE\ISfTE\ISfTE\Pages\_ViewImports.cshtml"
using ISfTE.DataAccess;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "S:\My Stuff\School\CS 4790\ISfTE\ISfTE\ISfTE\Pages\Admin\Registration\Index.cshtml"
using ISfTE.Utility;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4dbd10149b274df403078c3c8a268239a76bcf96", @"/Pages/Admin/Registration/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8947fe2694c5860c13a457a785fce9c76d86c9b", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_Registration_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/registration.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 5 "S:\My Stuff\School\CS 4790\ISfTE\ISfTE\ISfTE\Pages\Admin\Registration\Index.cshtml"
  
    ViewData["Title"] = "Registration Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 9 "S:\My Stuff\School\CS 4790\ISfTE\ISfTE\ISfTE\Pages\Admin\Registration\Index.cshtml"
 if (User.IsInRole(SD.AdminRole))
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""border backgroundWhite container"">
        <div class=""row"">
            <div class=""col-6"">
                <h2 class=""text-info"">Registrations</h2>
            </div>
        </div>
        <br />
        <br />
        <table id=""DT_load"" class=""table table-striped table-bordered"" style=""width:100%"">
            <thead>
                <tr>
                    <th>Id</th>
                    <th>Name</th>
                    <th>Email</th>
                    <th>Phone Number</th>
                    <th>Total Cost</th>
                    <th></th>
                </tr>
            </thead>
        </table>
    </div>
");
#nullable restore
#line 32 "S:\My Stuff\School\CS 4790\ISfTE\ISfTE\ISfTE\Pages\Admin\Registration\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1 class=\"text-danger\">Access Denied</h1>\r\n");
#nullable restore
#line 36 "S:\My Stuff\School\CS 4790\ISfTE\ISfTE\ISfTE\Pages\Admin\Registration\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4dbd10149b274df403078c3c8a268239a76bcf965615", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ISfTE.Pages.Admin.Registration.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ISfTE.Pages.Admin.Registration.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ISfTE.Pages.Admin.Registration.IndexModel>)PageContext?.ViewData;
        public ISfTE.Pages.Admin.Registration.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
