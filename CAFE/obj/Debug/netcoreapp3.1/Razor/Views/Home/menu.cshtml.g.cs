#pragma checksum "C:\Users\пк\Desktop\Cafe_project\CAFE\Views\Home\menu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "01013557cb7883330551ca9bf6741ffecd2efcb3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_menu), @"mvc.1.0.view", @"/Views/Home/menu.cshtml")]
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
#line 1 "C:\Users\пк\Desktop\Cafe_project\CAFE\Views\_ViewImports.cshtml"
using CAFE;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\пк\Desktop\Cafe_project\CAFE\Views\_ViewImports.cshtml"
using CAFE.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01013557cb7883330551ca9bf6741ffecd2efcb3", @"/Views/Home/menu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3fd85fbb743dc2cf8f6e8b79d960c0e2b811f9fa", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_menu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\пк\Desktop\Cafe_project\CAFE\Views\Home\menu.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("<!doctype html>\n<html lang=\"ru\">\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "01013557cb7883330551ca9bf6741ffecd2efcb33340", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"" />
    <title>Меню</title>
    <link rel=""shortcut icon"" href=""images/favicon.ico"" type=""image/x-icon"">
    <link rel=""preconnect"" href=""https://fonts.gstatic.com"">
    <link href=""https://fonts.googleapis.com/css2?family=Reem+Kufi&display=swap"" rel=""stylesheet"">
    <link href=""https://fonts.googleapis.com/css2?family=Montserrat&display=swap"" rel=""stylesheet"">
    <style>
        .navigation {
            position: absolute;
            width: 205px;
            height: 29px;
            left: 21px;
            top: 10px;
            font-family: Montserrat;
            font-style: normal;
            font-weight: 600;
            font-size: 24px;
            line-height: 29px;
            color: #000000;
        }

        .menu {
            position: absolute;
            width: 205px;
            height: 29px;
            left: 125px;
            top: 10px;
            font-family: Montserrat;
            font-style: normal;
            font-weight: 600;
            font-size: ");
                WriteLiteral(@"24px;
            line-height: 29px;
            color: #000000;
        }

        .ellipse1 {
            position: absolute;
            left: 0%;
            bottom: 0%;
        }

        .ellipse2 {
            position: absolute;
            right: 0%;
            top: 0%;
        }

        .flex-container {
            display: flex;
            flex-wrap: wrap;
        }

        .item {
            margin-top: 5%;
            text-align: center;
            flex: 0 0 33.333333%;
        }

        .item-text {
            width: 48%;
            margin-left: auto;
            margin-right: auto;
            font-family: Montserrat;
            font-size: 200%;
            line-height: 32px;
            color: #000000;
        }
        a {
            text-decoration:none;
        }
        .pic {
            height: 180px;
        }
    </style>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "01013557cb7883330551ca9bf6741ffecd2efcb36261", async() => {
                WriteLiteral("\n    <img src=\"images/ellipse1.png\" class=\"ellipse1\">\n    <img src=\"images/ellipse2.png\" class=\"ellipse2\">\n    <a href=\"/\"><div class=\"navigation\">Главная</div></a>\n    <a href=\"/menu\"><div class=\"menu\">>Меню</div></a>\n    <div class=\"flex-container\">\n");
#nullable restore
#line 88 "C:\Users\пк\Desktop\Cafe_project\CAFE\Views\Home\menu.cshtml"
         foreach (var m in ViewBag.mealtimes)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\"item\">\n                <a");
                BeginWriteAttribute("href", " href=\"", 2338, "\"", 2367, 2);
                WriteAttributeValue("", 2345, "/menu/", 2345, 6, true);
#nullable restore
#line 91 "C:\Users\пк\Desktop\Cafe_project\CAFE\Views\Home\menu.cshtml"
WriteAttributeValue("", 2351, m.mealtime_name, 2351, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n                    <div class=\"pic\"><img");
                BeginWriteAttribute("src", " src=\"", 2411, "\"", 2444, 3);
                WriteAttributeValue("", 2417, "images/2", 2417, 8, true);
#nullable restore
#line 92 "C:\Users\пк\Desktop\Cafe_project\CAFE\Views\Home\menu.cshtml"
WriteAttributeValue(" ", 2425, m.mealtimeId, 2426, 13, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue(" ", 2439, ".png", 2440, 5, true);
                EndWriteAttribute();
                WriteLiteral("></div>\n                    <div class=\"item-text\">");
#nullable restore
#line 93 "C:\Users\пк\Desktop\Cafe_project\CAFE\Views\Home\menu.cshtml"
                                      Write(m.mealtime_name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\n                </a>\n            </div>\n");
#nullable restore
#line 96 "C:\Users\пк\Desktop\Cafe_project\CAFE\Views\Home\menu.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</html>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
