#pragma checksum "C:\Users\HP\Desktop\Desktop\c#\shopapp\shopapp.webui\Views\Filmler\Duzenle.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2cc7373354ebc8a9dbdb8b4d25b8bf7d3d32c0f7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Filmler_Duzenle), @"mvc.1.0.view", @"/Views/Filmler/Duzenle.cshtml")]
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
#line 3 "C:\Users\HP\Desktop\Desktop\c#\shopapp\shopapp.webui\Views\_Viewimports.cshtml"
using shopapp.entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\HP\Desktop\Desktop\c#\shopapp\shopapp.webui\Views\_Viewimports.cshtml"
using shopapp.webui.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\HP\Desktop\Desktop\c#\shopapp\shopapp.webui\Views\_Viewimports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\HP\Desktop\Desktop\c#\shopapp\shopapp.webui\Views\_Viewimports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2cc7373354ebc8a9dbdb8b4d25b8bf7d3d32c0f7", @"/Views/Filmler/Duzenle.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9a0408e1cb86a9bda2741a5671be4081aa70062", @"/Views/_Viewimports.cshtml")]
    public class Views_Filmler_Duzenle : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Film>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2cc7373354ebc8a9dbdb8b4d25b8bf7d3d32c0f73932", async() => {
                WriteLiteral("\r\n    <input type=\"hidden\" name=\"FilmId\"");
                BeginWriteAttribute("value", " value=\"", 86, "\"", 107, 1);
#nullable restore
#line 9 "C:\Users\HP\Desktop\Desktop\c#\shopapp\shopapp.webui\Views\Filmler\Duzenle.cshtml"
WriteAttributeValue("", 94, Model.FilmId, 94, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n\r\n    <div class=\"form-group\">\r\n        <label for=\"Name\">Film Adı</label>\r\n        <input type=\"text\"");
                BeginWriteAttribute("value", " value=\"", 213, "\"", 232, 1);
#nullable restore
#line 13 "C:\Users\HP\Desktop\Desktop\c#\shopapp\shopapp.webui\Views\Filmler\Duzenle.cshtml"
WriteAttributeValue("", 221, Model.Name, 221, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"Name\" class=\"form-control\">\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        <label for=\"Sene\">Film Yılı</label>\r\n        <input type=\"text\"");
                BeginWriteAttribute("value", " value=\"", 384, "\"", 403, 1);
#nullable restore
#line 18 "C:\Users\HP\Desktop\Desktop\c#\shopapp\shopapp.webui\Views\Filmler\Duzenle.cshtml"
WriteAttributeValue("", 392, Model.Sene, 392, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"Sene\" class=\"form-control\">\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        <label for=\"Description\">Film Açıklaması</label>\r\n        <textarea name=\"Description\"");
                BeginWriteAttribute("value", " value=\"", 578, "\"", 604, 1);
#nullable restore
#line 23 "C:\Users\HP\Desktop\Desktop\c#\shopapp\shopapp.webui\Views\Filmler\Duzenle.cshtml"
WriteAttributeValue("", 586, Model.Description, 586, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\">İyi Film</textarea> \r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        <label for=\"ResimUrl\">ResimUrl</label>\r\n        <input type=\"text\"");
                BeginWriteAttribute("value", " value=\"", 767, "\"", 790, 1);
#nullable restore
#line 28 "C:\Users\HP\Desktop\Desktop\c#\shopapp\shopapp.webui\Views\Filmler\Duzenle.cshtml"
WriteAttributeValue("", 775, Model.ResimUrl, 775, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"ResimUrl\" class=\"form-control\">\r\n    </div>\r\n\r\n    \r\n");
                WriteLiteral("\r\n    <button type=\"submit\" class=\"btn btn-primary\">Kaydet</button>\r\n    \r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("  ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Film> Html { get; private set; }
    }
}
#pragma warning restore 1591
