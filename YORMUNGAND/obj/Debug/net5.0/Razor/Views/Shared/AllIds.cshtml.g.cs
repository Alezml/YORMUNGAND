#pragma checksum "C:\Users\AlVaKuznetsov\Desktop\WEB\WEBPILOT\YORMUNGAND\YORMUNGAND\Views\Shared\AllIds.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae01bd5ed353d907e2128364d6e8c1f31fd0cc9b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_AllIds), @"mvc.1.0.view", @"/Views/Shared/AllIds.cshtml")]
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
#line 1 "C:\Users\AlVaKuznetsov\Desktop\WEB\WEBPILOT\YORMUNGAND\YORMUNGAND\Views\_ViewImports.cshtml"
using YORMUNGAND.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\AlVaKuznetsov\Desktop\WEB\WEBPILOT\YORMUNGAND\YORMUNGAND\Views\_ViewImports.cshtml"
using YORMUNGAND.Data.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae01bd5ed353d907e2128364d6e8c1f31fd0cc9b", @"/Views/Shared/AllIds.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be0903c32324e24651997ad36486f544fa613e95", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_AllIds : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<QueueItemID>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "DetailItem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ShowDetail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""col-lg-12"" style=""margin:5px;"">
    <div style=""    background: rgba(0, 139, 140, 0.55);
        border-radius: 15px;
        text-align: center;
        box-shadow: 0 0 15px rgba(0,0,0,0.5);
    "" class=""aer"">
        <div class=""topchic"">
                <p>ID: ");
#nullable restore
#line 10 "C:\Users\AlVaKuznetsov\Desktop\WEB\WEBPILOT\YORMUNGAND\YORMUNGAND\Views\Shared\AllIds.cshtml"
                  Write(Model.QID);

#line default
#line hidden
#nullable disable
            WriteLiteral("   Филиал: ");
#nullable restore
#line 10 "C:\Users\AlVaKuznetsov\Desktop\WEB\WEBPILOT\YORMUNGAND\YORMUNGAND\Views\Shared\AllIds.cshtml"
                                       Write(Model.FILIAL);

#line default
#line hidden
#nullable disable
            WriteLiteral("   Регион: ");
#nullable restore
#line 10 "C:\Users\AlVaKuznetsov\Desktop\WEB\WEBPILOT\YORMUNGAND\YORMUNGAND\Views\Shared\AllIds.cshtml"
                                                               Write(Model.REGION);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ae01bd5ed353d907e2128364d6e8c1f31fd0cc9b5237", async() => {
                WriteLiteral("Подробнее");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-QID", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 11 "C:\Users\AlVaKuznetsov\Desktop\WEB\WEBPILOT\YORMUNGAND\YORMUNGAND\Views\Shared\AllIds.cshtml"
                                                                                                      WriteLiteral(Model.QID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["QID"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-QID", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["QID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </p>\r\n                <p>\r\n                    KEY: ");
#nullable restore
#line 14 "C:\Users\AlVaKuznetsov\Desktop\WEB\WEBPILOT\YORMUNGAND\YORMUNGAND\Views\Shared\AllIds.cshtml"
                    Write(Model.KEY);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    Test: ");
#nullable restore
#line 15 "C:\Users\AlVaKuznetsov\Desktop\WEB\WEBPILOT\YORMUNGAND\YORMUNGAND\Views\Shared\AllIds.cshtml"
                     Write(Model.CESS76INT.STATUS);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<QueueItemID> Html { get; private set; }
    }
}
#pragma warning restore 1591
