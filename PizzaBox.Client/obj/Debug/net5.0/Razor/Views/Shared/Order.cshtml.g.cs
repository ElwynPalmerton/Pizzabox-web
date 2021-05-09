#pragma checksum "/Users/elwynpalmerton/revature/project-pizzabox-web/PizzaBox.Client/Views/Shared/Order.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd1273f874cfd930cc18354976fe2cb3896f6be2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Order), @"mvc.1.0.view", @"/Views/Shared/Order.cshtml")]
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
#line 1 "/Users/elwynpalmerton/revature/project-pizzabox-web/PizzaBox.Client/Views/_ViewImports.cshtml"
using PizzaBox.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/elwynpalmerton/revature/project-pizzabox-web/PizzaBox.Client/Views/_ViewImports.cshtml"
using PizzaBox.Client.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd1273f874cfd930cc18354976fe2cb3896f6be2", @"/Views/Shared/Order.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0869890531cd973fc94231944f02086ee7830497", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Order : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PizzaBox.Client.Models.OrderViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/order/create"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<div class=\"p-2\"></div>\n<h2>Please Make an Order</h2>\n<div class=\"p-2\"></div>\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd1273f874cfd930cc18354976fe2cb3896f6be24130", async() => {
                WriteLiteral(" \n\n");
#nullable restore
#line 9 "/Users/elwynpalmerton/revature/project-pizzabox-web/PizzaBox.Client/Views/Shared/Order.cshtml"
     foreach(var item in Model.Sizes)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <label");
                BeginWriteAttribute("for", " for=\"", 229, "\"", 240, 1);
#nullable restore
#line 11 "/Users/elwynpalmerton/revature/project-pizzabox-web/PizzaBox.Client/Views/Shared/Order.cshtml"
WriteAttributeValue("", 235, item, 235, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 11 "/Users/elwynpalmerton/revature/project-pizzabox-web/PizzaBox.Client/Views/Shared/Order.cshtml"
                      Write(item);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\n");
#nullable restore
#line 12 "/Users/elwynpalmerton/revature/project-pizzabox-web/PizzaBox.Client/Views/Shared/Order.cshtml"
   Write(Html.RadioButtonFor(m => m.SelectedSize, @item));

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Users/elwynpalmerton/revature/project-pizzabox-web/PizzaBox.Client/Views/Shared/Order.cshtml"
                                                        ;
        
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("    ");
#nullable restore
#line 16 "/Users/elwynpalmerton/revature/project-pizzabox-web/PizzaBox.Client/Views/Shared/Order.cshtml"
Write(Html.ValidationMessageFor(m => m.SelectedSize, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n    <div class=\"p-3\"></div>\n\n");
#nullable restore
#line 19 "/Users/elwynpalmerton/revature/project-pizzabox-web/PizzaBox.Client/Views/Shared/Order.cshtml"
     foreach(var item in Model.Crusts)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <label");
                BeginWriteAttribute("for", " for=\"", 559, "\"", 570, 1);
#nullable restore
#line 21 "/Users/elwynpalmerton/revature/project-pizzabox-web/PizzaBox.Client/Views/Shared/Order.cshtml"
WriteAttributeValue("", 565, item, 565, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 21 "/Users/elwynpalmerton/revature/project-pizzabox-web/PizzaBox.Client/Views/Shared/Order.cshtml"
                      Write(item);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\n");
#nullable restore
#line 23 "/Users/elwynpalmerton/revature/project-pizzabox-web/PizzaBox.Client/Views/Shared/Order.cshtml"
   Write(Html.RadioButtonFor(m => m.SelectedCrust, @item));

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "/Users/elwynpalmerton/revature/project-pizzabox-web/PizzaBox.Client/Views/Shared/Order.cshtml"
                                                         ;
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("    ");
#nullable restore
#line 25 "/Users/elwynpalmerton/revature/project-pizzabox-web/PizzaBox.Client/Views/Shared/Order.cshtml"
Write(Html.ValidationMessageFor(m => m.SelectedCrust, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n    <div class=\"p-3\"></div>\n\n\n\n\n");
#nullable restore
#line 31 "/Users/elwynpalmerton/revature/project-pizzabox-web/PizzaBox.Client/Views/Shared/Order.cshtml"
     foreach(var item in Model.Toppings)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <label");
                BeginWriteAttribute("for", " for=\"", 909, "\"", 920, 1);
#nullable restore
#line 33 "/Users/elwynpalmerton/revature/project-pizzabox-web/PizzaBox.Client/Views/Shared/Order.cshtml"
WriteAttributeValue("", 915, item, 915, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 33 "/Users/elwynpalmerton/revature/project-pizzabox-web/PizzaBox.Client/Views/Shared/Order.cshtml"
                      Write(item);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\n        <input type=\"checkbox\"");
                BeginWriteAttribute("id", " id=\"", 966, "\"", 971, 0);
                EndWriteAttribute();
                WriteLiteral(" name=\"selectedtoppings\"");
                BeginWriteAttribute("value", " value=\"", 996, "\"", 1009, 1);
#nullable restore
#line 34 "/Users/elwynpalmerton/revature/project-pizzabox-web/PizzaBox.Client/Views/Shared/Order.cshtml"
WriteAttributeValue("", 1004, item, 1004, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n");
#nullable restore
#line 36 "/Users/elwynpalmerton/revature/project-pizzabox-web/PizzaBox.Client/Views/Shared/Order.cshtml"
                                                                
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd1273f874cfd930cc18354976fe2cb3896f6be29545", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 40 "/Users/elwynpalmerton/revature/project-pizzabox-web/PizzaBox.Client/Views/Shared/Order.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SelectedToppings);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n\n    <div class=\"p-3\"></div>\n    <button type=\"submit\" class=\"btn btn-primary\">Order Pizza</button>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n\n\n\n\n\n\n");
            WriteLiteral("\n\n\n");
            WriteLiteral("\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PizzaBox.Client.Models.OrderViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
