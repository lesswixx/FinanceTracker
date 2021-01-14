#pragma checksum "C:\Projects\FinanceTracker\financetracker\Views\Budget\Add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "46eaecc95b4738a19df5ca78ff73b77a336ac6a4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Budget_Add), @"mvc.1.0.view", @"/Views/Budget/Add.cshtml")]
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
#line 1 "C:\Projects\FinanceTracker\financetracker\Views\_ViewImports.cshtml"
using FinanceTracker;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projects\FinanceTracker\financetracker\Views\_ViewImports.cshtml"
using FinanceTracker.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Projects\FinanceTracker\financetracker\Views\_ViewImports.cshtml"
using FinanceTracker.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Projects\FinanceTracker\financetracker\Views\_ViewImports.cshtml"
using FinanceTracker.Helpers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46eaecc95b4738a19df5ca78ff73b77a336ac6a4", @"/Views/Budget/Add.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7afca9de6cef832f0f3132aa2911dd1bcb06f321", @"/Views/_ViewImports.cshtml")]
    public class Views_Budget_Add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Category>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Add", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Projects\FinanceTracker\financetracker\Views\Budget\Add.cshtml"
  
    ViewData["Title"] = "Add Budget";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n    <style>\r\n        .color-ball {\r\n            height: 20px;\r\n            width: 20px;\r\n            margin: 5px;\r\n            border-radius: 50%\r\n        }\r\n    </style>\r\n");
            }
            );
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "46eaecc95b4738a19df5ca78ff73b77a336ac6a44718", async() => {
                WriteLiteral("\r\n\r\n    <div class=\"row\">\r\n");
#nullable restore
#line 22 "C:\Projects\FinanceTracker\financetracker\Views\Budget\Add.cshtml"
         foreach (var item in Model)
        {


#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\"form-group col-6\">\r\n                <label>\r\n                    <div class=\"row justify-content-around\">\r\n                        <div class=\"color-ball\"");
                BeginWriteAttribute("style", " style=\"", 575, "\"", 616, 2);
                WriteAttributeValue("", 583, "background-color:", 583, 17, true);
#nullable restore
#line 28 "C:\Projects\FinanceTracker\financetracker\Views\Budget\Add.cshtml"
WriteAttributeValue(" ", 600, item.ColorCode, 601, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></div>\r\n                        ");
#nullable restore
#line 29 "C:\Projects\FinanceTracker\financetracker\Views\Budget\Add.cshtml"
                   Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                </label>\r\n\r\n                <input class=\"form-control\"");
                BeginWriteAttribute("name", "\r\n                       name=\"", 761, "\"", 800, 1);
#nullable restore
#line 34 "C:\Projects\FinanceTracker\financetracker\Views\Budget\Add.cshtml"
WriteAttributeValue("", 792, item.Id, 792, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("\r\n                       type=\"text\" />\r\n            </div>\r\n");
#nullable restore
#line 37 "C:\Projects\FinanceTracker\financetracker\Views\Budget\Add.cshtml"

        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </div>\r\n\r\n    <button class=\"btn btn-primary\"\r\n            type=\"submit\">\r\n        Create Budget\r\n    </button>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
