#pragma checksum "C:\Users\novik\OneDrive\Рабочий стол\FinanceTracker\FinanceTracker\Views\Shared\Components\ExpenseSavingsCard\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7da92800cbc840249ccdaa29f8e6ed6beb6732e786379170a1faa3265bd2d1d9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ExpenseSavingsCard_Default), @"mvc.1.0.view", @"/Views/Shared/Components/ExpenseSavingsCard/Default.cshtml")]
namespace AspNetCore
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\novik\OneDrive\Рабочий стол\FinanceTracker\FinanceTracker\Views\_ViewImports.cshtml"
using FinanceTracker

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\novik\OneDrive\Рабочий стол\FinanceTracker\FinanceTracker\Views\_ViewImports.cshtml"
using FinanceTracker.Models

#nullable disable
    ;
#nullable restore
#line 3 "C:\Users\novik\OneDrive\Рабочий стол\FinanceTracker\FinanceTracker\Views\_ViewImports.cshtml"
using FinanceTracker.ViewModels

#nullable disable
    ;
#nullable restore
#line 4 "C:\Users\novik\OneDrive\Рабочий стол\FinanceTracker\FinanceTracker\Views\_ViewImports.cshtml"
using FinanceTracker.Helpers

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"7da92800cbc840249ccdaa29f8e6ed6beb6732e786379170a1faa3265bd2d1d9", @"/Views/Shared/Components/ExpenseSavingsCard/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"c80fd34fcd087ddcbb29213bf6dc76a3f346fcf7431880ad9bec4eee933d2c23", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_ExpenseSavingsCard_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ExpenseSavingsViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "SavingsGoal", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Goals", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dropdown-item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Expense", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Savings", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-larger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\novik\OneDrive\Рабочий стол\FinanceTracker\FinanceTracker\Views\Shared\Components\ExpenseSavingsCard\Default.cshtml"
  
    bool hasSavings = false;

    foreach (var dataset in Model.Chart.data.datasets)
    {
        foreach (var saving in dataset.data)
        {
            if (saving > 0)
                hasSavings = true;
        }
    }

#line default
#line hidden
#nullable disable

            WriteLiteral(@"
<div class=""card h-100 shadow-sm"">
    <div class=""dropdown dropleft card-menu"">
        <a class=""text-muted""
           href=""#""
           role=""button""
           id=""dropdownMenu""
           data-toggle=""dropdown""
           aria-haspopup=""true""
           aria-expanded=""false"">
            <span class=""oi oi-ellipses"" style=""transform: rotate(90deg)""></span>
        </a>

        <div class=""dropdown-menu shadow-sm"" aria-labelledby=""dropdownMenu"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7da92800cbc840249ccdaa29f8e6ed6beb6732e786379170a1faa3265bd2d1d97036", async() => {
                WriteLiteral("\r\n                Трекер сбережений\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7da92800cbc840249ccdaa29f8e6ed6beb6732e786379170a1faa3265bd2d1d98567", async() => {
                WriteLiteral("\r\n                Трекер расходов\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>
    </div>

    <div class=""card-body"">
        <div class=""row"">
            <div class=""col-3"" style=""border-right: 2px solid var(--gray)"">
                <p class=""text-larger text-center mb-0"">Всего потрачено</p>
                <p class=""text-center m-0 text-muted""><small>в этом месяце</small></p>

                <h2 class=""text-center mt-2"">R ");
            Write(
#nullable restore
#line 49 "C:\Users\novik\OneDrive\Рабочий стол\FinanceTracker\FinanceTracker\Views\Shared\Components\ExpenseSavingsCard\Default.cshtml"
                                                String.Format("{0:0.00}", Model.TotalExpenses)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(@"</h2>
            </div>

            <div class=""col-3"">
                <p class=""text-larger text-center mb-0"">Всего сэкономлено</p>
                <p class=""text-center m-0 text-muted""><small>в этом месяце</small></p>

                <h2 class=""text-center mt-2"">R ");
            Write(
#nullable restore
#line 56 "C:\Users\novik\OneDrive\Рабочий стол\FinanceTracker\FinanceTracker\Views\Shared\Components\ExpenseSavingsCard\Default.cshtml"
                                                String.Format("{0:0.00}", Model.TotalSaved)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</h2>\r\n            </div>\r\n\r\n");
#nullable restore
#line 59 "C:\Users\novik\OneDrive\Рабочий стол\FinanceTracker\FinanceTracker\Views\Shared\Components\ExpenseSavingsCard\Default.cshtml"
             if (hasSavings)
            {

#line default
#line hidden
#nullable disable

            WriteLiteral("                <div class=\"col-6\">\r\n                    <div><canvas id=\"savingsChart\"></canvas></div>\r\n                </div>\r\n");
#nullable restore
#line 64 "C:\Users\novik\OneDrive\Рабочий стол\FinanceTracker\FinanceTracker\Views\Shared\Components\ExpenseSavingsCard\Default.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable

            WriteLiteral(@"                <div class=""col-6"">
                    <div class=""text-center"">
                        <p class=""m-0 text-muted"">
                            За последние 3 месяца сбережений не найдено
                        </p>

                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7da92800cbc840249ccdaa29f8e6ed6beb6732e786379170a1faa3265bd2d1d912509", async() => {
                WriteLiteral("\r\n                            начать запись сбережений\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 79 "C:\Users\novik\OneDrive\Рабочий стол\FinanceTracker\FinanceTracker\Views\Shared\Components\ExpenseSavingsCard\Default.cshtml"
            }

#line default
#line hidden
#nullable disable

            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n\r\n");
#nullable restore
#line 84 "C:\Users\novik\OneDrive\Рабочий стол\FinanceTracker\FinanceTracker\Views\Shared\Components\ExpenseSavingsCard\Default.cshtml"
 if (hasSavings)
{

#line default
#line hidden
#nullable disable

            WriteLiteral("    <script>\r\n        var ctx = document.getElementById(\'savingsChart\').getContext(\'2d\');\r\n        var chart = new Chart(ctx, ");
            Write(
#nullable restore
#line 88 "C:\Users\novik\OneDrive\Рабочий стол\FinanceTracker\FinanceTracker\Views\Shared\Components\ExpenseSavingsCard\Default.cshtml"
                                    Html.Raw(Json.Serialize(Model.Chart))

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(");\r\n    </script>\r\n");
#nullable restore
#line 90 "C:\Users\novik\OneDrive\Рабочий стол\FinanceTracker\FinanceTracker\Views\Shared\Components\ExpenseSavingsCard\Default.cshtml"
}

#line default
#line hidden
#nullable disable

        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ExpenseSavingsViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
