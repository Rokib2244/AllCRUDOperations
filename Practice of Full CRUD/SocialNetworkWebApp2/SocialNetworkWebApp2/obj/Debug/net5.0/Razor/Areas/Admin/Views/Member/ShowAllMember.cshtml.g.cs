#pragma checksum "F:\Practice of Full CRUD\SocialNetworkWebApp2\SocialNetworkWebApp2\Areas\Admin\Views\Member\ShowAllMember.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "718de1dbe959a5e2b83febba540d0bb18ba5cc8c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Member_ShowAllMember), @"mvc.1.0.view", @"/Areas/Admin/Views/Member/ShowAllMember.cshtml")]
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
#line 1 "F:\Practice of Full CRUD\SocialNetworkWebApp2\SocialNetworkWebApp2\Areas\Admin\Views\_ViewImports.cshtml"
using SocialNetworkWebApp2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Practice of Full CRUD\SocialNetworkWebApp2\SocialNetworkWebApp2\Areas\Admin\Views\_ViewImports.cshtml"
using SocialNetworkWebApp2.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\Practice of Full CRUD\SocialNetworkWebApp2\SocialNetworkWebApp2\Areas\Admin\Views\_ViewImports.cshtml"
using SocialNetworkWebApp2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"718de1dbe959a5e2b83febba540d0bb18ba5cc8c", @"/Areas/Admin/Views/Member/ShowAllMember.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6fc7498a3dd475e89ea76a68149a8983966ae9bd", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Member_ShowAllMember : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MemberListModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/plugins/datatables-bs4/css/dataTables.bootstrap4.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/plugins/datatables/jquery.dataTables.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/plugins/datatables-bs4/js/dataTables.bootstrap4.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "F:\Practice of Full CRUD\SocialNetworkWebApp2\SocialNetworkWebApp2\Areas\Admin\Views\Member\ShowAllMember.cshtml"
  
    ViewData["Title"] = "ShowAllMember";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "718de1dbe959a5e2b83febba540d0bb18ba5cc8c5397", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
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
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "718de1dbe959a5e2b83febba540d0bb18ba5cc8c6696", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "718de1dbe959a5e2b83febba540d0bb18ba5cc8c7795", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <script>\r\n        $(function () {\r\n            (\"#memberTable\").DataTable();\r\n        });\r\n    </script>\r\n");
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral(@"<section class=""content-header"">
    <div class=""container-fluid"">
        <div class=""row mb-2"">
            <div class=""col-sm-6"">
                <h1>List Of All Members</h1>
            </div>

        </div>
    </div>
</section>
<section>
    <div class=""content"">
        <div class=""row"">
            <div class=""col-12"">
                <div class=""card-header""> All Available Members</div>
                <div class=""card-body"">
                    <table id=""memberTable"" class=""table table-bordered table-hover"">
                        <thead>
                            <tr>
                                <th>Name</th>
                                <th>Date Of  Birth</th>
                                <th>Address</th>
                            </tr>
                        </thead>
                        <tbody>

");
#nullable restore
#line 97 "F:\Practice of Full CRUD\SocialNetworkWebApp2\SocialNetworkWebApp2\Areas\Admin\Views\Member\ShowAllMember.cshtml"
                             foreach (var member in Model.Members)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 100 "F:\Practice of Full CRUD\SocialNetworkWebApp2\SocialNetworkWebApp2\Areas\Admin\Views\Member\ShowAllMember.cshtml"
                       Write(member.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 101 "F:\Practice of Full CRUD\SocialNetworkWebApp2\SocialNetworkWebApp2\Areas\Admin\Views\Member\ShowAllMember.cshtml"
                       Write(member.DateOfBirth);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 102 "F:\Practice of Full CRUD\SocialNetworkWebApp2\SocialNetworkWebApp2\Areas\Admin\Views\Member\ShowAllMember.cshtml"
                       Write(member.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n                            <button type=\"submit\" class=\"btn btn-info btn-sm\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3744, "\"", 3808, 5);
            WriteAttributeValue("", 3754, "window.location.href", 3754, 20, true);
            WriteAttributeValue(" ", 3774, "=", 3775, 2, true);
            WriteAttributeValue(" ", 3776, "\'/Admin/Member/Edit/", 3777, 21, true);
#nullable restore
#line 104 "F:\Practice of Full CRUD\SocialNetworkWebApp2\SocialNetworkWebApp2\Areas\Admin\Views\Member\ShowAllMember.cshtml"
WriteAttributeValue("", 3797, member.Id, 3797, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3807, "\'", 3807, 1, true);
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=", 3809, "", 3826, 1);
#nullable restore
#line 104 "F:\Practice of Full CRUD\SocialNetworkWebApp2\SocialNetworkWebApp2\Areas\Admin\Views\Member\ShowAllMember.cshtml"
WriteAttributeValue("", 3816, member.Id, 3816, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                <i class=""fas fa-pencil-alt"">
                                </i>
                                Edit
                            </button>
                            <button type=""submit"" class=""btn btn-danger btn-sm show-bs-modal"" href=""#"" data-id='${data}' value='${data}'>
                                <i class=""fas fa-trash"">
                                </i>
                                Delete
                            </button>

                        </td>
                    </tr>
");
#nullable restore
#line 117 "F:\Practice of Full CRUD\SocialNetworkWebApp2\SocialNetworkWebApp2\Areas\Admin\Views\Member\ShowAllMember.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </tbody>\r\n                    </table>\r\n");
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MemberListModel> Html { get; private set; }
    }
}
#pragma warning restore 1591