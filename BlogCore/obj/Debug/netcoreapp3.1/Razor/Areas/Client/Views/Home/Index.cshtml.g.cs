#pragma checksum "E:\Proyectos C#\Mvc\BlogCore\BlogCore\Areas\Client\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bed246c505d3c4c68f7febc6c18d73faf266cd39"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Client_Views_Home_Index), @"mvc.1.0.view", @"/Areas/Client/Views/Home/Index.cshtml")]
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
#line 1 "E:\Proyectos C#\Mvc\BlogCore\BlogCore\Areas\Client\Views\_ViewImports.cshtml"
using BlogCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Proyectos C#\Mvc\BlogCore\BlogCore\Areas\Client\Views\_ViewImports.cshtml"
using BlogCore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bed246c505d3c4c68f7febc6c18d73faf266cd39", @"/Areas/Client/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"784938c45a729b1006f16b3b5ebaebddb8e24285", @"/Areas/Client/Views/_ViewImports.cshtml")]
    public class Areas_Client_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BlogCore.Models.ViewModel.HomeVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-block btn btn-outline-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("border-radius:2px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "E:\Proyectos C#\Mvc\BlogCore\BlogCore\Areas\Client\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!-- Slider -->\r\n<header>\r\n    <div id=\"carouselExampleControls\" class=\"carousel slide\" data-ride=\"carousel\">\r\n        <div class=\"carousel-inner\">\r\n");
#nullable restore
#line 10 "E:\Proyectos C#\Mvc\BlogCore\BlogCore\Areas\Client\Views\Home\Index.cshtml"
              int cont = 0; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\Proyectos C#\Mvc\BlogCore\BlogCore\Areas\Client\Views\Home\Index.cshtml"
             foreach (var item in Model.Sliders)
            {
                var DinamicItem = cont++ == 0 ? "item active" : "item";

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div");
            BeginWriteAttribute("class", " class=\"", 467, "\"", 501, 2);
            WriteAttributeValue("", 475, "carousel-item", 475, 13, true);
#nullable restore
#line 14 "E:\Proyectos C#\Mvc\BlogCore\BlogCore\Areas\Client\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 488, DinamicItem, 489, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 529, "\"", 562, 1);
#nullable restore
#line 15 "E:\Proyectos C#\Mvc\BlogCore\BlogCore\Areas\Client\Views\Home\Index.cshtml"
WriteAttributeValue("", 535, Url.Content(item.UrlImage), 535, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Alternate Text\" style=\"width:100%;height:100%\" />\r\n                    <h1 class=\"text-center text-dark\"> ");
#nullable restore
#line 16 "E:\Proyectos C#\Mvc\BlogCore\BlogCore\Areas\Client\Views\Home\Index.cshtml"
                                                  Write(Html.Raw(item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h1>\r\n                </div>\r\n");
#nullable restore
#line 18 "E:\Proyectos C#\Mvc\BlogCore\BlogCore\Areas\Client\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
        <a class=""carousel-control-prev"" href=""#carouselExampleControls"" role=""button"" data-slide=""prev"">
            <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
            <span class=""sr-only"">Previous</span>
        </a>
        <a class=""carousel-control-next"" href=""#carouselExampleControls"" role=""button"" data-slide=""next"">
            <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
            <span class=""sr-only"">Next</span>
        </a>
    </div>
</header>
<!-- Cierra Slider -->

<div class=""row fondoTitulo mt-5"">
    <div class=""col-sm-12 py-5"">
        <h1 class=""text-center text-white""> Ultimos articulos y novedades </h1>
    </div>
</div>

<!-- Lista de articulos  -->
");
#nullable restore
#line 39 "E:\Proyectos C#\Mvc\BlogCore\BlogCore\Areas\Client\Views\Home\Index.cshtml"
 if (Model.Articles.Count() > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <hr />\r\n    <div class=\"row\">\r\n");
#nullable restore
#line 43 "E:\Proyectos C#\Mvc\BlogCore\BlogCore\Areas\Client\Views\Home\Index.cshtml"
         foreach (var item in Model.Articles)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-4\">\r\n                <div class=\"card\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 1735, "\"", 1755, 1);
#nullable restore
#line 47 "E:\Proyectos C#\Mvc\BlogCore\BlogCore\Areas\Client\Views\Home\Index.cshtml"
WriteAttributeValue("", 1741, item.UrlImage, 1741, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-thumbnail\" width=\"100%\" />\r\n                    <div class=\"card-body\">\r\n                        <h5 class=\"text-center\">");
#nullable restore
#line 49 "E:\Proyectos C#\Mvc\BlogCore\BlogCore\Areas\Client\Views\Home\Index.cshtml"
                                           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        <p> Fecha de Creación : ");
#nullable restore
#line 50 "E:\Proyectos C#\Mvc\BlogCore\BlogCore\Areas\Client\Views\Home\Index.cshtml"
                                           Write(item.CreateDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bed246c505d3c4c68f7febc6c18d73faf266cd399086", async() => {
                WriteLiteral(" Detalles");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 51 "E:\Proyectos C#\Mvc\BlogCore\BlogCore\Areas\Client\Views\Home\Index.cshtml"
                                                                                                                      WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 55 "E:\Proyectos C#\Mvc\BlogCore\BlogCore\Areas\Client\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n");
#nullable restore
#line 57 "E:\Proyectos C#\Mvc\BlogCore\BlogCore\Areas\Client\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BlogCore.Models.ViewModel.HomeVM> Html { get; private set; }
    }
}
#pragma warning restore 1591