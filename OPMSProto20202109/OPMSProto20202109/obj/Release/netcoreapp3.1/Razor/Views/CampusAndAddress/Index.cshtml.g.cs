#pragma checksum "C:\Users\Mikael\Documents\GitHub\CS403MikaelHintonOPMS\OPMSProto20202109\OPMSProto20202109\Views\CampusAndAddress\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "19dbe3107ddb5c7498430ace66fe841d1ea0ffa2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CampusAndAddress_Index), @"mvc.1.0.view", @"/Views/CampusAndAddress/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19dbe3107ddb5c7498430ace66fe841d1ea0ffa2", @"/Views/CampusAndAddress/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f09680c5c98c126748aa87a1b3ae9ff806ea119", @"/Views/_ViewImports.cshtml")]
    public class Views_CampusAndAddress_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<OPMSProto20202109.Models.ViewModels.CampusAndAddressViewModels>>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "19dbe3107ddb5c7498430ace66fe841d1ea0ffa24497", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "19dbe3107ddb5c7498430ace66fe841d1ea0ffa24759", async() => {
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
#line 17 "C:\Users\Mikael\Documents\GitHub\CS403MikaelHintonOPMS\OPMSProto20202109\OPMSProto20202109\Views\CampusAndAddress\Index.cshtml"
  
    ViewBag.Title = "CampusWithAddress";

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n<div id=\"text-container\">\r\n    <h2>Campus With Address</h2>\r\n    <p>\r\n        ");
#nullable restore
#line 24 "C:\Users\Mikael\Documents\GitHub\CS403MikaelHintonOPMS\OPMSProto20202109\OPMSProto20202109\Views\CampusAndAddress\Index.cshtml"
   Write(Html.ActionLink("Create New Campus", "Create", "Addresses"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <br />\r\n        ");
#nullable restore
#line 26 "C:\Users\Mikael\Documents\GitHub\CS403MikaelHintonOPMS\OPMSProto20202109\OPMSProto20202109\Views\CampusAndAddress\Index.cshtml"
   Write(Html.ActionLink("Edit Name & Active", "Index", "Campus"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <br />\r\n        ");
#nullable restore
#line 28 "C:\Users\Mikael\Documents\GitHub\CS403MikaelHintonOPMS\OPMSProto20202109\OPMSProto20202109\Views\CampusAndAddress\Index.cshtml"
   Write(Html.ActionLink("Edit Addresses", "Index", "Addresses"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </p>\r\n    <table class=\"table\">\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 33 "C:\Users\Mikael\Documents\GitHub\CS403MikaelHintonOPMS\OPMSProto20202109\OPMSProto20202109\Views\CampusAndAddress\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CampusName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 36 "C:\Users\Mikael\Documents\GitHub\CS403MikaelHintonOPMS\OPMSProto20202109\OPMSProto20202109\Views\CampusAndAddress\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Active));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 39 "C:\Users\Mikael\Documents\GitHub\CS403MikaelHintonOPMS\OPMSProto20202109\OPMSProto20202109\Views\CampusAndAddress\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 42 "C:\Users\Mikael\Documents\GitHub\CS403MikaelHintonOPMS\OPMSProto20202109\OPMSProto20202109\Views\CampusAndAddress\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.State));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 45 "C:\Users\Mikael\Documents\GitHub\CS403MikaelHintonOPMS\OPMSProto20202109\OPMSProto20202109\Views\CampusAndAddress\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.StreetAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 48 "C:\Users\Mikael\Documents\GitHub\CS403MikaelHintonOPMS\OPMSProto20202109\OPMSProto20202109\Views\CampusAndAddress\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ZIP));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n");
            WriteLiteral("            <th></th>\r\n        </tr>\r\n\r\n");
#nullable restore
#line 56 "C:\Users\Mikael\Documents\GitHub\CS403MikaelHintonOPMS\OPMSProto20202109\OPMSProto20202109\Views\CampusAndAddress\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 60 "C:\Users\Mikael\Documents\GitHub\CS403MikaelHintonOPMS\OPMSProto20202109\OPMSProto20202109\Views\CampusAndAddress\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.CampusName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 63 "C:\Users\Mikael\Documents\GitHub\CS403MikaelHintonOPMS\OPMSProto20202109\OPMSProto20202109\Views\CampusAndAddress\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Active));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 66 "C:\Users\Mikael\Documents\GitHub\CS403MikaelHintonOPMS\OPMSProto20202109\OPMSProto20202109\Views\CampusAndAddress\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 69 "C:\Users\Mikael\Documents\GitHub\CS403MikaelHintonOPMS\OPMSProto20202109\OPMSProto20202109\Views\CampusAndAddress\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.State));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 72 "C:\Users\Mikael\Documents\GitHub\CS403MikaelHintonOPMS\OPMSProto20202109\OPMSProto20202109\Views\CampusAndAddress\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.StreetAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 75 "C:\Users\Mikael\Documents\GitHub\CS403MikaelHintonOPMS\OPMSProto20202109\OPMSProto20202109\Views\CampusAndAddress\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.ZIP));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n");
            WriteLiteral("            </tr>\r\n");
#nullable restore
#line 81 "C:\Users\Mikael\Documents\GitHub\CS403MikaelHintonOPMS\OPMSProto20202109\OPMSProto20202109\Views\CampusAndAddress\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<OPMSProto20202109.Models.ViewModels.CampusAndAddressViewModels>> Html { get; private set; }
    }
}
#pragma warning restore 1591
