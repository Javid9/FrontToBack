#pragma checksum "C:\Users\Cavid\Desktop\FrontToBack\FrontToBack\Views\Home\Basket.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d78b807852218cd5563ae1e21cce63f0ed0b173"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Basket), @"mvc.1.0.view", @"/Views/Home/Basket.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Basket.cshtml", typeof(AspNetCore.Views_Home_Basket))]
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
#line 1 "C:\Users\Cavid\Desktop\FrontToBack\FrontToBack\Views\_ViewImports.cshtml"
using FrontToBack.Models;

#line default
#line hidden
#line 2 "C:\Users\Cavid\Desktop\FrontToBack\FrontToBack\Views\_ViewImports.cshtml"
using FrontToBack.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d78b807852218cd5563ae1e21cce63f0ed0b173", @"/Views/Home/Basket.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ef499bc641b395c15c4ec72c4f836c4ebb7b5c6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Basket : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<BasketVM>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("200"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Cavid\Desktop\FrontToBack\FrontToBack\Views\Home\Basket.cshtml"
  
    ViewData["Title"] = "Basket";
    double Total = 0;

#line default
#line hidden
            BeginContext(88, 31, true);
            WriteLiteral("\r\n    <div class=\"container\">\r\n");
            EndContext();
#line 8 "C:\Users\Cavid\Desktop\FrontToBack\FrontToBack\Views\Home\Basket.cshtml"
         if (TempData["success"] != null)
        {

#line default
#line hidden
            BeginContext(173, 50, true);
            WriteLiteral("            <div class=\"mt-3 alert alert-success\">");
            EndContext();
            BeginContext(224, 19, false);
#line 10 "C:\Users\Cavid\Desktop\FrontToBack\FrontToBack\Views\Home\Basket.cshtml"
                                             Write(TempData["success"]);

#line default
#line hidden
            EndContext();
            BeginContext(243, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
#line 11 "C:\Users\Cavid\Desktop\FrontToBack\FrontToBack\Views\Home\Basket.cshtml"
        }

#line default
#line hidden
            BeginContext(262, 8, true);
            WriteLiteral("        ");
            EndContext();
#line 12 "C:\Users\Cavid\Desktop\FrontToBack\FrontToBack\Views\Home\Basket.cshtml"
         if (TempData["error"] != null)
        {

#line default
#line hidden
            BeginContext(314, 49, true);
            WriteLiteral("            <div class=\"mt-3 alert alert-danger\">");
            EndContext();
            BeginContext(364, 17, false);
#line 14 "C:\Users\Cavid\Desktop\FrontToBack\FrontToBack\Views\Home\Basket.cshtml"
                                            Write(TempData["error"]);

#line default
#line hidden
            EndContext();
            BeginContext(381, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
#line 15 "C:\Users\Cavid\Desktop\FrontToBack\FrontToBack\Views\Home\Basket.cshtml"
        }

#line default
#line hidden
            BeginContext(400, 34, true);
            WriteLiteral("        <div class=\"row mt-3\">\r\n\r\n");
            EndContext();
#line 18 "C:\Users\Cavid\Desktop\FrontToBack\FrontToBack\Views\Home\Basket.cshtml"
             if (Model.Count != 0)
            {

#line default
#line hidden
            BeginContext(485, 631, true);
            WriteLiteral(@"                <div class=""col-12"">
                    <table class=""table table-dark"">
                        <thead>
                            <tr>
                                <th scope=""col"">Image</th>
                                <th scope=""col"">Product Name</th>
                                <th scope=""col"">Price</th>
                                <th scope=""col"">Count</th>
                                <th scope=""col"">Total</th>
                                <th scope=""col"">Delete</th>

                            </tr>
                        </thead>
                        <tbody>
");
            EndContext();
#line 34 "C:\Users\Cavid\Desktop\FrontToBack\FrontToBack\Views\Home\Basket.cshtml"
                             foreach (BasketVM item in Model)
                            {
                                double total = item.Price * item.Count;
                                Total += total;

#line default
#line hidden
            BeginContext(1332, 108, true);
            WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(1440, 43, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "702b3968a6824e158c7f14bba563eb2c", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1450, "~/img/", 1450, 6, true);
#line 40 "C:\Users\Cavid\Desktop\FrontToBack\FrontToBack\Views\Home\Basket.cshtml"
AddHtmlAttributeValue("", 1456, item.Image, 1456, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1483, 77, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>");
            EndContext();
            BeginContext(1561, 10, false);
#line 42 "C:\Users\Cavid\Desktop\FrontToBack\FrontToBack\Views\Home\Basket.cshtml"
                               Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1571, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(1615, 10, false);
#line 43 "C:\Users\Cavid\Desktop\FrontToBack\FrontToBack\Views\Home\Basket.cshtml"
                               Write(item.Price);

#line default
#line hidden
            EndContext();
            BeginContext(1625, 59, true);
            WriteLiteral("</td>\r\n                                <td> <a>-</a>&nbsp; ");
            EndContext();
            BeginContext(1685, 10, false);
#line 44 "C:\Users\Cavid\Desktop\FrontToBack\FrontToBack\Views\Home\Basket.cshtml"
                                               Write(item.Count);

#line default
#line hidden
            EndContext();
            BeginContext(1695, 92, true);
            WriteLiteral(" &nbsp;<a>+</a></td>\r\n                                \r\n                                <td>");
            EndContext();
            BeginContext(1788, 5, false);
#line 46 "C:\Users\Cavid\Desktop\FrontToBack\FrontToBack\Views\Home\Basket.cshtml"
                               Write(total);

#line default
#line hidden
            EndContext();
            BeginContext(1793, 81, true);
            WriteLiteral("</td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(1874, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "81170bdf78884fe1ae284994890f0f35", async() => {
                BeginContext(1921, 1, true);
                WriteLiteral("X");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 48 "C:\Users\Cavid\Desktop\FrontToBack\FrontToBack\Views\Home\Basket.cshtml"
                                                             WriteLiteral(item.Id);

#line default
#line hidden
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
            EndContext();
            BeginContext(1926, 78, true);
            WriteLiteral("\r\n                                </td>\r\n\r\n                            </tr>\r\n");
            EndContext();
#line 52 "C:\Users\Cavid\Desktop\FrontToBack\FrontToBack\Views\Home\Basket.cshtml"
                            }

#line default
#line hidden
            BeginContext(2035, 89, true);
            WriteLiteral("                            <div class=\"row my-3 ml-1\">\r\n                                ");
            EndContext();
            BeginContext(2124, 162, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e5903857612d4deea2d3f8eb51a8cd5a", async() => {
                BeginContext(2144, 135, true);
                WriteLiteral("\r\n                                    <input type=\"submit\" class=\"btn btn-success\" value=\"Buy now\" />\r\n                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2286, 193, true);
            WriteLiteral("\r\n                            </div>\r\n                        </tbody>\r\n                    </table>\r\n                </div>\r\n                <div class=\"col-12\">\r\n                    <p>Total:");
            EndContext();
            BeginContext(2480, 5, false);
#line 62 "C:\Users\Cavid\Desktop\FrontToBack\FrontToBack\Views\Home\Basket.cshtml"
                        Write(Total);

#line default
#line hidden
            EndContext();
            BeginContext(2485, 30, true);
            WriteLiteral("</p>\r\n                </div>\r\n");
            EndContext();
#line 64 "C:\Users\Cavid\Desktop\FrontToBack\FrontToBack\Views\Home\Basket.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(2563, 38, true);
            WriteLiteral("                <p>Sebet boshdur</p>\r\n");
            EndContext();
#line 68 "C:\Users\Cavid\Desktop\FrontToBack\FrontToBack\Views\Home\Basket.cshtml"
            }

#line default
#line hidden
            BeginContext(2616, 42, true);
            WriteLiteral("\r\n\r\n        </div>\r\n      \r\n    </div>\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<BasketVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
