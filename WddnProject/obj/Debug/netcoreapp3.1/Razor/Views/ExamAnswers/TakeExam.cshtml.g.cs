#pragma checksum "C:\Users\ASUS\Documents\WDDN\ExamPortal\first\WDDN-Project-master\WddnProject\Views\ExamAnswers\TakeExam.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4551f4ece81517bfb46db815fcc2009ee59e6c71"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ExamAnswers_TakeExam), @"mvc.1.0.view", @"/Views/ExamAnswers/TakeExam.cshtml")]
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
#line 1 "C:\Users\ASUS\Documents\WDDN\ExamPortal\first\WDDN-Project-master\WddnProject\Views\_ViewImports.cshtml"
using WDDNProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ASUS\Documents\WDDN\ExamPortal\first\WDDN-Project-master\WddnProject\Views\_ViewImports.cshtml"
using WDDNProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4551f4ece81517bfb46db815fcc2009ee59e6c71", @"/Views/ExamAnswers/TakeExam.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca25745a2ef5eb1d92b27f882f2ba4c89e8a2eec", @"/Views/_ViewImports.cshtml")]
    public class Views_ExamAnswers_TakeExam : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WDDNProject.Models.Exam>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ASUS\Documents\WDDN\ExamPortal\first\WDDN-Project-master\WddnProject\Views\ExamAnswers\TakeExam.cshtml"
  
    ViewData["Title"] = "TakeExam";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-4\">\r\n        <h2>Examination : ");
#nullable restore
#line 10 "C:\Users\ASUS\Documents\WDDN\ExamPortal\first\WDDN-Project-master\WddnProject\Views\ExamAnswers\TakeExam.cshtml"
                     Write(Model.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n        <h3>Description : ");
#nullable restore
#line 11 "C:\Users\ASUS\Documents\WDDN\ExamPortal\first\WDDN-Project-master\WddnProject\Views\ExamAnswers\TakeExam.cshtml"
                     Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n");
#nullable restore
#line 13 "C:\Users\ASUS\Documents\WDDN\ExamPortal\first\WDDN-Project-master\WddnProject\Views\ExamAnswers\TakeExam.cshtml"
         using (Html.BeginForm("TakeExam", "ExamAnswers", FormMethod.Post))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <input name=\"examId\"");
            BeginWriteAttribute("value", " value=\"", 394, "\"", 411, 1);
#nullable restore
#line 15 "C:\Users\ASUS\Documents\WDDN\ExamPortal\first\WDDN-Project-master\WddnProject\Views\ExamAnswers\TakeExam.cshtml"
WriteAttributeValue("", 402, Model.id, 402, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" hidden />\r\n");
#nullable restore
#line 16 "C:\Users\ASUS\Documents\WDDN\ExamPortal\first\WDDN-Project-master\WddnProject\Views\ExamAnswers\TakeExam.cshtml"
             foreach (var question in Model.Questions)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"form-group\">\r\n                    <label class=\"control-label\">");
#nullable restore
#line 19 "C:\Users\ASUS\Documents\WDDN\ExamPortal\first\WDDN-Project-master\WddnProject\Views\ExamAnswers\TakeExam.cshtml"
                                            Write(question.question);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n\r\n                    <select");
            BeginWriteAttribute("name", " name=\"", 643, "\"", 662, 1);
#nullable restore
#line 21 "C:\Users\ASUS\Documents\WDDN\ExamPortal\first\WDDN-Project-master\WddnProject\Views\ExamAnswers\TakeExam.cshtml"
WriteAttributeValue("", 650, question.id, 650, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4551f4ece81517bfb46db815fcc2009ee59e6c716107", async() => {
#nullable restore
#line 22 "C:\Users\ASUS\Documents\WDDN\ExamPortal\first\WDDN-Project-master\WddnProject\Views\ExamAnswers\TakeExam.cshtml"
                                                     Write(question.option1);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 22 "C:\Users\ASUS\Documents\WDDN\ExamPortal\first\WDDN-Project-master\WddnProject\Views\ExamAnswers\TakeExam.cshtml"
                           WriteLiteral(question.option1);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4551f4ece81517bfb46db815fcc2009ee59e6c718015", async() => {
#nullable restore
#line 23 "C:\Users\ASUS\Documents\WDDN\ExamPortal\first\WDDN-Project-master\WddnProject\Views\ExamAnswers\TakeExam.cshtml"
                                                     Write(question.option2);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 23 "C:\Users\ASUS\Documents\WDDN\ExamPortal\first\WDDN-Project-master\WddnProject\Views\ExamAnswers\TakeExam.cshtml"
                           WriteLiteral(question.option2);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4551f4ece81517bfb46db815fcc2009ee59e6c719923", async() => {
#nullable restore
#line 24 "C:\Users\ASUS\Documents\WDDN\ExamPortal\first\WDDN-Project-master\WddnProject\Views\ExamAnswers\TakeExam.cshtml"
                                                     Write(question.option3);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 24 "C:\Users\ASUS\Documents\WDDN\ExamPortal\first\WDDN-Project-master\WddnProject\Views\ExamAnswers\TakeExam.cshtml"
                           WriteLiteral(question.option3);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4551f4ece81517bfb46db815fcc2009ee59e6c7111831", async() => {
#nullable restore
#line 25 "C:\Users\ASUS\Documents\WDDN\ExamPortal\first\WDDN-Project-master\WddnProject\Views\ExamAnswers\TakeExam.cshtml"
                                                     Write(question.option4);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 25 "C:\Users\ASUS\Documents\WDDN\ExamPortal\first\WDDN-Project-master\WddnProject\Views\ExamAnswers\TakeExam.cshtml"
                           WriteLiteral(question.option4);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </select>\r\n                </div>\r\n");
#nullable restore
#line 28 "C:\Users\ASUS\Documents\WDDN\ExamPortal\first\WDDN-Project-master\WddnProject\Views\ExamAnswers\TakeExam.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"form-group\">\r\n                <input type=\"submit\" value=\"Save\" class=\"btn btn-primary\" />\r\n            </div>\r\n");
#nullable restore
#line 34 "C:\Users\ASUS\Documents\WDDN\ExamPortal\first\WDDN-Project-master\WddnProject\Views\ExamAnswers\TakeExam.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WDDNProject.Models.Exam> Html { get; private set; }
    }
}
#pragma warning restore 1591
