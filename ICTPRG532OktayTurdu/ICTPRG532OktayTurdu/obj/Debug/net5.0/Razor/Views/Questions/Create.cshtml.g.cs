#pragma checksum "E:\C#_Related\C# Projects\ICTPRG532OktayTurdu\ICTPRG532OktayTurdu\Views\Questions\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f8b9fde311607c3d79ab8d3dacdd2f092c2ae00c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Questions_Create), @"mvc.1.0.view", @"/Views/Questions/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8b9fde311607c3d79ab8d3dacdd2f092c2ae00c", @"/Views/Questions/Create.cshtml")]
    public class Views_Questions_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ICTPRG532OktayTurdu.Entities.Question>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\C#_Related\C# Projects\ICTPRG532OktayTurdu\ICTPRG532OktayTurdu\Views\Questions\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Create</h1>

<h4>Question</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Create"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""QuestionTopic"" class=""control-label""></label>
                <input asp-for=""QuestionTopic"" class=""form-control"" />
                <span asp-validation-for=""QuestionTopic"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""QuestionText"" class=""control-label""></label>
                <input asp-for=""QuestionText"" class=""form-control"" />
                <span asp-validation-for=""QuestionText"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""QuestionImage"" class=""control-label""></label>
                <input asp-for=""QuestionImage"" class=""form-control"" />
                <span asp-validation-");
            WriteLiteral(@"for=""QuestionImage"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""QuizID"" class=""control-label""></label>
                <select asp-for=""QuizID"" class =""form-control"" asp-items=""ViewBag.QuizID""></select>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Create"" class=""btn btn-primary"" />
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
#line 46 "E:\C#_Related\C# Projects\ICTPRG532OktayTurdu\ICTPRG532OktayTurdu\Views\Questions\Create.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ICTPRG532OktayTurdu.Entities.Question> Html { get; private set; }
    }
}
#pragma warning restore 1591
