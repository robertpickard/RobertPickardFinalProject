#pragma checksum "S:\My Stuff\School\CS 4790\ISfTE\ISfTE\ISfTE\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b0209518e7dbb8afc8dadcf98026fdb3530b0ebd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ISfTE.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace ISfTE.Pages
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
#line 3 "S:\My Stuff\School\CS 4790\ISfTE\ISfTE\ISfTE\Pages\Index.cshtml"
using ISfTE.Utility;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0209518e7dbb8afc8dadcf98026fdb3530b0ebd", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8947fe2694c5860c13a457a785fce9c76d86c9b", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "AbstractUpload/Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("linkUpload"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("text-decoration: none;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("linkApproved"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Registration/Upsert", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("linkRegistered"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 4 "S:\My Stuff\School\CS 4790\ISfTE\ISfTE\ISfTE\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 8 "S:\My Stuff\School\CS 4790\ISfTE\ISfTE\ISfTE\Pages\Index.cshtml"
 if (User.IsInRole(SD.AttendeeRole))
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""row justify-content-around"">
        <div class=""col-1"">
            <div class=""row justify-content-center"">
                <h6 class=""text-secondary""><i>Signed Up</i></h6>
            </div>
            <div class=""row justify-content-center"">
                <i class=""fas fa-check"" id=""signedUpIcon""></i>
            </div>
        </div>
        <div class=""col-2 align-items-center"" style=""padding:10px;"">
            <div");
            BeginWriteAttribute("class", " class=\"", 591, "\"", 599, 0);
            EndWriteAttribute();
            WriteLiteral(" id=\"barToUpload\" style=\"height:5px; border-radius:15px;\">\r\n\r\n            </div>\r\n        </div>\r\n        <div class=\"col-1\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b0209518e7dbb8afc8dadcf98026fdb3530b0ebd6562", async() => {
                WriteLiteral(@"
                <div class=""row justify-content-center"">
                    <h6 class=""text-secondary""><i>Uploaded</i></h6>
                </div>
                <div class=""row justify-content-center"">
                    <i class=""fas"" id=""uploadedIcon""></i>
                </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-2 align-items-center\" style=\"padding:10px;\">\r\n            <div");
            BeginWriteAttribute("class", " class=\"", 1235, "\"", 1243, 0);
            EndWriteAttribute();
            WriteLiteral(" id=\"barToApproved\" style=\"height:5px; border-radius:15px;\">\r\n\r\n            </div>\r\n        </div>\r\n        <div class=\"col-1\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b0209518e7dbb8afc8dadcf98026fdb3530b0ebd8601", async() => {
                WriteLiteral(@"
                <div class=""row justify-content-center"">
                    <h6 class=""text-secondary""><i>Approved</i></h6>
                </div>
                <div class=""row justify-content-center"">
                    <i class=""fas"" id=""approvedIcon""></i>
                </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-2 align-items-center\" style=\"padding:10px;\">\r\n            <div");
            BeginWriteAttribute("class", " class=\"", 1883, "\"", 1891, 0);
            EndWriteAttribute();
            WriteLiteral(" id=\"barToRegistered\" style=\"height:5px; border-radius:15px;\">\r\n\r\n            </div>\r\n        </div>\r\n        <div class=\"col-1\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b0209518e7dbb8afc8dadcf98026fdb3530b0ebd10642", async() => {
                WriteLiteral(@"
                <div class=""row justify-content-center"">
                    <h6 class=""text-secondary""><i>Registered</i></h6>
                </div>
                <div class=""row justify-content-center"">
                    <i class=""fas"" id=""registeredIcon""></i>
                </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n\r\n    </div>\r\n");
#nullable restore
#line 66 "S:\My Stuff\School\CS 4790\ISfTE\ISfTE\ISfTE\Pages\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome</h1>\r\n    <p>Display Home Page Information Here</p>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\r\n    <script>\r\n\r\n        if (\"");
#nullable restore
#line 77 "S:\My Stuff\School\CS 4790\ISfTE\ISfTE\ISfTE\Pages\Index.cshtml"
        Write(Model.ApplicationUser.Status);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" == \"");
#nullable restore
#line 77 "S:\My Stuff\School\CS 4790\ISfTE\ISfTE\ISfTE\Pages\Index.cshtml"
                                           Write(SD.Initial);

#line default
#line hidden
#nullable disable
                WriteLiteral(@""") {
            document.getElementById(""uploadedIcon"").className = ""far fa-square"";
            document.getElementById(""approvedIcon"").className += "" fa-lock"";
            document.getElementById(""registeredIcon"").className += "" fa-lock"";

            document.getElementById(""barToUpload"").className = ""bg-primary"";
            document.getElementById(""barToApproved"").className = ""bg-dark"";
            document.getElementById(""barToRegistered"").className = ""bg-dark"";
        }
        else if (""");
#nullable restore
#line 86 "S:\My Stuff\School\CS 4790\ISfTE\ISfTE\ISfTE\Pages\Index.cshtml"
             Write(Model.ApplicationUser.Status);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" == \"");
#nullable restore
#line 86 "S:\My Stuff\School\CS 4790\ISfTE\ISfTE\ISfTE\Pages\Index.cshtml"
                                                Write(SD.AbstractSubmitted);

#line default
#line hidden
#nullable disable
                WriteLiteral(@""") {
            document.getElementById(""uploadedIcon"").className += "" fa-check"";
            document.getElementById(""approvedIcon"").className += "" fa-spinner"";
            document.getElementById(""registeredIcon"").className += "" fa-lock"";

            document.getElementById(""barToUpload"").className = ""bg-success"";
            document.getElementById(""barToApproved"").className = ""bg-primary"";
            document.getElementById(""barToRegistered"").className = ""bg-dark"";
        }
        else if (""");
#nullable restore
#line 95 "S:\My Stuff\School\CS 4790\ISfTE\ISfTE\ISfTE\Pages\Index.cshtml"
             Write(Model.ApplicationUser.Status);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" == \"");
#nullable restore
#line 95 "S:\My Stuff\School\CS 4790\ISfTE\ISfTE\ISfTE\Pages\Index.cshtml"
                                                Write(SD.AbstractRejected);

#line default
#line hidden
#nullable disable
                WriteLiteral(@""") {
            document.getElementById(""uploadedIcon"").className += "" fa-check"";
            document.getElementById(""approvedIcon"").className += "" fa-times"";
            document.getElementById(""registeredIcon"").className += "" fa-lock"";

            document.getElementById(""barToUpload"").className = ""bg-success"";
            document.getElementById(""barToApproved"").className = ""bg-danger"";
            document.getElementById(""barToRegistered"").className = ""bg-dark"";
        }
        else if (""");
#nullable restore
#line 104 "S:\My Stuff\School\CS 4790\ISfTE\ISfTE\ISfTE\Pages\Index.cshtml"
             Write(Model.ApplicationUser.Status);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" == \"");
#nullable restore
#line 104 "S:\My Stuff\School\CS 4790\ISfTE\ISfTE\ISfTE\Pages\Index.cshtml"
                                                Write(SD.AbstractApproved);

#line default
#line hidden
#nullable disable
                WriteLiteral(@""") {
            document.getElementById(""uploadedIcon"").className += "" fa-check"";
            document.getElementById(""approvedIcon"").className += "" fa-check"";
            document.getElementById(""registeredIcon"").className = ""far fa-square"";

            document.getElementById(""barToUpload"").className = ""bg-success"";
            document.getElementById(""barToApproved"").className = ""bg-success"";
            document.getElementById(""barToRegistered"").className = ""bg-primary"";
        }
        else if (""");
#nullable restore
#line 113 "S:\My Stuff\School\CS 4790\ISfTE\ISfTE\ISfTE\Pages\Index.cshtml"
             Write(Model.ApplicationUser.Status);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" == \"");
#nullable restore
#line 113 "S:\My Stuff\School\CS 4790\ISfTE\ISfTE\ISfTE\Pages\Index.cshtml"
                                                Write(SD.Registered);

#line default
#line hidden
#nullable disable
                WriteLiteral(@""") {
            document.getElementById(""uploadedIcon"").className += "" fa-check"";
            document.getElementById(""approvedIcon"").className += "" fa-check"";
            document.getElementById(""registeredIcon"").className += "" fa-check"";

            document.getElementById(""barToUpload"").className = ""bg-success"";
            document.getElementById(""barToApproved"").className = ""bg-success"";
            document.getElementById(""barToRegistered"").className = ""bg-success"";
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591