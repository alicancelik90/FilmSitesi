#pragma checksum "C:\Users\HP\Desktop\Desktop\c#\shopapp\shopapp.webui\Views\FilmSitesi\Liste.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c6c97d0aca143ca4ea08fbe4da50a68b8ac2c1ea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_FilmSitesi_Liste), @"mvc.1.0.view", @"/Views/FilmSitesi/Liste.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6c97d0aca143ca4ea08fbe4da50a68b8ac2c1ea", @"/Views/FilmSitesi/Liste.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9a0408e1cb86a9bda2741a5671be4081aa70062", @"/Views/_Viewimports.cshtml")]
    public class Views_FilmSitesi_Liste : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FilmListeViewModel>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c6c97d0aca143ca4ea08fbe4da50a68b8ac2c1ea3695", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Filmler</title>
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css"" integrity=""sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh"" crossorigin=""anonymous"">
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c6c97d0aca143ca4ea08fbe4da50a68b8ac2c1ea5090", async() => {
                WriteLiteral("\r\n   \r\n        \r\n            <div class=\"row\">\r\n                <div class=\"col-md-3\">\r\n                    ");
#nullable restore
#line 23 "C:\Users\HP\Desktop\Desktop\c#\shopapp\shopapp.webui\Views\FilmSitesi\Liste.cshtml"
               Write(await Component.InvokeAsync("Kategoriler"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n                <div class=\"col-md-9\">\r\n                  \r\n                   <div class=\"row\">\r\n\r\n");
#nullable restore
#line 29 "C:\Users\HP\Desktop\Desktop\c#\shopapp\shopapp.webui\Views\FilmSitesi\Liste.cshtml"
                        foreach (var f in Model.Filmler)
                       {


#line default
#line hidden
#nullable disable
                WriteLiteral("                        <div class=\"col-md-4\">\r\n                           ");
#nullable restore
#line 33 "C:\Users\HP\Desktop\Desktop\c#\shopapp\shopapp.webui\Views\FilmSitesi\Liste.cshtml"
                      Write(await Html.PartialAsync("_film",f));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            \r\n                        </div>\r\n");
#nullable restore
#line 36 "C:\Users\HP\Desktop\Desktop\c#\shopapp\shopapp.webui\Views\FilmSitesi\Liste.cshtml"
        
                       }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n\r\n                    <div class=\"row\">\r\n                        <div class=\"col\">\r\n                             <nav aria-label=\"Page navigation example\">\r\n                                <ul class=\"pagination\">\r\n");
#nullable restore
#line 45 "C:\Users\HP\Desktop\Desktop\c#\shopapp\shopapp.webui\Views\FilmSitesi\Liste.cshtml"
                                      for (int i =0; i < Model.PageInfo.TotalPages(); i++)
                                     {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "C:\Users\HP\Desktop\Desktop\c#\shopapp\shopapp.webui\Views\FilmSitesi\Liste.cshtml"
                                         if (String.IsNullOrEmpty(Model.PageInfo.CurrentKategori))
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                             <li");
                BeginWriteAttribute("class", " class=\"", 1631, "\"", 1695, 2);
                WriteAttributeValue("", 1639, "page-item", 1639, 9, true);
#nullable restore
#line 49 "C:\Users\HP\Desktop\Desktop\c#\shopapp\shopapp.webui\Views\FilmSitesi\Liste.cshtml"
WriteAttributeValue(" ", 1648, Model.PageInfo.CurrentPage==i+1?"active":"", 1649, 46, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                               <a class=\"page-link\"");
                BeginWriteAttribute("href", " href=\"", 1766, "\"", 1798, 3);
                WriteAttributeValue("", 1773, "/film", 1773, 5, true);
                WriteAttributeValue(" ", 1778, "listesi?page=", 1779, 14, true);
#nullable restore
#line 50 "C:\Users\HP\Desktop\Desktop\c#\shopapp\shopapp.webui\Views\FilmSitesi\Liste.cshtml"
WriteAttributeValue("", 1792, i+1, 1792, 6, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                                  ");
#nullable restore
#line 51 "C:\Users\HP\Desktop\Desktop\c#\shopapp\shopapp.webui\Views\FilmSitesi\Liste.cshtml"
                                              Write(i+1);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                               </a>\r\n                                             </li>\r\n");
#nullable restore
#line 54 "C:\Users\HP\Desktop\Desktop\c#\shopapp\shopapp.webui\Views\FilmSitesi\Liste.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                             <li");
                BeginWriteAttribute("class", " class=\"", 2145, "\"", 2209, 2);
                WriteAttributeValue("", 2153, "page-item", 2153, 9, true);
#nullable restore
#line 57 "C:\Users\HP\Desktop\Desktop\c#\shopapp\shopapp.webui\Views\FilmSitesi\Liste.cshtml"
WriteAttributeValue(" ", 2162, Model.PageInfo.CurrentPage==i+1?"active":"", 2163, 46, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                               <a class=\"page-link\"");
                BeginWriteAttribute("href", " href=\"", 2280, "\"", 2344, 5);
                WriteAttributeValue("", 2287, "/film", 2287, 5, true);
                WriteAttributeValue(" ", 2292, "listesi/", 2293, 9, true);
#nullable restore
#line 58 "C:\Users\HP\Desktop\Desktop\c#\shopapp\shopapp.webui\Views\FilmSitesi\Liste.cshtml"
WriteAttributeValue("", 2301, Model.PageInfo.CurrentKategori, 2301, 31, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2332, "?page=", 2332, 6, true);
#nullable restore
#line 58 "C:\Users\HP\Desktop\Desktop\c#\shopapp\shopapp.webui\Views\FilmSitesi\Liste.cshtml"
WriteAttributeValue("", 2338, i+1, 2338, 6, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                                  ");
#nullable restore
#line 59 "C:\Users\HP\Desktop\Desktop\c#\shopapp\shopapp.webui\Views\FilmSitesi\Liste.cshtml"
                                              Write(i+1);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                               </a>\r\n                                             </li>\r\n");
#nullable restore
#line 62 "C:\Users\HP\Desktop\Desktop\c#\shopapp\shopapp.webui\Views\FilmSitesi\Liste.cshtml"
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 62 "C:\Users\HP\Desktop\Desktop\c#\shopapp\shopapp.webui\Views\FilmSitesi\Liste.cshtml"
                                         
                                      
                                     }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"            
                                   
                                   
                               </ul>
                            </nav>
                        </div>
                    </div>

                </div>
          </div>
              
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FilmListeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
