#pragma checksum "C:\Nermin_Eliyeva_git\RentCar\RentCar\Views\Home\CarsCardandFIlter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e29ea74d9f159ba626741bec821028b0feffda91"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RentCar.Pages.Home.Views_Home_CarsCardandFIlter), @"mvc.1.0.view", @"/Views/Home/CarsCardandFIlter.cshtml")]
namespace RentCar.Pages.Home
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
#line 1 "C:\Nermin_Eliyeva_git\RentCar\RentCar\Views\_ViewImports.cshtml"
using RentCar.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e29ea74d9f159ba626741bec821028b0feffda91", @"/Views/Home/CarsCardandFIlter.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a496a8c06aaddfb2557d8a11342d9ba48edfda18", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_CarsCardandFIlter : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CarsViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<!-- masinlar olan sehife -->\r\n<div class=\"bodycontainer\">\r\n    <div class=\"axtariscontainer\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e29ea74d9f159ba626741bec821028b0feffda913672", async() => {
                WriteLiteral("\r\n            <select class=\"selectmarka\">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e29ea74d9f159ba626741bec821028b0feffda913992", async() => {
                    WriteLiteral("MARKA");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 9 "C:\Nermin_Eliyeva_git\RentCar\RentCar\Views\Home\CarsCardandFIlter.cshtml"
                 foreach (var item in Model.FilterData.FilterMarks)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e29ea74d9f159ba626741bec821028b0feffda916157", async() => {
#nullable restore
#line 11 "C:\Nermin_Eliyeva_git\RentCar\RentCar\Views\Home\CarsCardandFIlter.cshtml"
                                            Write(item.MarkName);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 11 "C:\Nermin_Eliyeva_git\RentCar\RentCar\Views\Home\CarsCardandFIlter.cshtml"
                       WriteLiteral(item.MarkId);

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
                WriteLiteral("\r\n");
#nullable restore
#line 12 "C:\Nermin_Eliyeva_git\RentCar\RentCar\Views\Home\CarsCardandFIlter.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </select>\r\n            <select class=\"selectmodel\">\r\n                 ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e29ea74d9f159ba626741bec821028b0feffda918309", async() => {
                    WriteLiteral("MODEL");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
                WriteLiteral("            </select>\r\n            <select>\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e29ea74d9f159ba626741bec821028b0feffda9110277", async() => {
                    WriteLiteral("IL");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 23 "C:\Nermin_Eliyeva_git\RentCar\RentCar\Views\Home\CarsCardandFIlter.cshtml"
                 foreach (var item in Model.FilterData.FilterYears)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e29ea74d9f159ba626741bec821028b0feffda9112441", async() => {
#nullable restore
#line 25 "C:\Nermin_Eliyeva_git\RentCar\RentCar\Views\Home\CarsCardandFIlter.cshtml"
                                Write(item);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 26 "C:\Nermin_Eliyeva_git\RentCar\RentCar\Views\Home\CarsCardandFIlter.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </select>\r\n            <select>\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e29ea74d9f159ba626741bec821028b0feffda9114095", async() => {
                    WriteLiteral("KATEQORİYA");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 30 "C:\Nermin_Eliyeva_git\RentCar\RentCar\Views\Home\CarsCardandFIlter.cshtml"
                 foreach (var item in Model.FilterData.FilterCategories)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e29ea74d9f159ba626741bec821028b0feffda9116272", async() => {
#nullable restore
#line 32 "C:\Nermin_Eliyeva_git\RentCar\RentCar\Views\Home\CarsCardandFIlter.cshtml"
                                Write(item.CategoryName);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 33 "C:\Nermin_Eliyeva_git\RentCar\RentCar\Views\Home\CarsCardandFIlter.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </select>\r\n            <div class=\"pricerange\">\r\n                <p");
                BeginWriteAttribute("for", " for=\"", 1397, "\"", 1403, 0);
                EndWriteAttribute();
                WriteLiteral(">Qiymət :</p>\r\n                <input type=\"text\" placeholder=\"Min\">\r\n                <input type=\"text\" placeholder=\"Max\">\r\n            </div>\r\n            <a");
                BeginWriteAttribute("href", " href=\"", 1563, "\"", 1570, 0);
                EndWriteAttribute();
                WriteLiteral(">Axtar</a>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n\r\n    <div class=\"productcontainer\">\r\n\r\n");
#nullable restore
#line 46 "C:\Nermin_Eliyeva_git\RentCar\RentCar\Views\Home\CarsCardandFIlter.cshtml"
         foreach (var item in Model.CardsInfo)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"product\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 1766, "\"", 1789, 1);
#nullable restore
#line 49 "C:\Nermin_Eliyeva_git\RentCar\RentCar\Views\Home\CarsCardandFIlter.cshtml"
WriteAttributeValue("", 1772, item.ImageBase64, 1772, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1790, "\"", 1796, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                <div class=\"productbasliq\">\r\n                    <div class=\"marka model\">");
#nullable restore
#line 51 "C:\Nermin_Eliyeva_git\RentCar\RentCar\Views\Home\CarsCardandFIlter.cshtml"
                                        Write(item.Marka);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 51 "C:\Nermin_Eliyeva_git\RentCar\RentCar\Views\Home\CarsCardandFIlter.cshtml"
                                                    Write(item.Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <div class=\"qiymet\"><span>");
#nullable restore
#line 52 "C:\Nermin_Eliyeva_git\RentCar\RentCar\Views\Home\CarsCardandFIlter.cshtml"
                                         Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>$ / gün</div>\r\n                </div>\r\n                <hr>\r\n                <div class=\"xususiyyetler\">\r\n                    <ul>\r\n                        <li><i class=\"fa-solid fa-calendar-days\"></i>");
#nullable restore
#line 57 "C:\Nermin_Eliyeva_git\RentCar\RentCar\Views\Home\CarsCardandFIlter.cshtml"
                                                                Write(item.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                        <li><i class=\"fa-solid fa-road\"></i>");
#nullable restore
#line 58 "C:\Nermin_Eliyeva_git\RentCar\RentCar\Views\Home\CarsCardandFIlter.cshtml"
                                                       Write(item.EngineType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                        <li><i class=\"fa-solid fa-bolt\"></i>");
#nullable restore
#line 59 "C:\Nermin_Eliyeva_git\RentCar\RentCar\Views\Home\CarsCardandFIlter.cshtml"
                                                       Write(item.Volume);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>L</span></li>\r\n                    </ul>\r\n                </div>\r\n                <div class=\"icondetails\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 2496, "\"", 2531, 2);
            WriteAttributeValue("", 2503, "/Home/CarDetails/", 2503, 17, true);
#nullable restore
#line 63 "C:\Nermin_Eliyeva_git\RentCar\RentCar\Views\Home\CarsCardandFIlter.cshtml"
WriteAttributeValue("", 2520, item.CarId, 2520, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa-solid fa-magnifying-glass\"></i></a>\r\n                    <a><i class=\"fa-regular fa-heart\"></i></a>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 67 "C:\Nermin_Eliyeva_git\RentCar\RentCar\Views\Home\CarsCardandFIlter.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n<script>\r\n    $(\".selectmarka\").change(function(x) {\r\n\r\n        var selectedMarkVal = $( \".selectmarka option:selected\" ).val();\r\n        $.ajax({\r\n                type: \"Get\",\r\n                url: \'");
#nullable restore
#line 78 "C:\Nermin_Eliyeva_git\RentCar\RentCar\Views\Home\CarsCardandFIlter.cshtml"
                 Write(Url.Action("GetModels","Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
                data: {
                id:selectedMarkVal
                },
                contentType: ""application/json; charset=utf-8"",
                success: 
                    function (returndata) {
                    $("".selectmodel"").children().remove().end()
                      $("".selectmodel"").append(`<option value="""" selected disabled>MODEL</option>`)
                    
                    $.each(returndata,function(i,item){
                        var option = new Option(item[""modelName""],item[""modelId""]);
                        $("".selectmodel"").append($(option))
                    })
                },
                error: function () {
                    alert(""Error while inserting data"");
                }
            });
    });

</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CarsViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
