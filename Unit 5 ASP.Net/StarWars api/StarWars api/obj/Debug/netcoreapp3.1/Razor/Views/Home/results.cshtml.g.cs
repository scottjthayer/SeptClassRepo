#pragma checksum "C:\Users\Jeo\source\repos\StarWars api\StarWars api\Views\Home\results.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99c1de05811430775bee27a6800e018efabee56f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_results), @"mvc.1.0.view", @"/Views/Home/results.cshtml")]
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
#line 1 "C:\Users\Jeo\source\repos\StarWars api\StarWars api\Views\_ViewImports.cshtml"
using StarWars_api;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Jeo\source\repos\StarWars api\StarWars api\Views\_ViewImports.cshtml"
using StarWars_api.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99c1de05811430775bee27a6800e018efabee56f", @"/Views/Home/results.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"acfcd8960d51346c05cbe03e744563c1bc3545a1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_results : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StarwarsModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\Jeo\source\repos\StarWars api\StarWars api\Views\Home\results.cshtml"
 foreach(Result r in Model.results)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div>\r\n                    <h1>");
#nullable restore
#line 11 "C:\Users\Jeo\source\repos\StarWars api\StarWars api\Views\Home\results.cshtml"
                   Write(r.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                    <h2>Born in ");
#nullable restore
#line 12 "C:\Users\Jeo\source\repos\StarWars api\StarWars api\Views\Home\results.cshtml"
                           Write(r.birth_year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                    <h2>");
#nullable restore
#line 13 "C:\Users\Jeo\source\repos\StarWars api\StarWars api\Views\Home\results.cshtml"
                   Write(r.gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                </div>\r\n");
#nullable restore
#line 15 "C:\Users\Jeo\source\repos\StarWars api\StarWars api\Views\Home\results.cshtml"
            }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StarwarsModel> Html { get; private set; }
    }
}
#pragma warning restore 1591