#pragma checksum "D:\CodeAcademy\Development3\BS\BScodeApp\BScodeWeb\Views\AboutWebContent\Add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3300a2f635f69b1c6232e404168b1da9d6da5056"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AboutWebContent_Add), @"mvc.1.0.view", @"/Views/AboutWebContent/Add.cshtml")]
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
#line 1 "D:\CodeAcademy\Development3\BS\BScodeApp\BScodeWeb\Views\_ViewImports.cshtml"
using BScodeWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\CodeAcademy\Development3\BS\BScodeApp\BScodeWeb\Views\_ViewImports.cshtml"
using BScodeWeb.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\CodeAcademy\Development3\BS\BScodeApp\BScodeWeb\Views\AboutWebContent\Add.cshtml"
using BSCodeModels_Lib;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3300a2f635f69b1c6232e404168b1da9d6da5056", @"/Views/AboutWebContent/Add.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eed17cb14175019c94eb3beb1d1197273d3769f3", @"/Views/_ViewImports.cshtml")]
    public class Views_AboutWebContent_Add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<About>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\CodeAcademy\Development3\BS\BScodeApp\BScodeWeb\Views\AboutWebContent\Add.cshtml"
  
    Layout = "_ActionLayout";
    ViewData["Header"] = "About";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 8 "D:\CodeAcademy\Development3\BS\BScodeApp\BScodeWeb\Views\AboutWebContent\Add.cshtml"
 using (Html.BeginForm("Add", "AboutWebContent", FormMethod.Post, new { @class = "row g-3" }))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"offset-md-2 col-md-8\">\r\n        ");
#nullable restore
#line 11 "D:\CodeAcademy\Development3\BS\BScodeApp\BScodeWeb\Views\AboutWebContent\Add.cshtml"
   Write(Html.LabelFor(model => model.Title, new { @class = "form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 12 "D:\CodeAcademy\Development3\BS\BScodeApp\BScodeWeb\Views\AboutWebContent\Add.cshtml"
   Write(Html.TextBoxFor(model => model.Title, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 13 "D:\CodeAcademy\Development3\BS\BScodeApp\BScodeWeb\Views\AboutWebContent\Add.cshtml"
   Write(Html.ValidationMessageFor(model => model.Title, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("     <div class=\"offset-md-2 col-md-8\">\r\n        ");
#nullable restore
#line 17 "D:\CodeAcademy\Development3\BS\BScodeApp\BScodeWeb\Views\AboutWebContent\Add.cshtml"
   Write(Html.LabelFor(model => model.ShortDescription, new { @class = "form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 18 "D:\CodeAcademy\Development3\BS\BScodeApp\BScodeWeb\Views\AboutWebContent\Add.cshtml"
   Write(Html.TextAreaFor(model => model.ShortDescription, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 19 "D:\CodeAcademy\Development3\BS\BScodeApp\BScodeWeb\Views\AboutWebContent\Add.cshtml"
   Write(Html.ValidationMessageFor(model => model.ShortDescription, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("     <div class=\"offset-md-2 col-md-8\">\r\n        ");
#nullable restore
#line 23 "D:\CodeAcademy\Development3\BS\BScodeApp\BScodeWeb\Views\AboutWebContent\Add.cshtml"
   Write(Html.LabelFor(model => model.LongDescription, new { @class = "form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 24 "D:\CodeAcademy\Development3\BS\BScodeApp\BScodeWeb\Views\AboutWebContent\Add.cshtml"
   Write(Html.TextAreaFor(model => model.LongDescription, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 25 "D:\CodeAcademy\Development3\BS\BScodeApp\BScodeWeb\Views\AboutWebContent\Add.cshtml"
   Write(Html.ValidationMessageFor(model => model.LongDescription, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("     <div class=\"offset-md-2 col-md-8\">\r\n        ");
#nullable restore
#line 29 "D:\CodeAcademy\Development3\BS\BScodeApp\BScodeWeb\Views\AboutWebContent\Add.cshtml"
   Write(Html.LabelFor(model => model.AboutPoints, new { @class = "form-label", @placeholder = "Separet points with ';'. Example: point1 some poiny; point2 some point; point3 some point" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 30 "D:\CodeAcademy\Development3\BS\BScodeApp\BScodeWeb\Views\AboutWebContent\Add.cshtml"
   Write(Html.TextBoxFor(model => model.AboutPoints, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 31 "D:\CodeAcademy\Development3\BS\BScodeApp\BScodeWeb\Views\AboutWebContent\Add.cshtml"
   Write(Html.ValidationMessageFor(model => model.AboutPoints, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("     <div class=\"offset-md-2 col-md-8\">\r\n        ");
#nullable restore
#line 35 "D:\CodeAcademy\Development3\BS\BScodeApp\BScodeWeb\Views\AboutWebContent\Add.cshtml"
   Write(Html.LabelFor(model => model.LastThought, new { @class = "form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 36 "D:\CodeAcademy\Development3\BS\BScodeApp\BScodeWeb\Views\AboutWebContent\Add.cshtml"
   Write(Html.TextAreaFor(model => model.LastThought, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 37 "D:\CodeAcademy\Development3\BS\BScodeApp\BScodeWeb\Views\AboutWebContent\Add.cshtml"
   Write(Html.ValidationMessageFor(model => model.LastThought, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("    <div class=\"offset-md-2 col-md-8\">\r\n        ");
#nullable restore
#line 41 "D:\CodeAcademy\Development3\BS\BScodeApp\BScodeWeb\Views\AboutWebContent\Add.cshtml"
   Write(Html.LabelFor(model => model.ImageName, new { @class = "form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 42 "D:\CodeAcademy\Development3\BS\BScodeApp\BScodeWeb\Views\AboutWebContent\Add.cshtml"
   Write(Html.TextBoxFor(model => model.ImageName, new { type = "file", @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 43 "D:\CodeAcademy\Development3\BS\BScodeApp\BScodeWeb\Views\AboutWebContent\Add.cshtml"
   Write(Html.ValidationMessageFor(model => model.ImageName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("     <div class=\"offset-md-2 col-md-8\">\r\n        <button type=\"submit\" class=\"btn btn-primary form-control\">Add</button>\r\n    </div>\r\n");
#nullable restore
#line 49 "D:\CodeAcademy\Development3\BS\BScodeApp\BScodeWeb\Views\AboutWebContent\Add.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<About> Html { get; private set; }
    }
}
#pragma warning restore 1591
