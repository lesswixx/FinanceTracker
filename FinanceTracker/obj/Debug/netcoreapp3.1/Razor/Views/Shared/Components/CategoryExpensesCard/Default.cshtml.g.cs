#pragma checksum "C:\Projects\FinanceTracker\FinanceTracker\Views\Shared\Components\CategoryExpensesCard\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c9c1fccc652f27f229f69aa5fa50f96f49fc0b9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_CategoryExpensesCard_Default), @"mvc.1.0.view", @"/Views/Shared/Components/CategoryExpensesCard/Default.cshtml")]
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
#line 1 "C:\Projects\FinanceTracker\FinanceTracker\Views\_ViewImports.cshtml"
using FinanceTracker;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projects\FinanceTracker\FinanceTracker\Views\_ViewImports.cshtml"
using FinanceTracker.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Projects\FinanceTracker\FinanceTracker\Views\_ViewImports.cshtml"
using FinanceTracker.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Projects\FinanceTracker\FinanceTracker\Views\_ViewImports.cshtml"
using FinanceTracker.Helpers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c9c1fccc652f27f229f69aa5fa50f96f49fc0b9", @"/Views/Shared/Components/CategoryExpensesCard/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7afca9de6cef832f0f3132aa2911dd1bcb06f321", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_CategoryExpensesCard_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CategoryExpensesViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Add", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Expense", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dropdown-item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-muted"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"
<div class=""card h-100 shadow-sm"">
    <div class=""card-body"">
        <p class=""text-center text-larger m-0"">Categories</p>

        <div class=""col-8 mx-auto my-3"">
            <canvas id=""categoryChart"" width=""100%"" height=""100%""></canvas>
        </div>

        <div class=""row justify-content-between col-12 mx-auto mb-2"">
            <p class=""text-larger m-0"">Recent Expenses</p>

            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1c9c1fccc652f27f229f69aa5fa50f96f49fc0b96980", async() => {
                WriteLiteral("\r\n                Add\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n\r\n        <table class=\"table mb-0\">\r\n");
