#pragma checksum "S:\My Stuff\School\CS 4790\ISfTE\ISfTE\ISfTE\Pages\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fce1ca52c15f2487797172a3592a63ddfaac8b3d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ISfTE.Pages.Pages_About), @"mvc.1.0.razor-page", @"/Pages/About.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fce1ca52c15f2487797172a3592a63ddfaac8b3d", @"/Pages/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8947fe2694c5860c13a457a785fce9c76d86c9b", @"/Pages/_ViewImports.cshtml")]
    public class Pages_About : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "S:\My Stuff\School\CS 4790\ISfTE\ISfTE\ISfTE\Pages\About.cshtml"
  
        ViewData["Title"] = "About Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<h1 class=""text-info"">About the ISfTE Web App</h1>
<p>This application was developed by Weber State University students during the Spring 2020 semester
    to digitize the abstract submission, rating, and reviewal process as well as the registration and payment processing 
    of the next International Society for Teacher Education conference that will be hosted at Weber State University.</p>

<h3 class=""text-info"">Developed by:</h3>

<h5>Derek Eaton</h5>
<p><a href=""https://www.linkedin.com/in/derek-eaton-67935b105/"" target=""_blank"">Linkedin</a></p>
<h5>Michael Dansie</h5>
<p><a href=""https://www.linkedin.com/in/michael-dansie-09b840105/"" target=""_blank"">Linkedin</a></p>
<h5>Robert Pickard</h5>
<p><a href=""https://www.linkedin.com/in/robert-pickard-2ab0571a4/"" target=""_blank"">Linkedin</a></p>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ISfTE.Pages.AboutModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ISfTE.Pages.AboutModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ISfTE.Pages.AboutModel>)PageContext?.ViewData;
        public ISfTE.Pages.AboutModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
