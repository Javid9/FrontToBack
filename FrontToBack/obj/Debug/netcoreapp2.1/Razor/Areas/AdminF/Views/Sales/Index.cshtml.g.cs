#pragma checksum "C:\Users\Cavid\Desktop\FrontToBack\FrontToBack\Areas\AdminF\Views\Sales\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "46a3b9ef4a295445440ee62b9c07b8c82e7a18a5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminF_Views_Sales_Index), @"mvc.1.0.view", @"/Areas/AdminF/Views/Sales/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/AdminF/Views/Sales/Index.cshtml", typeof(AspNetCore.Areas_AdminF_Views_Sales_Index))]
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
#line 1 "C:\Users\Cavid\Desktop\FrontToBack\FrontToBack\Areas\AdminF\Views\_ViewImports.cshtml"
using FrontToBack.Models;

#line default
#line hidden
#line 2 "C:\Users\Cavid\Desktop\FrontToBack\FrontToBack\Areas\AdminF\Views\_ViewImports.cshtml"
using FrontToBack.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46a3b9ef4a295445440ee62b9c07b8c82e7a18a5", @"/Areas/AdminF/Views/Sales/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ef499bc641b395c15c4ec72c4f836c4ebb7b5c6", @"/Areas/AdminF/Views/_ViewImports.cshtml")]
    public class Areas_AdminF_Views_Sales_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SaleVM>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Cavid\Desktop\FrontToBack\FrontToBack\Areas\AdminF\Views\Sales\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(62, 1076, true);
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-lg-12 grid-margin stretch-card"">
        <div class=""card"">
            <div class=""card-body"">
                <h4 class=""card-title"">Users</h4>
                <div class=""table-responsive pt-3"">
                    <table class=""table table-bordered"">
                        <thead>
                            <tr>
                                <th>
                                    Fullname
                                </th>
                                <th>
                                    Email
                                </th>
                                <th>
                                    Date
                                </th>
                                <th>
                                    Total
                                </th>
                                <th>
                                    Products
                                </th>
                            </tr>
               ");
            WriteLiteral("         </thead>\r\n                        <tbody>\r\n");
            EndContext();
#line 33 "C:\Users\Cavid\Desktop\FrontToBack\FrontToBack\Areas\AdminF\Views\Sales\Index.cshtml"
                             foreach (SaleVM sale in Model)
                            {

#line default
#line hidden
            BeginContext(1230, 108, true);
            WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(1339, 13, false);
#line 37 "C:\Users\Cavid\Desktop\FrontToBack\FrontToBack\Areas\AdminF\Views\Sales\Index.cshtml"
                               Write(sale.Fullname);

#line default
#line hidden
            EndContext();
            BeginContext(1352, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(1468, 10, false);
#line 40 "C:\Users\Cavid\Desktop\FrontToBack\FrontToBack\Areas\AdminF\Views\Sales\Index.cshtml"
                               Write(sale.Email);

#line default
#line hidden
            EndContext();
            BeginContext(1478, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(1594, 9, false);
#line 43 "C:\Users\Cavid\Desktop\FrontToBack\FrontToBack\Areas\AdminF\Views\Sales\Index.cshtml"
                               Write(sale.Date);

#line default
#line hidden
            EndContext();
            BeginContext(1603, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(1719, 10, false);
#line 46 "C:\Users\Cavid\Desktop\FrontToBack\FrontToBack\Areas\AdminF\Views\Sales\Index.cshtml"
                               Write(sale.Total);

#line default
#line hidden
            EndContext();
            BeginContext(1729, 121, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    <ul>\r\n");
            EndContext();
#line 50 "C:\Users\Cavid\Desktop\FrontToBack\FrontToBack\Areas\AdminF\Views\Sales\Index.cshtml"
                                         foreach (SaleProduct item in sale.SaleProducts)
                                        {

#line default
#line hidden
            BeginContext(1983, 48, true);
            WriteLiteral("                                            <li>");
            EndContext();
            BeginContext(2032, 18, false);
#line 52 "C:\Users\Cavid\Desktop\FrontToBack\FrontToBack\Areas\AdminF\Views\Sales\Index.cshtml"
                                           Write(item.Product.Title);

#line default
#line hidden
            EndContext();
            BeginContext(2050, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(2054, 10, false);
#line 52 "C:\Users\Cavid\Desktop\FrontToBack\FrontToBack\Areas\AdminF\Views\Sales\Index.cshtml"
                                                                 Write(item.Count);

#line default
#line hidden
            EndContext();
            BeginContext(2064, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(2068, 10, false);
#line 52 "C:\Users\Cavid\Desktop\FrontToBack\FrontToBack\Areas\AdminF\Views\Sales\Index.cshtml"
                                                                               Write(item.Price);

#line default
#line hidden
            EndContext();
            BeginContext(2078, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 53 "C:\Users\Cavid\Desktop\FrontToBack\FrontToBack\Areas\AdminF\Views\Sales\Index.cshtml"
                                        }

#line default
#line hidden
            BeginContext(2128, 117, true);
            WriteLiteral("                                    </ul>\r\n                                </td>\r\n                            </tr>\r\n");
            EndContext();
#line 57 "C:\Users\Cavid\Desktop\FrontToBack\FrontToBack\Areas\AdminF\Views\Sales\Index.cshtml"
                            }

#line default
#line hidden
            BeginContext(2276, 150, true);
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SaleVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591