#pragma checksum "C:\Users\Jeo\source\repos\APILecture\APILecture\Views\Home\Reddit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ad473ed730849eeae0a7b062c80e0fae8641c3f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Reddit), @"mvc.1.0.view", @"/Views/Home/Reddit.cshtml")]
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
#line 1 "C:\Users\Jeo\source\repos\APILecture\APILecture\Views\_ViewImports.cshtml"
using APILecture;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Jeo\source\repos\APILecture\APILecture\Views\_ViewImports.cshtml"
using APILecture.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ad473ed730849eeae0a7b062c80e0fae8641c3f", @"/Views/Home/Reddit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17d2db5ce71d3084bcc3c6f805c20b4af615145c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Reddit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RedditModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\Jeo\source\repos\APILecture\APILecture\Views\Home\Reddit.cshtml"
 foreach (Child post in Model.data.children)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<a");
            BeginWriteAttribute("href", " href=\"", 203, "\"", 249, 2);
            WriteAttributeValue("", 210, "https://reddit.com/", 210, 19, true);
#nullable restore
#line 10 "C:\Users\Jeo\source\repos\APILecture\APILecture\Views\Home\Reddit.cshtml"
WriteAttributeValue("", 229, post.data.permalink, 229, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    <div>\r\n        <h2>");
#nullable restore
#line 12 "C:\Users\Jeo\source\repos\APILecture\APILecture\Views\Home\Reddit.cshtml"
       Write(post.data.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n        <img");
            BeginWriteAttribute("src", " src=\"", 311, "\"", 337, 1);
#nullable restore
#line 13 "C:\Users\Jeo\source\repos\APILecture\APILecture\Views\Home\Reddit.cshtml"
WriteAttributeValue("", 317, post.data.thumbnail, 317, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    </div>\r\n</a>\r\n");
#nullable restore
#line 16 "C:\Users\Jeo\source\repos\APILecture\APILecture\Views\Home\Reddit.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RedditModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
