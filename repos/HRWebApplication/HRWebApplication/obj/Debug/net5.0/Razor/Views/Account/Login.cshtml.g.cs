#pragma checksum "C:\Users\whizt\source\repos\HRWebApplication\HRWebApplication\Views\Account\Login.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "b970f7b82894caaa3bf30a67a3f9e74447e0f5f6a3a4e74bb2bca3825bd1ef7e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Login), @"mvc.1.0.view", @"/Views/Account/Login.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\whizt\source\repos\HRWebApplication\HRWebApplication\Views\_ViewImports.cshtml"
using HRWebApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\whizt\source\repos\HRWebApplication\HRWebApplication\Views\_ViewImports.cshtml"
using HRWebApplication.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"b970f7b82894caaa3bf30a67a3f9e74447e0f5f6a3a4e74bb2bca3825bd1ef7e", @"/Views/Account/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"683edcdf231ba98dc484d63d94a5740bd3bebc556c5dabe305732db6fec3786d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Account_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("user"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "C:\Users\whizt\source\repos\HRWebApplication\HRWebApplication\Views\Account\Login.cshtml"
  
    ViewData["Title"]="Login";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""bg-gradient-primary"">

    <div class=""container"">

        <!-- Outer Row -->
        <div class=""row justify-content-center"">

            <div class=""col-xl-10 col-lg-12 col-md-9"">

                <div class=""card o-hidden border-0 shadow-lg my-5"">
                    <div class=""card-body p-0"">
                        <!-- Nested Row within Card Body -->
                        <div class=""row"">
                            <div class=""col-lg-6 d-none d-lg-block bg-login-image""></div>
                            <div class=""col-lg-6"">
                                <div class=""p-5"">
                                    <div class=""text-center"">
                                        <h1 class=""h4 text-gray-900 mb-4"">Welcome Back!</h1>
                                    </div>
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b970f7b82894caaa3bf30a67a3f9e74447e0f5f6a3a4e74bb2bca3825bd1ef7e4872", async() => {
                WriteLiteral(@"
                                        <div class=""form-group"">
                                            <input type=""email"" class=""form-control form-control-user""
                                                   id=""exampleInputEmail"" aria-describedby=""emailHelp""
                                                   placeholder=""Enter Email Address..."">
                                        </div>
                                        <div class=""form-group"">
                                            <input type=""password"" class=""form-control form-control-user""
                                                   id=""exampleInputPassword"" placeholder=""Password"">
                                        </div>
                                        <div class=""form-group"">
                                            <div class=""custom-control custom-checkbox small"">
                                                <input type=""checkbox"" class=""custom-control-input"" id=""customCheck"">
      ");
                WriteLiteral(@"                                          <label class=""custom-control-label"" for=""customCheck"">
                                                    Remember
                                                    Me
                                                </label>
                                            </div>
                                        </div>
                                        <a href=""index.html"" class=""btn btn-primary btn-user btn-block"">
                                            Login
                                        </a>
                                        <hr>
                                        <a href=""index.html"" class=""btn btn-google btn-user btn-block"">
                                            <i class=""fab fa-google fa-fw""></i> Login with Google
                                        </a>
                                        <a href=""index.html"" class=""btn btn-facebook btn-user btn-block"">
                                            ");
                WriteLiteral("<i class=\"fab fa-facebook-f fa-fw\"></i> Login with Facebook\r\n                                        </a>\r\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                    <hr>
                                    <div class=""text-center"">
                                        <a class=""small"" href=""forgot-password.html"">Forgot Password?</a>
                                    </div>
                                    <div class=""text-center"">
                                        <a class=""small"" href=""register.html"">Create an Account!</a>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

            </div>

        </div>

    </div>

 </div>
");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
