#pragma checksum "C:\Users\Jeo\source\repos\CoffeeShop2\CoffeeShop2\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3fca9859059eeaf6934e0de1f4e26331dd737caa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
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
#line 1 "C:\Users\Jeo\source\repos\CoffeeShop2\CoffeeShop2\Views\_ViewImports.cshtml"
using CoffeeShop2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Jeo\source\repos\CoffeeShop2\CoffeeShop2\Views\_ViewImports.cshtml"
using CoffeeShop2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3fca9859059eeaf6934e0de1f4e26331dd737caa", @"/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd4dba7e95364963bf8a43bdfc892bc18ba05b92", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h2>");
#nullable restore
#line 8 "C:\Users\Jeo\source\repos\CoffeeShop2\CoffeeShop2\Views\Home\Details.cshtml"
Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(" : ");
#nullable restore
#line 8 "C:\Users\Jeo\source\repos\CoffeeShop2\CoffeeShop2\Views\Home\Details.cshtml"
           Write(Model.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 8 "C:\Users\Jeo\source\repos\CoffeeShop2\CoffeeShop2\Views\Home\Details.cshtml"
                            Write(Model.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n<h3>");
#nullable restore
#line 10 "C:\Users\Jeo\source\repos\CoffeeShop2\CoffeeShop2\Views\Home\Details.cshtml"
Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<h3>");
#nullable restore
#line 11 "C:\Users\Jeo\source\repos\CoffeeShop2\CoffeeShop2\Views\Home\Details.cshtml"
Write(Model.FavDrink);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<h3>");
#nullable restore
#line 12 "C:\Users\Jeo\source\repos\CoffeeShop2\CoffeeShop2\Views\Home\Details.cshtml"
Write(Model.Birthday);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<User> Html { get; private set; }
    }
}
#pragma warning restore 1591
