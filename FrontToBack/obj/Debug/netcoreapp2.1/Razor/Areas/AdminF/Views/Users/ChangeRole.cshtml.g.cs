#pragma checksum "C:\Users\Cavid\Desktop\FrontToBack\FrontToBack\Areas\AdminF\Views\Users\ChangeRole.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e09433b0442b6e728754f1907b1c46b9662261c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminF_Views_Users_ChangeRole), @"mvc.1.0.view", @"/Areas/AdminF/Views/Users/ChangeRole.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/AdminF/Views/Users/ChangeRole.cshtml", typeof(AspNetCore.Areas_AdminF_Views_Users_ChangeRole))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e09433b0442b6e728754f1907b1c46b9662261c", @"/Areas/AdminF/Views/Users/ChangeRole.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ef499bc641b395c15c4ec72c4f836c4ebb7b5c6", @"/Areas/AdminF/Views/_ViewImports.cshtml")]
    public class Areas_AdminF_Views_Users_ChangeRole : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Cavid\Desktop\FrontToBack\FrontToBack\Areas\AdminF\Views\Users\ChangeRole.cshtml"
  
    ViewData["Title"] = "ChangeRole";

#line default
#line hidden
            BeginContext(61, 322, true);
            WriteLiteral(@"
    <div class=""row"">
        <div class=""col-md-12 d-flex align-items-stretch"">
            <div class=""row"">
                <div class=""col-md-12 grid-margin stretch-card"">
                    <div class=""card"">
                        <div class=""card-body"">
                            <h4 class=""card-title"">");
            EndContext();
            BeginContext(384, 14, false);
#line 12 "C:\Users\Cavid\Desktop\FrontToBack\FrontToBack\Areas\AdminF\Views\Users\ChangeRole.cshtml"
                                              Write(Model.Fullname);

#line default
#line hidden
            EndContext();
            BeginContext(398, 72, true);
            WriteLiteral("</h4>\r\n                            <p>\r\n                                ");
            EndContext();
            BeginContext(471, 11, false);
#line 14 "C:\Users\Cavid\Desktop\FrontToBack\FrontToBack\Areas\AdminF\Views\Users\ChangeRole.cshtml"
                           Write(Model.Email);

#line default
#line hidden
            EndContext();
            BeginContext(482, 101, true);
            WriteLiteral("\r\n                            </p>\r\n                            <p>\r\n                                ");
            EndContext();
            BeginContext(584, 14, false);
#line 17 "C:\Users\Cavid\Desktop\FrontToBack\FrontToBack\Areas\AdminF\Views\Users\ChangeRole.cshtml"
                           Write(Model.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(598, 252, true);
            WriteLiteral("\r\n                            </p>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n            \r\n        <div class=\"row mt-3\">\r\n            <div class=\"col-12\">\r\n                ");
            EndContext();
            BeginContext(850, 790, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bdb7d8b2016f4d3589fe8563a550b994", async() => {
                BeginContext(870, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 28 "C:\Users\Cavid\Desktop\FrontToBack\FrontToBack\Areas\AdminF\Views\Users\ChangeRole.cshtml"
                     foreach (string item in Model.Roles)
                    {
                        if (item == Model.Role)
                        {

#line default
#line hidden
                BeginContext(1030, 125, true);
                WriteLiteral("                            <div class=\"form-group\">\r\n                                <input type=\"radio\" name=\"Role\" checked");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1155, "\"", 1168, 1);
#line 33 "C:\Users\Cavid\Desktop\FrontToBack\FrontToBack\Areas\AdminF\Views\Users\ChangeRole.cshtml"
WriteAttributeValue("", 1163, item, 1163, 5, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1169, 2, true);
                WriteLiteral("/>");
                EndContext();
                BeginContext(1172, 4, false);
#line 33 "C:\Users\Cavid\Desktop\FrontToBack\FrontToBack\Areas\AdminF\Views\Users\ChangeRole.cshtml"
                                                                                  Write(item);

#line default
#line hidden
                EndContext();
                BeginContext(1176, 38, true);
                WriteLiteral("\r\n                            </div>\r\n");
                EndContext();
#line 35 "C:\Users\Cavid\Desktop\FrontToBack\FrontToBack\Areas\AdminF\Views\Users\ChangeRole.cshtml"
                        }
                        else
                        {

#line default
#line hidden
                BeginContext(1298, 117, true);
                WriteLiteral("                            <div class=\"form-group\">\r\n                                <input type=\"radio\" name=\"Role\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1415, "\"", 1428, 1);
#line 39 "C:\Users\Cavid\Desktop\FrontToBack\FrontToBack\Areas\AdminF\Views\Users\ChangeRole.cshtml"
WriteAttributeValue("", 1423, item, 1423, 5, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1429, 2, true);
                WriteLiteral("/>");
                EndContext();
                BeginContext(1432, 4, false);
#line 39 "C:\Users\Cavid\Desktop\FrontToBack\FrontToBack\Areas\AdminF\Views\Users\ChangeRole.cshtml"
                                                                          Write(item);

#line default
#line hidden
                EndContext();
                BeginContext(1436, 38, true);
                WriteLiteral("\r\n                            </div>\r\n");
                EndContext();
#line 41 "C:\Users\Cavid\Desktop\FrontToBack\FrontToBack\Areas\AdminF\Views\Users\ChangeRole.cshtml"
                        }
                    }

#line default
#line hidden
                BeginContext(1524, 109, true);
                WriteLiteral("                    <button type=\"submit\" class=\"btn btn-primary ml-2\">Change Role</button>\r\n                ");
                EndContext();
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
            EndContext();
            BeginContext(1640, 81, true);
            WriteLiteral("\r\n                </div>\r\n            <div class=\"col-12 mt-5\">\r\n                ");
            EndContext();
            BeginContext(1721, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "adebc55ca07440ebb584ea3cd25e2877", async() => {
                BeginContext(1764, 7, true);
                WriteLiteral("Go Back");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1775, 44, true);
            WriteLiteral("\r\n            </div>\r\n            </div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserVM> Html { get; private set; }
    }
}
#pragma warning restore 1591