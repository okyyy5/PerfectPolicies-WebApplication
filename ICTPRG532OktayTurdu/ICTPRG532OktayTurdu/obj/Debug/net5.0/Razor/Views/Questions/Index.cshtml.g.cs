#pragma checksum "E:\C#_Related\C# Projects\ICTPRG532OktayTurdu\ICTPRG532OktayTurdu\Views\Questions\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "131f840d6ee192b27da21f039576719ebe5055e9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Questions_Index), @"mvc.1.0.view", @"/Views/Questions/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"131f840d6ee192b27da21f039576719ebe5055e9", @"/Views/Questions/Index.cshtml")]
    public class Views_Questions_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ICTPRG532OktayTurdu.Entities.Question>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\C#_Related\C# Projects\ICTPRG532OktayTurdu\ICTPRG532OktayTurdu\Views\Questions\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    <a asp-action=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "E:\C#_Related\C# Projects\ICTPRG532OktayTurdu\ICTPRG532OktayTurdu\Views\Questions\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.QuestionTopic));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "E:\C#_Related\C# Projects\ICTPRG532OktayTurdu\ICTPRG532OktayTurdu\Views\Questions\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.QuestionText));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "E:\C#_Related\C# Projects\ICTPRG532OktayTurdu\ICTPRG532OktayTurdu\Views\Questions\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.QuestionImage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "E:\C#_Related\C# Projects\ICTPRG532OktayTurdu\ICTPRG532OktayTurdu\Views\Questions\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Quiz));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 31 "E:\C#_Related\C# Projects\ICTPRG532OktayTurdu\ICTPRG532OktayTurdu\Views\Questions\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 34 "E:\C#_Related\C# Projects\ICTPRG532OktayTurdu\ICTPRG532OktayTurdu\Views\Questions\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.QuestionTopic));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 37 "E:\C#_Related\C# Projects\ICTPRG532OktayTurdu\ICTPRG532OktayTurdu\Views\Questions\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.QuestionText));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "E:\C#_Related\C# Projects\ICTPRG532OktayTurdu\ICTPRG532OktayTurdu\Views\Questions\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.QuestionImage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 43 "E:\C#_Related\C# Projects\ICTPRG532OktayTurdu\ICTPRG532OktayTurdu\Views\Questions\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Quiz.QuizID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1214, "\"", 1245, 1);
#nullable restore
#line 46 "E:\C#_Related\C# Projects\ICTPRG532OktayTurdu\ICTPRG532OktayTurdu\Views\Questions\Index.cshtml"
WriteAttributeValue("", 1229, item.QuestionID, 1229, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n                <a asp-action=\"Details\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1298, "\"", 1329, 1);
#nullable restore
#line 47 "E:\C#_Related\C# Projects\ICTPRG532OktayTurdu\ICTPRG532OktayTurdu\Views\Questions\Index.cshtml"
WriteAttributeValue("", 1313, item.QuestionID, 1313, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a> |\r\n                <a asp-action=\"Delete\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1384, "\"", 1415, 1);
#nullable restore
#line 48 "E:\C#_Related\C# Projects\ICTPRG532OktayTurdu\ICTPRG532OktayTurdu\Views\Questions\Index.cshtml"
WriteAttributeValue("", 1399, item.QuestionID, 1399, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 51 "E:\C#_Related\C# Projects\ICTPRG532OktayTurdu\ICTPRG532OktayTurdu\Views\Questions\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ICTPRG532OktayTurdu.Entities.Question>> Html { get; private set; }
    }
}
#pragma warning restore 1591
