#pragma checksum "C:\Users\Cavid\Desktop\FrontToBack\FrontToBack\Areas\AdminF\Views\Users\IsActivate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d77787175e4f1c260dc800a327024c909ca85009"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminF_Views_Users_IsActivate), @"mvc.1.0.view", @"/Areas/AdminF/Views/Users/IsActivate.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/AdminF/Views/Users/IsActivate.cshtml", typeof(AspNetCore.Areas_AdminF_Views_Users_IsActivate))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d77787175e4f1c260dc800a327024c909ca85009", @"/Areas/AdminF/Views/Users/IsActivate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ef499bc641b395c15c4ec72c4f836c4ebb7b5c6", @"/Areas/AdminF/Views/_ViewImports.cshtml")]
    public class Areas_AdminF_Views_Users_IsActivate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AppUser>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Cavid\Desktop\FrontToBack\FrontToBack\Areas\AdminF\Views\Users\IsActivate.cshtml"
  
    ViewData["Title"] = "IsActivate";

#line default
#line hidden
            BeginContext(62, 322, true);
            WriteLiteral(@"
    <div class=""row"">
        <div class=""col-md-12 d-flex align-items-stretch"">
            <div class=""row"">
                <div class=""col-md-12 grid-margin stretch-card"">
                    <div class=""card"">
                        <div class=""card-body"">
                            <h4 class=""card-title"">");
            EndContext();
            BeginContext(385, 14, false);
#line 12 "C:\Users\Cavid\Desktop\FrontToBack\FrontToBack\Areas\AdminF\Views\Users\IsActivate.cshtml"
                                              Write(Model.Fullname);

#line default
#line hidden
            EndContext();
            BeginContext(399, 72, true);
            WriteLiteral("</h4>\r\n                            <p>\r\n                                ");
            EndContext();
            BeginContext(472, 11, false);
#line 14 "C:\Users\Cavid\Desktop\FrontToBack\FrontToBack\Areas\AdminF\Views\Users\IsActivate.cshtml"
                           Write(Model.Email);

#line default
#line hidden
            EndContext();
            BeginContext(483, 101, true);
            WriteLiteral("\r\n                            </p>\r\n                            <p>\r\n                                ");
            EndContext();
            BeginContext(585, 14, false);
#line 17 "C:\Users\Cavid\Desktop\FrontToBack\FrontToBack\Areas\AdminF\Views\Users\IsActivate.cshtml"
                           Write(Model.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(599, 271, true);
            WriteLiteral(@"
                            </p>
                            <p class=""text-danger"">Əminsinizmi???</p>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""row mt-3"">
            ");
            EndContext();
            BeginContext(870, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "974024a68e5d46fab6b1a4149c5f1e9c", async() => {
                BeginContext(913, 7, true);
                WriteLiteral("Go Back");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(924, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(938, 517, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d8bce67c9c34abd870470bbcfb5033a", async() => {
                BeginContext(958, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 28 "C:\Users\Cavid\Desktop\FrontToBack\FrontToBack\Areas\AdminF\Views\Users\IsActivate.cshtml"
                 if (Model.IsActivated)
                {

#line default
#line hidden
                BeginContext(1020, 167, true);
                WriteLiteral("                    <input type=\"hidden\" name=\"IsActivated\" value=\"false\" />\r\n                    <button type=\"submit\" class=\"btn btn-danger ml-2\">Disabled</button>\r\n");
                EndContext();
#line 32 "C:\Users\Cavid\Desktop\FrontToBack\FrontToBack\Areas\AdminF\Views\Users\IsActivate.cshtml"
                }
                else
                {

#line default
#line hidden
                BeginContext(1247, 168, true);
                WriteLiteral("                    <input type=\"hidden\" name=\"IsActivated\" value=\"true\" />\r\n                    <button type=\"submit\" class=\"btn btn-success ml-2\">Activated</button>\r\n");
                EndContext();
#line 37 "C:\Users\Cavid\Desktop\FrontToBack\FrontToBack\Areas\AdminF\Views\Users\IsActivate.cshtml"
                }

#line default
#line hidden
                BeginContext(1434, 14, true);
                WriteLiteral("\r\n            ");
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
            BeginContext(1455, 20, true);
            WriteLiteral("\r\n        </div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AppUser> Html { get; private set; }
    }
}
#pragma warning restore 1591