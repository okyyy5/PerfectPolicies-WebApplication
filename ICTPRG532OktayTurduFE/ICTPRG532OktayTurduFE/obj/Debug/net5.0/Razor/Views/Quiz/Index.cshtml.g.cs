#pragma checksum "E:\C#_Related\C# Projects\ICTPRG532OktayTurduFE\ICTPRG532OktayTurduFE\Views\Quiz\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b335e0b647cec05b77160dddfde70e15c3394a0b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Quiz_Index), @"mvc.1.0.view", @"/Views/Quiz/Index.cshtml")]
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
#line 1 "E:\C#_Related\C# Projects\ICTPRG532OktayTurduFE\ICTPRG532OktayTurduFE\Views\_ViewImports.cshtml"
using ICTPRG532OktayTurduFE;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\C#_Related\C# Projects\ICTPRG532OktayTurduFE\ICTPRG532OktayTurduFE\Views\_ViewImports.cshtml"
using ICTPRG532OktayTurduFE.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b335e0b647cec05b77160dddfde70e15c3394a0b", @"/Views/Quiz/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f0c65773c7909fd80f2c373230e507758e1c275", @"/Views/_ViewImports.cshtml")]
    public class Views_Quiz_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ICTPRG532OktayTurduFE.Models.Quiz>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\C#_Related\C# Projects\ICTPRG532OktayTurduFE\ICTPRG532OktayTurduFE\Views\Quiz\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b335e0b647cec05b77160dddfde70e15c3394a0b3751", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "E:\C#_Related\C# Projects\ICTPRG532OktayTurduFE\ICTPRG532OktayTurduFE\Views\Quiz\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.QuizID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "E:\C#_Related\C# Projects\ICTPRG532OktayTurduFE\ICTPRG532OktayTurduFE\Views\Quiz\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.QuizTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "E:\C#_Related\C# Projects\ICTPRG532OktayTurduFE\ICTPRG532OktayTurduFE\Views\Quiz\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.QuizTopic));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "E:\C#_Related\C# Projects\ICTPRG532OktayTurduFE\ICTPRG532OktayTurduFE\Views\Quiz\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.QuizAuthor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "E:\C#_Related\C# Projects\ICTPRG532OktayTurduFE\ICTPRG532OktayTurduFE\Views\Quiz\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.QuizDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "E:\C#_Related\C# Projects\ICTPRG532OktayTurduFE\ICTPRG532OktayTurduFE\Views\Quiz\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.QuizPass));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 37 "E:\C#_Related\C# Projects\ICTPRG532OktayTurduFE\ICTPRG532OktayTurduFE\Views\Quiz\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "E:\C#_Related\C# Projects\ICTPRG532OktayTurduFE\ICTPRG532OktayTurduFE\Views\Quiz\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.QuizID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 43 "E:\C#_Related\C# Projects\ICTPRG532OktayTurduFE\ICTPRG532OktayTurduFE\Views\Quiz\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.QuizTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 46 "E:\C#_Related\C# Projects\ICTPRG532OktayTurduFE\ICTPRG532OktayTurduFE\Views\Quiz\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.QuizTopic));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 49 "E:\C#_Related\C# Projects\ICTPRG532OktayTurduFE\ICTPRG532OktayTurduFE\Views\Quiz\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.QuizAuthor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 52 "E:\C#_Related\C# Projects\ICTPRG532OktayTurduFE\ICTPRG532OktayTurduFE\Views\Quiz\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.QuizDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 55 "E:\C#_Related\C# Projects\ICTPRG532OktayTurduFE\ICTPRG532OktayTurduFE\Views\Quiz\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.QuizPass));

#line default
#line hidden
#nullable disable
            WriteLiteral("%\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 58 "E:\C#_Related\C# Projects\ICTPRG532OktayTurduFE\ICTPRG532OktayTurduFE\Views\Quiz\Index.cshtml"
           Write(Html.ActionLink("Questions", "QuestionsForQuizID", "Question", new {id=item.QuizID}, new { @class = "btn btn-primary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 61 "E:\C#_Related\C# Projects\ICTPRG532OktayTurduFE\ICTPRG532OktayTurduFE\Views\Quiz\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { id=item.QuizID }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 62 "E:\C#_Related\C# Projects\ICTPRG532OktayTurduFE\ICTPRG532OktayTurduFE\Views\Quiz\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new { id = item.QuizID }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 63 "E:\C#_Related\C# Projects\ICTPRG532OktayTurduFE\ICTPRG532OktayTurduFE\Views\Quiz\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { id = item.QuizID }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 66 "E:\C#_Related\C# Projects\ICTPRG532OktayTurduFE\ICTPRG532OktayTurduFE\Views\Quiz\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ICTPRG532OktayTurduFE.Models.Quiz>> Html { get; private set; }
    }
}
#pragma warning restore 1591
