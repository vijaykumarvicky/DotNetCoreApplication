#pragma checksum "C:\Users\vijay\source\repos\DotNetCoreApplication2\DotNetCoreApplication\DotNetCoreApplication\Views\Employee\FormEmployee.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2f2dc17dbfd7106e75d61d5aa2ae490a0fb8da74"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_FormEmployee), @"mvc.1.0.view", @"/Views/Employee/FormEmployee.cshtml")]
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
#line 1 "C:\Users\vijay\source\repos\DotNetCoreApplication2\DotNetCoreApplication\DotNetCoreApplication\Views\_ViewImports.cshtml"
using DotNetCoreApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\vijay\source\repos\DotNetCoreApplication2\DotNetCoreApplication\DotNetCoreApplication\Views\_ViewImports.cshtml"
using DotNetCoreApplication.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f2dc17dbfd7106e75d61d5aa2ae490a0fb8da74", @"/Views/Employee/FormEmployee.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e7b961fc1406ea749cbf32ec7140afd92404902", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_FormEmployee : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DotNetCoreApplication.Models.EmployeeModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\vijay\source\repos\DotNetCoreApplication2\DotNetCoreApplication\DotNetCoreApplication\Views\Employee\FormEmployee.cshtml"
  
    ViewData["Title"] = "Employee";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Employee</h1>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n        <div class=\"box box-primary\">\r\n");
#nullable restore
#line 13 "C:\Users\vijay\source\repos\DotNetCoreApplication2\DotNetCoreApplication\DotNetCoreApplication\Views\Employee\FormEmployee.cshtml"
             using (Html.BeginForm(Model.EmployeeId == 0 ? "Add" : "Edit", "Employee", FormMethod.Post, new { enctype = "multipart/form-data" }))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"box-body\">\r\n                    ");
#nullable restore
#line 16 "C:\Users\vijay\source\repos\DotNetCoreApplication2\DotNetCoreApplication\DotNetCoreApplication\Views\Employee\FormEmployee.cshtml"
               Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <div class=\"row\">\r\n                        ");
#nullable restore
#line 18 "C:\Users\vijay\source\repos\DotNetCoreApplication2\DotNetCoreApplication\DotNetCoreApplication\Views\Employee\FormEmployee.cshtml"
                   Write(Html.HiddenFor(model => model.EmployeeId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"col-xs-12\" f>\r\n                            <label>Employee Name</label>\r\n                            ");
#nullable restore
#line 21 "C:\Users\vijay\source\repos\DotNetCoreApplication2\DotNetCoreApplication\DotNetCoreApplication\Views\Employee\FormEmployee.cshtml"
                       Write(Html.TextBoxFor(model => model.EmployeeName, new { @class = "form-control", @placeholder = "Employee Name" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>
                    </div>
                    <br />
                    <div class=""row"">
                        <div class=""col-xs-12"">
                            <label>Employee Code</label>
                            ");
#nullable restore
#line 28 "C:\Users\vijay\source\repos\DotNetCoreApplication2\DotNetCoreApplication\DotNetCoreApplication\Views\Employee\FormEmployee.cshtml"
                       Write(Html.TextBoxFor(model => model.EmployeeCode, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                        </div>
                    </div>
                    <br />
                    <div class=""row"">
                        <div class=""col-xs-12"">
                            <label>Contact No</label>
                            ");
#nullable restore
#line 36 "C:\Users\vijay\source\repos\DotNetCoreApplication2\DotNetCoreApplication\DotNetCoreApplication\Views\Employee\FormEmployee.cshtml"
                       Write(Html.TextBoxFor(model => model.ContactNo, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                        </div>
                    </div>
                    <br />
                    <div class=""row"">
                        <div class=""col-xs-12"">
                            <label>Company Name</label>
                            ");
#nullable restore
#line 44 "C:\Users\vijay\source\repos\DotNetCoreApplication2\DotNetCoreApplication\DotNetCoreApplication\Views\Employee\FormEmployee.cshtml"
                       Write(Html.TextBoxFor(model => model.CompanyName, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                        </div>
                    </div>
                </div>
                <div class=""box-footer"">
                    <button type=""submit"" class=""btn btn-primary""><i class=""fa fa-save""></i> Save</button>
                </div>
");
#nullable restore
#line 52 "C:\Users\vijay\source\repos\DotNetCoreApplication2\DotNetCoreApplication\DotNetCoreApplication\Views\Employee\FormEmployee.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DotNetCoreApplication.Models.EmployeeModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
