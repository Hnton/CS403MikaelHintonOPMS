#pragma checksum "C:\Users\Mikael\Documents\GitHub\CS403MikaelHintonOPMS\OPMSProto20202109\OPMSProto20202109\Views\CampusAndAddress\CreateCampusAndAddress.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "30309be8c39b059add28fd29c5ad9d6948d4eee2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CampusAndAddress_CreateCampusAndAddress), @"mvc.1.0.view", @"/Views/CampusAndAddress/CreateCampusAndAddress.cshtml")]
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
#line 1 "C:\Users\Mikael\Documents\GitHub\CS403MikaelHintonOPMS\OPMSProto20202109\OPMSProto20202109\Views\_ViewImports.cshtml"
using OPMSProto20202109;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mikael\Documents\GitHub\CS403MikaelHintonOPMS\OPMSProto20202109\OPMSProto20202109\Views\_ViewImports.cshtml"
using OPMSProto20202109.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30309be8c39b059add28fd29c5ad9d6948d4eee2", @"/Views/CampusAndAddress/CreateCampusAndAddress.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f09680c5c98c126748aa87a1b3ae9ff806ea119", @"/Views/_ViewImports.cshtml")]
    public class Views_CampusAndAddress_CreateCampusAndAddress : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OPMSProto20202109.Models.ViewModels.CampusWithAddressViewModels>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Content/Site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "30309be8c39b059add28fd29c5ad9d6948d4eee24570", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "30309be8c39b059add28fd29c5ad9d6948d4eee24832", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
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
            WriteLiteral("\r\n");
#nullable restore
#line 12 "C:\Users\Mikael\Documents\GitHub\CS403MikaelHintonOPMS\OPMSProto20202109\OPMSProto20202109\Views\CampusAndAddress\CreateCampusAndAddress.cshtml"
  
    ViewBag.Title = "CreateCampusAndAddress";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n<div id=\"text-container\">\r\n    <h2>Create Campus And Address</h2>\r\n\r\n");
#nullable restore
#line 20 "C:\Users\Mikael\Documents\GitHub\CS403MikaelHintonOPMS\OPMSProto20202109\OPMSProto20202109\Views\CampusAndAddress\CreateCampusAndAddress.cshtml"
     using (Html.BeginForm())
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\Mikael\Documents\GitHub\CS403MikaelHintonOPMS\OPMSProto20202109\OPMSProto20202109\Views\CampusAndAddress\CreateCampusAndAddress.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"form-horizontal\">\r\n");
            WriteLiteral("            <hr />\r\n            ");
