#pragma checksum "F:\Practice of Full CRUD\New CRUD\TicketBookingSystem\TicketBookingSystem\Areas\Admin\Views\Customer\GetAllCustomers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4304eb2456b2e91591aff4dd58915705b90330bf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Customer_GetAllCustomers), @"mvc.1.0.view", @"/Areas/Admin/Views/Customer/GetAllCustomers.cshtml")]
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
#line 1 "F:\Practice of Full CRUD\New CRUD\TicketBookingSystem\TicketBookingSystem\Areas\Admin\Views\_ViewImports.cshtml"
using TicketBookingSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Practice of Full CRUD\New CRUD\TicketBookingSystem\TicketBookingSystem\Areas\Admin\Views\_ViewImports.cshtml"
using TicketBookingSystem.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\Practice of Full CRUD\New CRUD\TicketBookingSystem\TicketBookingSystem\Areas\Admin\Views\_ViewImports.cshtml"
using TicketBookingSystem.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4304eb2456b2e91591aff4dd58915705b90330bf", @"/Areas/Admin/Views/Customer/GetAllCustomers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a4b104e4bde99991e2dfe975ea84f29e85bc9372", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Customer_GetAllCustomers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CustomerListModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "F:\Practice of Full CRUD\New CRUD\TicketBookingSystem\TicketBookingSystem\Areas\Admin\Views\Customer\GetAllCustomers.cshtml"
  
    ViewData["Title"] = "GetAllCustomers";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>GetAllCustomers</h1>

<!-- Main content -->
<section class=""content"">
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-12"">
                <div class=""card"">
                    <div class=""card-header"">
                        <h3 class=""card-title"">All Available Customers</h3>
                    </div>
                    <!-- /.card-header -->
                    <div class=""card-body"">
                        <table id=""products"" class=""table table-bordered table-hover"">
                            <thead>
                                <tr>
                                    <th>Customer Name</th>
                                    <th>Contact Number</th>
                                    <th>Age</th>
                                    <th>Address </th>
                                    <th style=""width:200px"">Action</th>
                                </tr>
                            </thead>
                            <tbo");
            WriteLiteral("dy>\r\n\r\n");
#nullable restore
#line 31 "F:\Practice of Full CRUD\New CRUD\TicketBookingSystem\TicketBookingSystem\Areas\Admin\Views\Customer\GetAllCustomers.cshtml"
                                         foreach (var customer in Model.Customers)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                          <tr>\r\n                                            <td>");
#nullable restore
#line 34 "F:\Practice of Full CRUD\New CRUD\TicketBookingSystem\TicketBookingSystem\Areas\Admin\Views\Customer\GetAllCustomers.cshtml"
                                           Write(customer.CustomerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 35 "F:\Practice of Full CRUD\New CRUD\TicketBookingSystem\TicketBookingSystem\Areas\Admin\Views\Customer\GetAllCustomers.cshtml"
                                           Write(customer.ContactNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 36 "F:\Practice of Full CRUD\New CRUD\TicketBookingSystem\TicketBookingSystem\Areas\Admin\Views\Customer\GetAllCustomers.cshtml"
                                           Write(customer.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td> ");
#nullable restore
#line 37 "F:\Practice of Full CRUD\New CRUD\TicketBookingSystem\TicketBookingSystem\Areas\Admin\Views\Customer\GetAllCustomers.cshtml"
                                            Write(customer.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>\r\n                                                <button type=\"submit\" class=\"btn btn-info btn-sm\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1726, "\"", 1794, 5);
            WriteAttributeValue("", 1736, "window.location.href", 1736, 20, true);
            WriteAttributeValue(" ", 1756, "=", 1757, 2, true);
            WriteAttributeValue(" ", 1758, "\'/Admin/Customer/Edit/", 1759, 23, true);
#nullable restore
#line 39 "F:\Practice of Full CRUD\New CRUD\TicketBookingSystem\TicketBookingSystem\Areas\Admin\Views\Customer\GetAllCustomers.cshtml"
WriteAttributeValue("", 1781, customer.Id, 1781, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1793, "\'", 1793, 1, true);
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 1795, "\"", 1815, 1);
#nullable restore
#line 39 "F:\Practice of Full CRUD\New CRUD\TicketBookingSystem\TicketBookingSystem\Areas\Admin\Views\Customer\GetAllCustomers.cshtml"
WriteAttributeValue("", 1803, customer.Id, 1803, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                    <i class=\"fas fa-pencil-alt\"></i>Edit\r\n                                                </button>\r\n                                                <button type=\"submit\" class=\"btn btn-info btn-sm\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2066, "\"", 2136, 5);
            WriteAttributeValue("", 2076, "window.location.href", 2076, 20, true);
            WriteAttributeValue(" ", 2096, "=", 2097, 2, true);
            WriteAttributeValue(" ", 2098, "\'/Admin/Customer/Delete/", 2099, 25, true);
#nullable restore
#line 42 "F:\Practice of Full CRUD\New CRUD\TicketBookingSystem\TicketBookingSystem\Areas\Admin\Views\Customer\GetAllCustomers.cshtml"
WriteAttributeValue("", 2123, customer.Id, 2123, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2135, "\'", 2135, 1, true);
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 2137, "\"", 2157, 1);
#nullable restore
#line 42 "F:\Practice of Full CRUD\New CRUD\TicketBookingSystem\TicketBookingSystem\Areas\Admin\Views\Customer\GetAllCustomers.cshtml"
WriteAttributeValue("", 2145, customer.Id, 2145, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                    <i class=\"fas fa-trash\"></i>Delete\r\n                                                </button>\r\n                                            </td>\r\n\r\n                                         </tr>\r\n");
#nullable restore
#line 48 "F:\Practice of Full CRUD\New CRUD\TicketBookingSystem\TicketBookingSystem\Areas\Admin\Views\Customer\GetAllCustomers.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </tbody>
                            <tfoot>
                                <tr>
                                    <th>Customer Name</th>
                                    <th>Contact Number</th>
                                    <th>Age</th>
                                    <th>Address </th>
                                    <th style=""width:200px"">Action</th>
                                </tr>
                            </tfoot>
                        </table>
");
            WriteLiteral(@"
                    </div>
                    <!-- /.card-body -->
                </div>
                <!-- /.card -->
            </div>
            <!-- /.col -->
        </div>
        <!-- /.row -->
    </div>
    <!-- /.container-fluid -->
</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CustomerListModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
