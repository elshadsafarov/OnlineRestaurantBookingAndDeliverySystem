#pragma checksum "C:\Users\baku\source\repos\OnlineRestaurantBookingAndDeliverySystem\OnlineRestaurantBookingSystem\OnlineRestaurantBookingSystem\Views\Account\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ec091c9ff76518b36c5480c75aa416b219eedd1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Register), @"mvc.1.0.view", @"/Views/Account/Register.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Register.cshtml", typeof(AspNetCore.Views_Account_Register))]
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
#line 1 "C:\Users\baku\source\repos\OnlineRestaurantBookingAndDeliverySystem\OnlineRestaurantBookingSystem\OnlineRestaurantBookingSystem\_ViewImports.cshtml"
using OnlineRestaurantBookingSystem.Models;

#line default
#line hidden
#line 2 "C:\Users\baku\source\repos\OnlineRestaurantBookingAndDeliverySystem\OnlineRestaurantBookingSystem\OnlineRestaurantBookingSystem\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 3 "C:\Users\baku\source\repos\OnlineRestaurantBookingAndDeliverySystem\OnlineRestaurantBookingSystem\OnlineRestaurantBookingSystem\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ec091c9ff76518b36c5480c75aa416b219eedd1", @"/Views/Account/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef065318b590bac90b85fe9dad515d9838526824", @"/_ViewImports.cshtml")]
    public class Views_Account_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Register>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\baku\source\repos\OnlineRestaurantBookingAndDeliverySystem\OnlineRestaurantBookingSystem\OnlineRestaurantBookingSystem\Views\Account\Register.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(44, 35, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            EndContext();
            BeginContext(79, 472, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ab6ac7f192d04e529f4443a7e529d4ff", async() => {
                BeginContext(85, 459, true);
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>iofrm</title>
    <link rel=""stylesheet"" type=""text/css"" href=""/login/css/bootstrap.min.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""/login/css/fontawesome-all.min.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""/login/css/iofrm-style.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""/login/css/iofrm-theme2.css"">
");
                EndContext();
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
            EndContext();
            BeginContext(551, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(553, 2311, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "290fe0a8f08645de9047da3d75f6d4d1", async() => {
                BeginContext(559, 902, true);
                WriteLiteral(@"
    <div class=""form-body"">
        <div class=""website-logo"">
            <a href=""index.html"">
                <div class=""logo"">
                    <img class=""logo-size"" src=""/login/images/logo-light.svg"" alt="""">
                </div>
            </a>
        </div>
        <div class=""row"">
            <div class=""img-holder"">
                <div class=""bg""></div>
                <div class=""info-holder"">
                </div>
            </div>
            
            <div class=""form-holder"">
                <div class=""form-content"" style=""height:700px;"">
                    <div class=""form-items"">
                        <h3>Get more things done with Loggin platform.</h3>
                        <p>Access to the most powerfull tool in the entire design and web industry.</p>
                        <div class=""page-links"">
                            <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1461, "\"", 1498, 1);
#line 38 "C:\Users\baku\source\repos\OnlineRestaurantBookingAndDeliverySystem\OnlineRestaurantBookingSystem\OnlineRestaurantBookingSystem\Views\Account\Register.cshtml"
WriteAttributeValue("", 1468, Url.Action("Login","Account"), 1468, 30, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1499, 12, true);
                WriteLiteral(">Login</a><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1511, "\"", 1551, 1);
#line 38 "C:\Users\baku\source\repos\OnlineRestaurantBookingAndDeliverySystem\OnlineRestaurantBookingSystem\OnlineRestaurantBookingSystem\Views\Account\Register.cshtml"
WriteAttributeValue("", 1518, Url.Action("Register","Account"), 1518, 33, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1552, 86, true);
                WriteLiteral(" class=\"active\">Register</a>\r\n                        </div>\r\n                        ");
                EndContext();
                BeginContext(1638, 715, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d6d29b7484d2432f845384e17b1f07a7", async() => {
                    BeginContext(1658, 556, true);
                    WriteLiteral(@"
                            <input class=""form-control"" type=""text"" name=""UserName"" placeholder=""User Name"" required>
                            <input class=""form-control"" type=""email"" name=""UserEmail"" placeholder=""E-mail Address"" required>
                            <input class=""form-control"" type=""password"" name=""Password"" placeholder=""Password"" required>
                            <div class=""form-button"">
                                <button id=""submit"" type=""submit"" class=""ibtn"">Register</button>
                                <a");
                    EndContext();
                    BeginWriteAttribute("href", " href=\"", 2214, "\"", 2248, 1);
#line 46 "C:\Users\baku\source\repos\OnlineRestaurantBookingAndDeliverySystem\OnlineRestaurantBookingSystem\OnlineRestaurantBookingSystem\Views\Account\Register.cshtml"
WriteAttributeValue("", 2221, Url.Action("Index","Home"), 2221, 27, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(2249, 97, true);
                    WriteLiteral(" class=\"ibtn\">Back To Main Page</a>\r\n                            </div>\r\n                        ");
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
                BeginContext(2353, 112, true);
                WriteLiteral("\r\n                        <div class=\"other-links\">\r\n                            <span>Or register with</span><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2465, "\"", 2500, 1);
#line 50 "C:\Users\baku\source\repos\OnlineRestaurantBookingAndDeliverySystem\OnlineRestaurantBookingSystem\OnlineRestaurantBookingSystem\Views\Account\Register.cshtml"
WriteAttributeValue("", 2472, Url.Action("SignIn","Auth"), 2472, 28, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2501, 356, true);
                WriteLiteral(@">Facebook</a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <script src=""/login/js/jquery.min.js""></script>
    <script src=""/login/js/popper.min.js""></script>
    <script src=""/login/js/bootstrap.min.js""></script>
    <script src=""/login/js/main.js""></script>
");
                EndContext();
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
            EndContext();
            BeginContext(2864, 9, true);
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Register> Html { get; private set; }
    }
}
#pragma warning restore 1591
