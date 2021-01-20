#pragma checksum "C:\Projects\FinanceTracker\FinanceTracker\Views\Shared\Components\ExpenseSavingsCard\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d947749858599eb727756def298742d4356b9dd3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ExpenseSavingsCard_Default), @"mvc.1.0.view", @"/Views/Shared/Components/ExpenseSavingsCard/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d947749858599eb727756def298742d4356b9dd3", @"/Views/Shared/Components/ExpenseSavingsCard/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7afca9de6cef832f0f3132aa2911dd1bcb06f321", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_ExpenseSavingsCard_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ExpenseSavingsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral(@"
<div class=""card h-100 shadow-sm"">
    <div class=""card-body"">
        <div class=""row"">
            <div class=""col-3"" style=""border-right: 2px solid var(--gray)"">
                <p class=""text-larger text-center mb-0"">Total Spent</p>
                <p class=""text-center m-0 text-muted""><small>this month</small></p>

                <h2 class=""text-center mt-2"">R ");
#nullable restore
#line 12 "C:\Projects\FinanceTracker\FinanceTracker\Views\Shared\Components\ExpenseSavingsCard\Default.cshtml"
                                          Write(String.Format("{0:0.00}", Model.TotalExpenses));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
            </div>

            <div class=""col-3"">
                <p class=""text-larger text-center mb-0"">Total Saved</p>
                <p class=""text-center m-0 text-muted""><small>this month</small></p>

                <h2 class=""text-center mt-2"">R ");
#nullable restore
#line 19 "C:\Projects\FinanceTracker\FinanceTracker\Views\Shared\Components\ExpenseSavingsCard\Default.cshtml"
                                          Write(String.Format("{0:0.00}", Model.TotalSaved));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
            </div>

            <div class=""col-6"">
                <div><canvas id=""savingsChart""></canvas></div>
            </div>
        </div>
        

    </div>
</div>

<script>
    var ctx = document.getElementById('savingsChart').getContext('2d');
    var chart = new Chart(ctx, ");
#nullable restore
#line 33 "C:\Projects\FinanceTracker\FinanceTracker\Views\Shared\Components\ExpenseSavingsCard\Default.cshtml"
                          Write(Html.Raw(Json.Serialize(Model.Chart)));

#line default
#line hidden
#nullable disable
            WriteLiteral(");\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ExpenseSavingsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
