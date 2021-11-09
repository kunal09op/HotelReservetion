#pragma checksum "C:\Users\3931\source\repos\HotelReservetion\HotelReservetion\Views\Hotels\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e4a036711e70809c6f804983060a7faffa34b1f6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Hotels_Edit), @"mvc.1.0.view", @"/Views/Hotels/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4a036711e70809c6f804983060a7faffa34b1f6", @"/Views/Hotels/Edit.cshtml")]
    public class Views_Hotels_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HotelReservetion.Models.Hotel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\3931\source\repos\HotelReservetion\HotelReservetion\Views\Hotels\Edit.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Edit</h1>

<h4>Hotel</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Edit"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <input type=""hidden"" asp-for=""HotelID"" />
            <div class=""form-group"">
                <label asp-for=""City"" class=""control-label""></label>
                <input asp-for=""City"" class=""form-control"" />
                <span asp-validation-for=""City"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""State"" class=""control-label""></label>
                <input asp-for=""State"" class=""form-control"" />
                <span asp-validation-for=""State"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""ZipCode"" class=""control-label""></label>
                <input asp-for=""ZipCode"" class=""form-control"" />
                <span asp-validation-for=""ZipCode");
            WriteLiteral(@""" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""PhoneNumber"" class=""control-label""></label>
                <input asp-for=""PhoneNumber"" class=""form-control"" />
                <span asp-validation-for=""PhoneNumber"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""EmployeeID"" class=""control-label""></label>
                <input asp-for=""EmployeeID"" class=""form-control"" />
                <span asp-validation-for=""EmployeeID"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Save"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 53 "C:\Users\3931\source\repos\HotelReservetion\HotelReservetion\Views\Hotels\Edit.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HotelReservetion.Models.Hotel> Html { get; private set; }
    }
}
#pragma warning restore 1591
