#pragma checksum "C:\Users\novik\OneDrive\Рабочий стол\FinanceTracker\FinanceTracker\Views\Shared\Components\BudgetUsedCard\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6025e0d78de31ee68b9583dd90f0e04e010c4ba04cb33679958b4100f93883fa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_BudgetUsedCard_Default), @"mvc.1.0.view", @"/Views/Shared/Components/BudgetUsedCard/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"6025e0d78de31ee68b9583dd90f0e04e010c4ba04cb33679958b4100f93883fa", @"/Views/Shared/Components/BudgetUsedCard/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"c80fd34fcd087ddcbb29213bf6dc76a3f346fcf7431880ad9bec4eee933d2c23", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_BudgetUsedCard_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BudgetUsedViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Budget", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dropdown-item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Add", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-larger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<div class=\"card h-100 shadow-sm\">\r\n");
#nullable restore
#line 4 "C:\Users\novik\OneDrive\Рабочий стол\FinanceTracker\FinanceTracker\Views\Shared\Components\BudgetUsedCard\Default.cshtml"
     if (Model.CategoriesInBudget > 0)
    {

#line default
#line hidden
#nullable disable

            WriteLiteral(@"        <div class=""dropdown dropleft card-menu"">
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6025e0d78de31ee68b9583dd90f0e04e010c4ba04cb33679958b4100f93883fa6544", async() => {
                WriteLiteral("\r\n                    Просмотр деталей\r\n                ");
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
            WriteLiteral("\r\n\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6025e0d78de31ee68b9583dd90f0e04e010c4ba04cb33679958b4100f93883fa8086", async() => {
                WriteLiteral("\r\n                    Редактировать бюджет\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
            WriteLiteral(
#nullable restore
#line 26 "C:\Users\novik\OneDrive\Рабочий стол\FinanceTracker\FinanceTracker\Views\Shared\Components\BudgetUsedCard\Default.cshtml"
                                  Model.BudgetId

#line default
#line hidden
#nullable disable
            );
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n");
            WriteLiteral(@"        <div class=""card-body"">
            <p class=""text-larger text-center my-0"">Использование бюджета</p>
            <p class=""text-center text-muted my-0""><small>в этом месяце</small></p>

            <div class=""col-8 mx-auto my-1"">
                <canvas id=""budgetUsedChart"" width=""100%"" height=""100%""></canvas>

                <div class=""doughnut-inner"" style=""margin-top: -140px"">
                    <h2 class=""text-center display-4"">");
            Write(
#nullable restore
#line 41 "C:\Users\novik\OneDrive\Рабочий стол\FinanceTracker\FinanceTracker\Views\Shared\Components\BudgetUsedCard\Default.cshtml"
                                                       Model.PercentageUsed

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("%</h2>\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"row\" style=\"margin-top: 70px\">\r\n                <div class=\"col-6\">\r\n                    <div>\r\n                        <h1 class=\"display-4 text-center text-primary my-0\">");
            Write(
#nullable restore
#line 48 "C:\Users\novik\OneDrive\Рабочий стол\FinanceTracker\FinanceTracker\Views\Shared\Components\BudgetUsedCard\Default.cshtml"
                                                                             Model.CategoriesInBudget

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(@"</h1>
                        <p class=""m-0 text-center"">Категории</p>
                        <p class=""m-0 text-center text-muted""><small>использованы в бюджете</small></p>
                    </div>
                </div>

                <div class=""col-6"">
                    <h1 class=""display-4 text-center text-danger my-0"">");
            Write(
#nullable restore
#line 55 "C:\Users\novik\OneDrive\Рабочий стол\FinanceTracker\FinanceTracker\Views\Shared\Components\BudgetUsedCard\Default.cshtml"
                                                                        Model.CategoriesOverBudget

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</h1>\r\n                    <p class=\"m-0 text-center\">Категории</p>\r\n                    <p class=\"m-0 text-center text-muted\"><small>превысили бюджет</small></p>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 61 "C:\Users\novik\OneDrive\Рабочий стол\FinanceTracker\FinanceTracker\Views\Shared\Components\BudgetUsedCard\Default.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable

            WriteLiteral("        <div class=\"card-body text-center\">\r\n            <p class=\"text-muted m-0\">Бюджет на этот месяц не установлен</p>\r\n\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6025e0d78de31ee68b9583dd90f0e04e010c4ba04cb33679958b4100f93883fa13580", async() => {
                WriteLiteral("\r\n                создать бюджет для ");
                Write(
#nullable restore
#line 70 "C:\Users\novik\OneDrive\Рабочий стол\FinanceTracker\FinanceTracker\Views\Shared\Components\BudgetUsedCard\Default.cshtml"
                                    DateTime.Now.ToString("MMMM")

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 73 "C:\Users\novik\OneDrive\Рабочий стол\FinanceTracker\FinanceTracker\Views\Shared\Components\BudgetUsedCard\Default.cshtml"
    }

#line default
#line hidden
#nullable disable

            WriteLiteral("</div>\r\n\r\n");
#nullable restore
#line 76 "C:\Users\novik\OneDrive\Рабочий стол\FinanceTracker\FinanceTracker\Views\Shared\Components\BudgetUsedCard\Default.cshtml"
 if (Model.CategoriesInBudget > 0)
{

#line default
#line hidden
#nullable disable

            WriteLiteral("    <script>\r\n    var ctx = document.getElementById(\'budgetUsedChart\').getContext(\'2d\');\r\n    var chart = new Chart(ctx, ");
            Write(
#nullable restore
#line 80 "C:\Users\novik\OneDrive\Рабочий стол\FinanceTracker\FinanceTracker\Views\Shared\Components\BudgetUsedCard\Default.cshtml"
                                Html.Raw(Json.Serialize(Model.Chart))

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(");\r\n    </script>\r\n");
#nullable restore
#line 82 "C:\Users\novik\OneDrive\Рабочий стол\FinanceTracker\FinanceTracker\Views\Shared\Components\BudgetUsedCard\Default.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BudgetUsedViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
