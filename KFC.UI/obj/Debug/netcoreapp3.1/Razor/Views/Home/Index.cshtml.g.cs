#pragma checksum "C:\Users\sasha\source\repos\KFC\KFC.UI\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a5b1b05fabbb063409c3bc2e7280455ee3a286b3"
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
#line 1 "C:\Users\sasha\source\repos\KFC\KFC.UI\Views\_ViewImports.cshtml"
using KFC.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sasha\source\repos\KFC\KFC.UI\Views\_ViewImports.cshtml"
using KFC.UI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\sasha\source\repos\KFC\KFC.UI\Views\_ViewImports.cshtml"
using KFC.Domain.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\sasha\source\repos\KFC\KFC.UI\Views\_ViewImports.cshtml"
using KFC.UI.Extensions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5b1b05fabbb063409c3bc2e7280455ee3a286b3", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7352dee263f16c586992b5819f8361ddf1318f29", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<div class=\"row mt-5 mb-2\">\r\n");
#nullable restore
#line 4 "C:\Users\sasha\source\repos\KFC\KFC.UI\Views\Home\Index.cshtml"
     foreach (var products in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("           <div class=\"col-lg-4\">\r\n                <img class=\"img-thumbnail\"");
            BeginWriteAttribute("src", " src=\"", 182, "\"", 210, 1);
#nullable restore
#line 7 "C:\Users\sasha\source\repos\KFC\KFC.UI\Views\Home\Index.cshtml"
WriteAttributeValue("", 188, products.ProductPhoto, 188, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 211, "\"", 238, 1);
#nullable restore
#line 7 "C:\Users\sasha\source\repos\KFC\KFC.UI\Views\Home\Index.cshtml"
WriteAttributeValue("", 217, products.ProductName, 217, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                <h2>");
#nullable restore
#line 8 "C:\Users\sasha\source\repos\KFC\KFC.UI\Views\Home\Index.cshtml"
               Write(products.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                <p>Описание:");
#nullable restore
#line 9 "C:\Users\sasha\source\repos\KFC\KFC.UI\Views\Home\Index.cshtml"
                       Write(products.ProductDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p>Количество:");
#nullable restore
#line 10 "C:\Users\sasha\source\repos\KFC\KFC.UI\Views\Home\Index.cshtml"
                         Write(products.ProductAmount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p>Размер:");
#nullable restore
#line 11 "C:\Users\sasha\source\repos\KFC\KFC.UI\Views\Home\Index.cshtml"
                     Write(products.ProductSize);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p>Цена:");
#nullable restore
#line 12 "C:\Users\sasha\source\repos\KFC\KFC.UI\Views\Home\Index.cshtml"
                   Write(products.ProductPrice.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a5b1b05fabbb063409c3bc2e7280455ee3a286b36151", async() => {
                WriteLiteral("\r\n                    <input type=\"hidden\" name=\"productId\"");
                BeginWriteAttribute("value", " value=\"", 671, "\"", 691, 1);
#nullable restore
#line 14 "C:\Users\sasha\source\repos\KFC\KFC.UI\Views\Home\Index.cshtml"
WriteAttributeValue("", 679, products.Id, 679, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n                    <button class=\"btn btn-outline-success\" type=\"submit\">В корзину</button>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 13 "C:\Users\sasha\source\repos\KFC\KFC.UI\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 562, Url.Action("AddProduct", "Order"), 562, 34, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n           </div>\r\n");
#nullable restore
#line 18 "C:\Users\sasha\source\repos\KFC\KFC.UI\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
