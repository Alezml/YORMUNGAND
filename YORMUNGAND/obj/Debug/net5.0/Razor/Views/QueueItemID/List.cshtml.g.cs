#pragma checksum "C:\Users\AlVaKuznetsov\Desktop\WEB\YORMUNGAND\YORMUNGAND\Views\QueueItemID\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "37dbb67e8373c586261412977c554a9d506eacf3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_QueueItemID_List), @"mvc.1.0.view", @"/Views/QueueItemID/List.cshtml")]
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
#line 1 "C:\Users\AlVaKuznetsov\Desktop\WEB\YORMUNGAND\YORMUNGAND\Views\_ViewImports.cshtml"
using YORMUNGAND.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\AlVaKuznetsov\Desktop\WEB\YORMUNGAND\YORMUNGAND\Views\_ViewImports.cshtml"
using YORMUNGAND.Data.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37dbb67e8373c586261412977c554a9d506eacf3", @"/Views/QueueItemID/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be0903c32324e24651997ad36486f544fa613e95", @"/Views/_ViewImports.cshtml")]
    public class Views_QueueItemID_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Ожидающие решения:</h1>\r\n<div class=\"row mt-2 mb-2\">\r\n");
#nullable restore
#line 3 "C:\Users\AlVaKuznetsov\Desktop\WEB\YORMUNGAND\YORMUNGAND\Views\QueueItemID\List.cshtml"
      
        foreach (QueueItemID id in Model.NewIds)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\AlVaKuznetsov\Desktop\WEB\YORMUNGAND\YORMUNGAND\Views\QueueItemID\List.cshtml"
       Write(Html.Partial("allIds", id));

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\AlVaKuznetsov\Desktop\WEB\YORMUNGAND\YORMUNGAND\Views\QueueItemID\List.cshtml"
                                       
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<h1>Решение принято:</h1>\r\n<div class=\"row mt-2 mb-2\">\r\n");
#nullable restore
#line 12 "C:\Users\AlVaKuznetsov\Desktop\WEB\YORMUNGAND\YORMUNGAND\Views\QueueItemID\List.cshtml"
      
        foreach (QueueItemID id in Model.AcceptedIds)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\AlVaKuznetsov\Desktop\WEB\YORMUNGAND\YORMUNGAND\Views\QueueItemID\List.cshtml"
       Write(Html.Partial("allIdsTo", id));

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\AlVaKuznetsov\Desktop\WEB\YORMUNGAND\YORMUNGAND\Views\QueueItemID\List.cshtml"
                                         
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<h1>Решение Исполнено:</h1>\r\n<div class=\"row mt-2 mb-2\">\r\n");
#nullable restore
#line 21 "C:\Users\AlVaKuznetsov\Desktop\WEB\YORMUNGAND\YORMUNGAND\Views\QueueItemID\List.cshtml"
      
        foreach (QueueItemID id in Model.FinishedIds)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\AlVaKuznetsov\Desktop\WEB\YORMUNGAND\YORMUNGAND\Views\QueueItemID\List.cshtml"
       Write(Html.Partial("allIdsFin", id));

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\AlVaKuznetsov\Desktop\WEB\YORMUNGAND\YORMUNGAND\Views\QueueItemID\List.cshtml"
                                          
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
