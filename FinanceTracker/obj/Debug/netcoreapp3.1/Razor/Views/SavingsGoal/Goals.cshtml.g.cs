#pragma checksum "C:\Users\novik\OneDrive\Рабочий стол\FinanceTracker\FinanceTracker\Views\SavingsGoal\Goals.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3ed53cc509fd35101ed132ec31b8b913e45966ceb1cbd8b61a575aab2d2f02f9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SavingsGoal_Goals), @"mvc.1.0.view", @"/Views/SavingsGoal/Goals.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"3ed53cc509fd35101ed132ec31b8b913e45966ceb1cbd8b61a575aab2d2f02f9", @"/Views/SavingsGoal/Goals.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"c80fd34fcd087ddcbb29213bf6dc76a3f346fcf7431880ad9bec4eee933d2c23", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_SavingsGoal_Goals : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SavingsGoalProgressViewModel>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Add", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary mb-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dropdown-item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SetAsPinned", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\novik\OneDrive\Рабочий стол\FinanceTracker\FinanceTracker\Views\SavingsGoal\Goals.cshtml"
  
    ViewData["Title"] = "Цели накопления";

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ed53cc509fd35101ed132ec31b8b913e45966ceb1cbd8b61a575aab2d2f02f96540", async() => {
                WriteLiteral("\r\n    Добавить новую цель накопления\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<div class=\"row\">\r\n");
