#pragma checksum "C:\Users\Josh\Desktop\GC class repo\SeptClassRepo\Unit 5 ASP.Net\CardDemo\CardDemo\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ea630652689b9f9e3a33862ec8763e70660effb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Josh\Desktop\GC class repo\SeptClassRepo\Unit 5 ASP.Net\CardDemo\CardDemo\Views\_ViewImports.cshtml"
using CardDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Josh\Desktop\GC class repo\SeptClassRepo\Unit 5 ASP.Net\CardDemo\CardDemo\Views\_ViewImports.cshtml"
using CardDemo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ea630652689b9f9e3a33862ec8763e70660effb", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0fa1be686e57fbfdc6db0052e48337fb3c526412", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CardSet>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Josh\Desktop\GC class repo\SeptClassRepo\Unit 5 ASP.Net\CardDemo\CardDemo\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Results</h1>\r\n\r\nDeck Id: ");
#nullable restore
#line 8 "C:\Users\Josh\Desktop\GC class repo\SeptClassRepo\Unit 5 ASP.Net\CardDemo\CardDemo\Views\Home\Index.cshtml"
    Write(Model.deck_id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\nRemaining: ");
#nullable restore
#line 10 "C:\Users\Josh\Desktop\GC class repo\SeptClassRepo\Unit 5 ASP.Net\CardDemo\CardDemo\Views\Home\Index.cshtml"
      Write(Model.remaining);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5ea630652689b9f9e3a33862ec8763e70660effb4693", async() => {
                WriteLiteral("\r\n\r\n");
#nullable restore
#line 16 "C:\Users\Josh\Desktop\GC class repo\SeptClassRepo\Unit 5 ASP.Net\CardDemo\CardDemo\Views\Home\Index.cshtml"
     for (int i = 0; i < Model.cards.Count(); i++)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div>Suit: ");
#nullable restore
#line 18 "C:\Users\Josh\Desktop\GC class repo\SeptClassRepo\Unit 5 ASP.Net\CardDemo\CardDemo\Views\Home\Index.cshtml"
              Write(Model.cards[i].suit);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n        <div>Value: ");
#nullable restore
#line 19 "C:\Users\Josh\Desktop\GC class repo\SeptClassRepo\Unit 5 ASP.Net\CardDemo\CardDemo\Views\Home\Index.cshtml"
               Write(Model.cards[i].value);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n        <div>\r\n            <img");
                BeginWriteAttribute("src", " src=\"", 420, "\"", 447, 1);
#nullable restore
#line 21 "C:\Users\Josh\Desktop\GC class repo\SeptClassRepo\Unit 5 ASP.Net\CardDemo\CardDemo\Views\Home\Index.cshtml"
WriteAttributeValue("", 426, Model.cards[i].image, 426, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        </div>\r\n");
#nullable restore
#line 23 "C:\Users\Josh\Desktop\GC class repo\SeptClassRepo\Unit 5 ASP.Net\CardDemo\CardDemo\Views\Home\Index.cshtml"
                                    
        string keepCard = "keep" + i;

        

#line default
#line hidden
#nullable disable
                WriteLiteral("        <input type=\"checkbox\"");
                BeginWriteAttribute("id", " id=\"", 634, "\"", 648, 1);
#nullable restore
#line 27 "C:\Users\Josh\Desktop\GC class repo\SeptClassRepo\Unit 5 ASP.Net\CardDemo\CardDemo\Views\Home\Index.cshtml"
WriteAttributeValue("", 639, keepCard, 639, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"keepIndex[]\"");
                BeginWriteAttribute("value", " value=\"", 668, "\"", 678, 1);
#nullable restore
#line 27 "C:\Users\Josh\Desktop\GC class repo\SeptClassRepo\Unit 5 ASP.Net\CardDemo\CardDemo\Views\Home\Index.cshtml"
WriteAttributeValue("", 676, i, 676, 2, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        <label");
                BeginWriteAttribute("for", " for=\"", 698, "\"", 713, 1);
#nullable restore
#line 28 "C:\Users\Josh\Desktop\GC class repo\SeptClassRepo\Unit 5 ASP.Net\CardDemo\CardDemo\Views\Home\Index.cshtml"
WriteAttributeValue("", 704, keepCard, 704, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Keep Card?</label>\r\n");
                WriteLiteral("        <input type=\"hidden\"");
                BeginWriteAttribute("name", " name=\"", 828, "\"", 848, 3);
                WriteAttributeValue("", 835, "hand[", 835, 5, true);
#nullable restore
#line 31 "C:\Users\Josh\Desktop\GC class repo\SeptClassRepo\Unit 5 ASP.Net\CardDemo\CardDemo\Views\Home\Index.cshtml"
WriteAttributeValue("", 840, i, 840, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 842, "].suit", 842, 6, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 849, "\"", 877, 1);
#nullable restore
#line 31 "C:\Users\Josh\Desktop\GC class repo\SeptClassRepo\Unit 5 ASP.Net\CardDemo\CardDemo\Views\Home\Index.cshtml"
WriteAttributeValue("", 857, Model.cards[i].suit, 857, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        <input type=\"hidden\"");
                BeginWriteAttribute("name", " name=\"", 911, "\"", 932, 3);
                WriteAttributeValue("", 918, "hand[", 918, 5, true);
#nullable restore
#line 32 "C:\Users\Josh\Desktop\GC class repo\SeptClassRepo\Unit 5 ASP.Net\CardDemo\CardDemo\Views\Home\Index.cshtml"
WriteAttributeValue("", 923, i, 923, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 925, "].value", 925, 7, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 933, "\"", 962, 1);
#nullable restore
#line 32 "C:\Users\Josh\Desktop\GC class repo\SeptClassRepo\Unit 5 ASP.Net\CardDemo\CardDemo\Views\Home\Index.cshtml"
WriteAttributeValue("", 941, Model.cards[i].value, 941, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        <input type=\"hidden\"");
                BeginWriteAttribute("name", " name=\"", 996, "\"", 1017, 3);
                WriteAttributeValue("", 1003, "hand[", 1003, 5, true);
#nullable restore
#line 33 "C:\Users\Josh\Desktop\GC class repo\SeptClassRepo\Unit 5 ASP.Net\CardDemo\CardDemo\Views\Home\Index.cshtml"
WriteAttributeValue("", 1008, i, 1008, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1010, "].image", 1010, 7, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1018, "\"", 1047, 1);
#nullable restore
#line 33 "C:\Users\Josh\Desktop\GC class repo\SeptClassRepo\Unit 5 ASP.Net\CardDemo\CardDemo\Views\Home\Index.cshtml"
WriteAttributeValue("", 1026, Model.cards[i].image, 1026, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
#nullable restore
#line 34 "C:\Users\Josh\Desktop\GC class repo\SeptClassRepo\Unit 5 ASP.Net\CardDemo\CardDemo\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("    <br />\r\n    <input type=\"submit\" value=\"Draw more cards\" />\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-deckId", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 14 "C:\Users\Josh\Desktop\GC class repo\SeptClassRepo\Unit 5 ASP.Net\CardDemo\CardDemo\Views\Home\Index.cshtml"
                                             WriteLiteral(Model.deck_id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["deckId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-deckId", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["deckId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CardSet> Html { get; private set; }
    }
}
#pragma warning restore 1591