#nullable restore
#line 24 "C:\Projects\FinanceTracker\FinanceTracker\Views\Shared\Components\CategoryExpensesCard\Default.cshtml"
             foreach (var item in Model.Expenses)
            {
                string modalName = "a" + item.Id.ToString() + "Modal";


#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        <div class=\"row\">\r\n                            <div");
            BeginWriteAttribute("style", " style=\"", 962, "\"", 1236, 10);
            WriteAttributeValue("", 970, "height:", 970, 7, true);
            WriteAttributeValue(" ", 977, "15px;", 978, 6, true);
            WriteAttributeValue("\r\n                                        ", 983, "width:", 1025, 48, true);
            WriteAttributeValue(" ", 1031, "15px;", 1032, 6, true);
            WriteAttributeValue("\r\n                                        ", 1037, "border-radius:", 1079, 56, true);
            WriteAttributeValue(" ", 1093, "50%;", 1094, 5, true);
            WriteAttributeValue("\r\n                                        ", 1098, "margin:", 1140, 49, true);
            WriteAttributeValue(" ", 1147, "6px;", 1148, 5, true);
            WriteAttributeValue("\r\n                                        ", 1152, "background-color:", 1194, 59, true);
#nullable restore
#line 35 "C:\Projects\FinanceTracker\FinanceTracker\Views\Shared\Components\CategoryExpensesCard\Default.cshtml"
WriteAttributeValue(" ", 1211, item.Category.ColorCode, 1212, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n                            </div>\r\n                            ");
#nullable restore
#line 38 "C:\Projects\FinanceTracker\FinanceTracker\Views\Shared\Components\CategoryExpensesCard\Default.cshtml"
                       Write(item.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        \r\n                    </td>\r\n                    <td>R ");
#nullable restore
#line 42 "C:\Projects\FinanceTracker\FinanceTracker\Views\Shared\Components\CategoryExpensesCard\Default.cshtml"
                     Write(item.Amount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                    <td>
                        <div class=""dropdown dropleft"">
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1c9c1fccc652f27f229f69aa5fa50f96f49fc0b911671", async() => {
                WriteLiteral("\r\n                                    Edit\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 58 "C:\Projects\FinanceTracker\FinanceTracker\Views\Shared\Components\CategoryExpensesCard\Default.cshtml"
                                     WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                                <a href=\"#\"\r\n                                   role=\"button\"\r\n                                   data-toggle=\"modal\"\r\n                                   data-target=\"#");
#nullable restore
#line 66 "C:\Projects\FinanceTracker\FinanceTracker\Views\Shared\Components\CategoryExpensesCard\Default.cshtml"
                                            Write(modalName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"""
                                   class=""dropdown-item"">
                                    Delete
                                </a>
                            </div>
                        </div>
                    </td>
                </tr>
");
            WriteLiteral("                <div class=\"modal fade\"");
            BeginWriteAttribute("id", "\r\n                     id=\"", 2957, "\"", 2994, 1);
#nullable restore
#line 76 "C:\Projects\FinanceTracker\FinanceTracker\Views\Shared\Components\CategoryExpensesCard\Default.cshtml"
WriteAttributeValue("", 2984, modalName, 2984, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                     tabindex=\"-1\"\r\n                     role=\"dialog\"");
            BeginWriteAttribute("aria-labelledby", "\r\n                     aria-labelledby=\"", 3067, "\"", 3117, 1);
#nullable restore
#line 79 "C:\Projects\FinanceTracker\FinanceTracker\Views\Shared\Components\CategoryExpensesCard\Default.cshtml"
WriteAttributeValue("", 3107, modalName, 3107, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"
                     aria-hidden=""true"">

                    <div class=""modal-dialog"" role=""document"">
                        <div class=""modal-content"">
                            <div class=""modal-header"">
                                <h5 class=""modal-title"" id=""exampleModalLabel"">Delete this expense?</h5>
                                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                                    <span aria-hidden=""true"">&times;</span>
                                </button>
                            </div>

                            <div class=""modal-body"">
                                <div class=""row"">
                                    <div class=""col-6"">
                                        <span class=""text-larger"">R ");
#nullable restore
#line 94 "C:\Projects\FinanceTracker\FinanceTracker\Views\Shared\Components\CategoryExpensesCard\Default.cshtml"
                                                               Write(item.Amount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                    </div>

                                    <div class=""col-6"">
                                        <div class=""row justify-content-end mx-1"">
                                            <span class=""text-larger"">");
#nullable restore
#line 99 "C:\Projects\FinanceTracker\FinanceTracker\Views\Shared\Components\CategoryExpensesCard\Default.cshtml"
                                                                 Write(item.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                            <div class=\"color-ball\"");
            BeginWriteAttribute("style", " style=\"", 4314, "\"", 4364, 2);
            WriteAttributeValue("", 4322, "background-color:", 4322, 17, true);
#nullable restore
#line 100 "C:\Projects\FinanceTracker\FinanceTracker\Views\Shared\Components\CategoryExpensesCard\Default.cshtml"
WriteAttributeValue(" ", 4339, item.Category.ColorCode, 4340, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></div>\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n\r\n                                <span>");
#nullable restore
#line 105 "C:\Projects\FinanceTracker\FinanceTracker\Views\Shared\Components\CategoryExpensesCard\Default.cshtml"
                                 Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                            </div>

                            <div class=""modal-footer"">
                                <button type=""button"" class=""btn btn-outline-secondary"" data-dismiss=""modal"">Close</button>
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1c9c1fccc652f27f229f69aa5fa50f96f49fc0b918978", async() => {
                WriteLiteral("\r\n                                    Delete\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 112 "C:\Projects\FinanceTracker\FinanceTracker\Views\Shared\Components\CategoryExpensesCard\Default.cshtml"
                                     WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 120 "C:\Projects\FinanceTracker\FinanceTracker\Views\Shared\Components\CategoryExpensesCard\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\r\n\r\n\r\n        <div class=\"row justify-content-center\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1c9c1fccc652f27f229f69aa5fa50f96f49fc0b921966", async() => {
                WriteLiteral("\r\n                view more\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n\r\n    </div>\r\n</div>\r\n\r\n<script>\r\n    var ctx = document.getElementById(\'categoryChart\').getContext(\'2d\');\r\n    var chart = new Chart(ctx, ");
#nullable restore
#line 137 "C:\Projects\FinanceTracker\FinanceTracker\Views\Shared\Components\CategoryExpensesCard\Default.cshtml"
                          Write(Html.Raw(Json.Serialize(Model.Chart)));

#line default
#line hidden
#nullable disable
            WriteLiteral(")\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CategoryExpensesViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