#nullable restore
#line 12 "C:\Users\novik\OneDrive\Рабочий стол\FinanceTracker\FinanceTracker\Views\SavingsGoal\Goals.cshtml"
     if (Model.Any())
    {
        

#line default
#line hidden
#nullable disable

#nullable restore
#line 14 "C:\Users\novik\OneDrive\Рабочий стол\FinanceTracker\FinanceTracker\Views\SavingsGoal\Goals.cshtml"
         foreach (var item in Model)
        {
            string modalName = "a" + item.SavingsGoal.Id.ToString() + "Modal";


#line default
#line hidden
#nullable disable

            WriteLiteral(@"            <div class=""col-4"">
                <div class=""card h-100 shadow-sm"">
                    <div class=""card-body d-flex flex-column"">

                        <div class=""row justify-content-between"">
                            <h4 class=""card-title col-11"">
                                ");
            Write(
#nullable restore
#line 24 "C:\Users\novik\OneDrive\Рабочий стол\FinanceTracker\FinanceTracker\Views\SavingsGoal\Goals.cshtml"
                                 item.SavingsGoal.Name

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 26 "C:\Users\novik\OneDrive\Рабочий стол\FinanceTracker\FinanceTracker\Views\SavingsGoal\Goals.cshtml"
                                 if (item.SavingsGoal.IsPinned)
                                {

#line default
#line hidden
#nullable disable

            WriteLiteral("                                    <small><span class=\"oi oi-pin text-muted\" style=\"transform: rotate(45deg)\"></span></small>\r\n");
#nullable restore
#line 29 "C:\Users\novik\OneDrive\Рабочий стол\FinanceTracker\FinanceTracker\Views\SavingsGoal\Goals.cshtml"
                                }

#line default
#line hidden
#nullable disable

            WriteLiteral(@"                            </h4>

                            <div class=""dropdown dropleft"">
                                <a class=""text-muted"" href=""#"" role=""button"" id=""dropdownMenu"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                    <span class=""oi oi-ellipses"" style=""transform: rotate(90deg)""></span>
                                </a>

                                <div class=""dropdown-menu col-1"" aria-labelledby=""dropdownMenu"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ed53cc509fd35101ed132ec31b8b913e45966ceb1cbd8b61a575aab2d2f02f910320", async() => {
                WriteLiteral("\r\n                                        Просмотр прогресса\r\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
            WriteLiteral(
#nullable restore
#line 38 "C:\Users\novik\OneDrive\Рабочий стол\FinanceTracker\FinanceTracker\Views\SavingsGoal\Goals.cshtml"
                                                                           item.SavingsGoal.Id

#line default
#line hidden
#nullable disable
            );
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                                    <div class=\"dropdown-divider\"></div>\r\n\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ed53cc509fd35101ed132ec31b8b913e45966ceb1cbd8b61a575aab2d2f02f912889", async() => {
                WriteLiteral("\r\n                                        Закрепить на панели\r\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
            WriteLiteral(
#nullable restore
#line 44 "C:\Users\novik\OneDrive\Рабочий стол\FinanceTracker\FinanceTracker\Views\SavingsGoal\Goals.cshtml"
                                                                               item.SavingsGoal.Id

#line default
#line hidden
#nullable disable
            );
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ed53cc509fd35101ed132ec31b8b913e45966ceb1cbd8b61a575aab2d2f02f915381", async() => {
                WriteLiteral("\r\n                                        Редактировать\r\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
            WriteLiteral(
#nullable restore
#line 48 "C:\Users\novik\OneDrive\Рабочий стол\FinanceTracker\FinanceTracker\Views\SavingsGoal\Goals.cshtml"
                                                                        item.SavingsGoal.Id

#line default
#line hidden
#nullable disable
            );
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                                    <a href=\"#\" role=\"button\" data-toggle=\"modal\" data-target=\"#");
            Write(
#nullable restore
#line 52 "C:\Users\novik\OneDrive\Рабочий стол\FinanceTracker\FinanceTracker\Views\SavingsGoal\Goals.cshtml"
                                                                                                 modalName

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(@""" class=""dropdown-item"">
                                        Удалить
                                    </a>
                                </div>
                            </div>
                        </div>

                        <h5>R ");
            Write(
#nullable restore
#line 59 "C:\Users\novik\OneDrive\Рабочий стол\FinanceTracker\FinanceTracker\Views\SavingsGoal\Goals.cshtml"
                               item.SavingsGoal.Amount

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</h5>\r\n                        <p>");
            Write(
#nullable restore
#line 60 "C:\Users\novik\OneDrive\Рабочий стол\FinanceTracker\FinanceTracker\Views\SavingsGoal\Goals.cshtml"
                            item.SavingsGoal.Description

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</p>\r\n\r\n");
#nullable restore
#line 62 "C:\Users\novik\OneDrive\Рабочий стол\FinanceTracker\FinanceTracker\Views\SavingsGoal\Goals.cshtml"
                         if (item.SavingsGoal.HasDeadline)
                        {

#line default
#line hidden
#nullable disable

            WriteLiteral("                            <small class=\"text-danger\"><p>Крайний срок - ");
            Write(
#nullable restore
#line 64 "C:\Users\novik\OneDrive\Рабочий стол\FinanceTracker\FinanceTracker\Views\SavingsGoal\Goals.cshtml"
                                                                          item.SavingsGoal.Deadline.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</p></small>\r\n");
#nullable restore
#line 65 "C:\Users\novik\OneDrive\Рабочий стол\FinanceTracker\FinanceTracker\Views\SavingsGoal\Goals.cshtml"
                        }

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n                        <div class=\"progress mt-auto\">\r\n                            <div class=\"progress-bar\" role=\"progressbar\"");
            BeginWriteAttribute("aria-valuenow", " aria-valuenow=\"", 3065, "\"", 3095, 1);
            WriteAttributeValue("", 3081, 
#nullable restore
#line 68 "C:\Users\novik\OneDrive\Рабочий стол\FinanceTracker\FinanceTracker\Views\SavingsGoal\Goals.cshtml"
                                                                                         item.Progress

#line default
#line hidden
#nullable disable
            , 3081, 14, false);
            EndWriteAttribute();
            WriteLiteral(" aria-valuemin=\"0\" aria-valuemax=\"100\"");
            BeginWriteAttribute("style", " style=\"", 3134, "\"", 3164, 3);
            WriteAttributeValue("", 3142, "width:", 3142, 6, true);
            WriteAttributeValue(" ", 3148, 
#nullable restore
#line 68 "C:\Users\novik\OneDrive\Рабочий стол\FinanceTracker\FinanceTracker\Views\SavingsGoal\Goals.cshtml"
                                                                                                                                                             item.Progress

#line default
#line hidden
#nullable disable
            , 3149, 14, false);
            WriteAttributeValue("", 3163, "%", 3163, 1, true);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
            WriteLiteral("            <div class=\"modal fade\"");
            BeginWriteAttribute("id", " id=\"", 3315, "\"", 3330, 1);
            WriteAttributeValue("", 3320, 
#nullable restore
#line 74 "C:\Users\novik\OneDrive\Рабочий стол\FinanceTracker\FinanceTracker\Views\SavingsGoal\Goals.cshtml"
                                         modalName

#line default
#line hidden
#nullable disable
            , 3320, 10, false);
            EndWriteAttribute();
            WriteLiteral(" tabindex=\"-1\" role=\"dialog\"");
            BeginWriteAttribute("aria-labelledby", " aria-labelledby=\"", 3359, "\"", 3387, 1);
            WriteAttributeValue("", 3377, 
#nullable restore
#line 74 "C:\Users\novik\OneDrive\Рабочий стол\FinanceTracker\FinanceTracker\Views\SavingsGoal\Goals.cshtml"
                                                                                                  modalName

#line default
#line hidden
#nullable disable
            , 3377, 10, false);
            EndWriteAttribute();
            WriteLiteral(@" aria-hidden=""true"">
                <div class=""modal-dialog"" role=""document"">
                    <div class=""modal-content"">
                        <div class=""modal-header"">
                            <h5 class=""modal-title"" id=""exampleModalLabel"">Удалить эту цель накопления?</h5>

                            <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                                <span aria-hidden=""true"">&times;</span>
                            </button>
                        </div>

                        <div class=""modal-body"">
                            <div class=""row justify-content-between col-12"">
                                <p class=""text-larger"">");
            Write(
#nullable restore
#line 87 "C:\Users\novik\OneDrive\Рабочий стол\FinanceTracker\FinanceTracker\Views\SavingsGoal\Goals.cshtml"
                                                        item.SavingsGoal.Name

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</p>\r\n                                <p class=\"text-larger\">R ");
            Write(
#nullable restore
#line 88 "C:\Users\novik\OneDrive\Рабочий стол\FinanceTracker\FinanceTracker\Views\SavingsGoal\Goals.cshtml"
                                                          item.SavingsGoal.Amount

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</p>\r\n                            </div>\r\n\r\n                            <span class=\"text-danger\">");
            Write(
#nullable restore
#line 91 "C:\Users\novik\OneDrive\Рабочий стол\FinanceTracker\FinanceTracker\Views\SavingsGoal\Goals.cshtml"
                                                       item.SavingsGoal.Deadline.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</span>\r\n                            <p>");
            Write(
#nullable restore
#line 92 "C:\Users\novik\OneDrive\Рабочий стол\FinanceTracker\FinanceTracker\Views\SavingsGoal\Goals.cshtml"
                                item.SavingsGoal.Description

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(@"</p>

                            <p class=""text-danger""><small>* Удалив эту цель накопления, вы удалите ВСЕ связанные с ней транзакции.</small></p>
                        </div>

                        <div class=""modal-footer"">
                            <button type=""button"" class=""btn btn-outline-secondary"" data-dismiss=""modal"">Закрыть</button>
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ed53cc509fd35101ed132ec31b8b913e45966ceb1cbd8b61a575aab2d2f02f925476", async() => {
                WriteLiteral("\r\n                                Удалить\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
            WriteLiteral(
#nullable restore
#line 99 "C:\Users\novik\OneDrive\Рабочий стол\FinanceTracker\FinanceTracker\Views\SavingsGoal\Goals.cshtml"
                                                                  item.SavingsGoal.Id

#line default
#line hidden
#nullable disable
            );
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 106 "C:\Users\novik\OneDrive\Рабочий стол\FinanceTracker\FinanceTracker\Views\SavingsGoal\Goals.cshtml"
        }

#line default
#line hidden
#nullable disable

#nullable restore
#line 106 "C:\Users\novik\OneDrive\Рабочий стол\FinanceTracker\FinanceTracker\Views\SavingsGoal\Goals.cshtml"
         
    }
    else
    {

#line default
#line hidden
#nullable disable

            WriteLiteral("        <p>Ничего не найдено..</p>\r\n");
#nullable restore
#line 111 "C:\Users\novik\OneDrive\Рабочий стол\FinanceTracker\FinanceTracker\Views\SavingsGoal\Goals.cshtml"
    }

#line default
#line hidden
#nullable disable

            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SavingsGoalProgressViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