#nullable restore
#line 27 "C:\Users\Mikael\Documents\GitHub\CS403MikaelHintonOPMS\OPMSProto20202109\OPMSProto20202109\Views\CampusAndAddress\CreateCampusAndAddress.cshtml"
       Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 29 "C:\Users\Mikael\Documents\GitHub\CS403MikaelHintonOPMS\OPMSProto20202109\OPMSProto20202109\Views\CampusAndAddress\CreateCampusAndAddress.cshtml"
           Write(Html.LabelFor(model => model.CampusName, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 31 "C:\Users\Mikael\Documents\GitHub\CS403MikaelHintonOPMS\OPMSProto20202109\OPMSProto20202109\Views\CampusAndAddress\CreateCampusAndAddress.cshtml"
               Write(Html.EditorFor(model => model.CampusName, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 32 "C:\Users\Mikael\Documents\GitHub\CS403MikaelHintonOPMS\OPMSProto20202109\OPMSProto20202109\Views\CampusAndAddress\CreateCampusAndAddress.cshtml"
               Write(Html.ValidationMessageFor(model => model.CampusName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 37 "C:\Users\Mikael\Documents\GitHub\CS403MikaelHintonOPMS\OPMSProto20202109\OPMSProto20202109\Views\CampusAndAddress\CreateCampusAndAddress.cshtml"
           Write(Html.LabelFor(model => model.Active, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    <div class=\"checkbox\">\r\n                        ");
#nullable restore
#line 40 "C:\Users\Mikael\Documents\GitHub\CS403MikaelHintonOPMS\OPMSProto20202109\OPMSProto20202109\Views\CampusAndAddress\CreateCampusAndAddress.cshtml"
                   Write(Html.EditorFor(model => model.Active));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 41 "C:\Users\Mikael\Documents\GitHub\CS403MikaelHintonOPMS\OPMSProto20202109\OPMSProto20202109\Views\CampusAndAddress\CreateCampusAndAddress.cshtml"
                   Write(Html.ValidationMessageFor(model => model.Active, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 47 "C:\Users\Mikael\Documents\GitHub\CS403MikaelHintonOPMS\OPMSProto20202109\OPMSProto20202109\Views\CampusAndAddress\CreateCampusAndAddress.cshtml"
           Write(Html.LabelFor(model => model.City, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 49 "C:\Users\Mikael\Documents\GitHub\CS403MikaelHintonOPMS\OPMSProto20202109\OPMSProto20202109\Views\CampusAndAddress\CreateCampusAndAddress.cshtml"
               Write(Html.EditorFor(model => model.City, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 50 "C:\Users\Mikael\Documents\GitHub\CS403MikaelHintonOPMS\OPMSProto20202109\OPMSProto20202109\Views\CampusAndAddress\CreateCampusAndAddress.cshtml"
               Write(Html.ValidationMessageFor(model => model.City, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 55 "C:\Users\Mikael\Documents\GitHub\CS403MikaelHintonOPMS\OPMSProto20202109\OPMSProto20202109\Views\CampusAndAddress\CreateCampusAndAddress.cshtml"
           Write(Html.LabelFor(model => model.State, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 57 "C:\Users\Mikael\Documents\GitHub\CS403MikaelHintonOPMS\OPMSProto20202109\OPMSProto20202109\Views\CampusAndAddress\CreateCampusAndAddress.cshtml"
               Write(Html.EditorFor(model => model.State, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 58 "C:\Users\Mikael\Documents\GitHub\CS403MikaelHintonOPMS\OPMSProto20202109\OPMSProto20202109\Views\CampusAndAddress\CreateCampusAndAddress.cshtml"
               Write(Html.ValidationMessageFor(model => model.State, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 63 "C:\Users\Mikael\Documents\GitHub\CS403MikaelHintonOPMS\OPMSProto20202109\OPMSProto20202109\Views\CampusAndAddress\CreateCampusAndAddress.cshtml"
           Write(Html.LabelFor(model => model.StreetAddress, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 65 "C:\Users\Mikael\Documents\GitHub\CS403MikaelHintonOPMS\OPMSProto20202109\OPMSProto20202109\Views\CampusAndAddress\CreateCampusAndAddress.cshtml"
               Write(Html.EditorFor(model => model.StreetAddress, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 66 "C:\Users\Mikael\Documents\GitHub\CS403MikaelHintonOPMS\OPMSProto20202109\OPMSProto20202109\Views\CampusAndAddress\CreateCampusAndAddress.cshtml"
               Write(Html.ValidationMessageFor(model => model.StreetAddress, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 71 "C:\Users\Mikael\Documents\GitHub\CS403MikaelHintonOPMS\OPMSProto20202109\OPMSProto20202109\Views\CampusAndAddress\CreateCampusAndAddress.cshtml"
           Write(Html.LabelFor(model => model.ZIP, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 73 "C:\Users\Mikael\Documents\GitHub\CS403MikaelHintonOPMS\OPMSProto20202109\OPMSProto20202109\Views\CampusAndAddress\CreateCampusAndAddress.cshtml"
               Write(Html.EditorFor(model => model.ZIP, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 74 "C:\Users\Mikael\Documents\GitHub\CS403MikaelHintonOPMS\OPMSProto20202109\OPMSProto20202109\Views\CampusAndAddress\CreateCampusAndAddress.cshtml"
               Write(Html.ValidationMessageFor(model => model.ZIP, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"form-group\" style=\"display:none\">\r\n                ");
#nullable restore
#line 79 "C:\Users\Mikael\Documents\GitHub\CS403MikaelHintonOPMS\OPMSProto20202109\OPMSProto20202109\Views\CampusAndAddress\CreateCampusAndAddress.cshtml"
           Write(Html.LabelFor(model => model.TimeStamp, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 81 "C:\Users\Mikael\Documents\GitHub\CS403MikaelHintonOPMS\OPMSProto20202109\OPMSProto20202109\Views\CampusAndAddress\CreateCampusAndAddress.cshtml"
               Write(Html.EditorFor(model => model.TimeStamp, new { htmlAttributes = new { @class = "form-control", Value = DateTime.Now } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 82 "C:\Users\Mikael\Documents\GitHub\CS403MikaelHintonOPMS\OPMSProto20202109\OPMSProto20202109\Views\CampusAndAddress\CreateCampusAndAddress.cshtml"
               Write(Html.ValidationMessageFor(model => model.TimeStamp, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>
            </div>

            <div class=""form-group"">
                <div class=""col-md-offset-2 col-md-10"">
                    <input type=""submit"" value=""Create"" class=""btn btn-default"" />
                </div>
            </div>
        </div>
");
#nullable restore
#line 92 "C:\Users\Mikael\Documents\GitHub\CS403MikaelHintonOPMS\OPMSProto20202109\OPMSProto20202109\Views\CampusAndAddress\CreateCampusAndAddress.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div>\r\n        ");
#nullable restore
#line 95 "C:\Users\Mikael\Documents\GitHub\CS403MikaelHintonOPMS\OPMSProto20202109\OPMSProto20202109\Views\CampusAndAddress\CreateCampusAndAddress.cshtml"
   Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OPMSProto20202109.Models.ViewModels.CampusWithAddressViewModels> Html { get; private set; }
    }
}
#pragma warning restore 1591
