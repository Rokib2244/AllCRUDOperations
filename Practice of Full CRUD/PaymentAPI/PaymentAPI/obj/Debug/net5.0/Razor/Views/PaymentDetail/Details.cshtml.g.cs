#pragma checksum "E:\Practice of Full CRUD\PaymentAPI\PaymentAPI\Views\PaymentDetail\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a10125bf8c084e004d2d8973f5d5c2225692747"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PaymentDetail_Details), @"mvc.1.0.view", @"/Views/PaymentDetail/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a10125bf8c084e004d2d8973f5d5c2225692747", @"/Views/PaymentDetail/Details.cshtml")]
    public class Views_PaymentDetail_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PaymentAPI.Models.PaymentDetail>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\Practice of Full CRUD\PaymentAPI\PaymentAPI\Views\PaymentDetail\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>PaymentDetail</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "E:\Practice of Full CRUD\PaymentAPI\PaymentAPI\Views\PaymentDetail\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CardOwnerName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "E:\Practice of Full CRUD\PaymentAPI\PaymentAPI\Views\PaymentDetail\Details.cshtml"
       Write(Html.DisplayFor(model => model.CardOwnerName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "E:\Practice of Full CRUD\PaymentAPI\PaymentAPI\Views\PaymentDetail\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CardNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "E:\Practice of Full CRUD\PaymentAPI\PaymentAPI\Views\PaymentDetail\Details.cshtml"
       Write(Html.DisplayFor(model => model.CardNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "E:\Practice of Full CRUD\PaymentAPI\PaymentAPI\Views\PaymentDetail\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ExpirationDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "E:\Practice of Full CRUD\PaymentAPI\PaymentAPI\Views\PaymentDetail\Details.cshtml"
       Write(Html.DisplayFor(model => model.ExpirationDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "E:\Practice of Full CRUD\PaymentAPI\PaymentAPI\Views\PaymentDetail\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SecurityCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "E:\Practice of Full CRUD\PaymentAPI\PaymentAPI\Views\PaymentDetail\Details.cshtml"
       Write(Html.DisplayFor(model => model.SecurityCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1104, "\"", 1141, 1);
#nullable restore
#line 40 "E:\Practice of Full CRUD\PaymentAPI\PaymentAPI\Views\PaymentDetail\Details.cshtml"
WriteAttributeValue("", 1119, Model.PaymentDetailId, 1119, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n    <a asp-action=\"Index\">Back to List</a>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PaymentAPI.Models.PaymentDetail> Html { get; private set; }
    }
}
#pragma warning restore 1591
