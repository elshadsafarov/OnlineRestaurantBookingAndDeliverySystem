#pragma checksum "C:\Users\baku\source\repos\OnlineRestaurantBookingAndDeliverySystem\OnlineRestaurantBookingSystem\OnlineRestaurantBookingSystem\Views\Account\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "63364791d895a6ff235b88c835067100a82fcd66"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Login), @"mvc.1.0.view", @"/Views/Account/Login.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Login.cshtml", typeof(AspNetCore.Views_Account_Login))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63364791d895a6ff235b88c835067100a82fcd66", @"/Views/Account/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe5c863558d88dc9aa0eaeec72022a9edf387b12", @"/_ViewImports.cshtml")]
    public class Views_Account_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LoginModel>
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
#line 1 "C:\Users\baku\source\repos\OnlineRestaurantBookingAndDeliverySystem\OnlineRestaurantBookingSystem\OnlineRestaurantBookingSystem\Views\Account\Login.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(46, 35, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            EndContext();
            BeginContext(81, 485, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4f454349aec941319daf3fd1bbd48d31", async() => {
                BeginContext(87, 472, true);
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Login Or Register </title>
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
            BeginContext(566, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(568, 2415, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "09e4f55037944bd79851869531e2fa6f", async() => {
                BeginContext(574, 890, true);
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
                BeginWriteAttribute("href", " href=\"", 1464, "\"", 1501, 1);
#line 38 "C:\Users\baku\source\repos\OnlineRestaurantBookingAndDeliverySystem\OnlineRestaurantBookingSystem\OnlineRestaurantBookingSystem\Views\Account\Login.cshtml"
WriteAttributeValue("", 1471, Url.Action("Login","Account"), 1471, 30, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1502, 27, true);
                WriteLiteral(" class=\"active\">Login</a><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1529, "\"", 1569, 1);
#line 38 "C:\Users\baku\source\repos\OnlineRestaurantBookingAndDeliverySystem\OnlineRestaurantBookingSystem\OnlineRestaurantBookingSystem\Views\Account\Login.cshtml"
WriteAttributeValue("", 1536, Url.Action("Register","Account"), 1536, 33, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1570, 73, true);
                WriteLiteral(">Register</a>\r\n\r\n                        </div>\r\n                        ");
                EndContext();
                BeginContext(1643, 831, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4d664a561b9445e2a1e6a921886c4ee2", async() => {
                    BeginContext(1663, 670, true);
                    WriteLiteral(@"
                            <input class=""form-control"" type=""text"" name=""UserEmail"" placeholder=""E-mail Address"" required>
                            <input class=""form-control"" type=""password"" name=""Password"" placeholder=""Password"" required>
                            <input type=""checkbox"" id=""chk1""><label for=""chk1"">Remember me</label>
                            <div class=""form-button"">
                                <button id=""submit"" type=""submit"" class=""ibtn"">Login</button> <a href=""forget2.html"">Forget password?</a>

                            </div>
                            <div class=""form-button"">
                                <a");
                    EndContext();
                    BeginWriteAttribute("href", " href=\"", 2333, "\"", 2367, 1);
#line 50 "C:\Users\baku\source\repos\OnlineRestaurantBookingAndDeliverySystem\OnlineRestaurantBookingSystem\OnlineRestaurantBookingSystem\Views\Account\Login.cshtml"
WriteAttributeValue("", 2340, Url.Action("Index","Home"), 2340, 27, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(2368, 99, true);
                    WriteLiteral(" class=\"ibtn\">Back To Main Page</a>\r\n\r\n                            </div>\r\n                        ");
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
                BeginContext(2474, 110, true);
                WriteLiteral("\r\n                        <div class=\"other-links\">\r\n                            <span>Or login with</span> <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2584, "\"", 2619, 1);
#line 55 "C:\Users\baku\source\repos\OnlineRestaurantBookingAndDeliverySystem\OnlineRestaurantBookingSystem\OnlineRestaurantBookingSystem\Views\Account\Login.cshtml"
WriteAttributeValue("", 2591, Url.Action("SignIn","Auth"), 2591, 28, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2620, 356, true);
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
            BeginContext(2983, 9, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LoginModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
