#pragma checksum "C:\Users\пк\Desktop\Cafe_project-master\CAFE\Views\Home\Addcustomer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d7f639683a14e5ee16bd640b0142e19a1b7d31f7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Addcustomer), @"mvc.1.0.view", @"/Views/Home/Addcustomer.cshtml")]
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
#line 1 "C:\Users\пк\Desktop\Cafe_project-master\CAFE\Views\_ViewImports.cshtml"
using CAFE;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\пк\Desktop\Cafe_project-master\CAFE\Views\_ViewImports.cshtml"
using CAFE.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7f639683a14e5ee16bd640b0142e19a1b7d31f7", @"/Views/Home/Addcustomer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3fd85fbb743dc2cf8f6e8b79d960c0e2b811f9fa", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Addcustomer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "C:\Users\пк\Desktop\Cafe_project-master\CAFE\Views\Home\Addcustomer.cshtml"
  
    ViewBag.Title = "Addcustomer";
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    .Rectangle {
        position: absolute;
        width: 600px;
        height: 500px;
        left: 420px;
        top: 82px;
        background: #FFFFFF;
        border: 2px solid #E5E5E5;
        box-sizing: border-box;
    }
    .ellipse1 {
        position: absolute;
        left: 0px;
        top: 572px;
    }
    .ellipse2 {
        position: absolute;
        right: 0%;
        top: 0%;
    }
    .add {
        width: 511px;
        position: absolute;
        top: 50px;
        right: 50px;
        background: #FFFFFF;
        border: 2px solid #FF6D03;
        border-radius: 3px;
    }
    .add1 {
        width: 511px;
        position: absolute;
        top: 130px;
        right: 50px;
        background: #FFFFFF;
        border: 2px solid #FF6D03;
        border-radius: 3px;
    }
    .add2 {
        width: 511px;
        position: absolute;
        top: 210px;
        right: 50px;
        background: #FFFFFF;
        border: 2px solid #FF6D03;
        border-radius: 3px;
    }
    .add");
            WriteLiteral(@"3 {
        width: 511px;
        position: absolute;
        top: 290px;
        right: 50px;
        background: #FFFFFF;
        border: 2px solid #FF6D03;
        border-radius: 3px;
    }
    .add4 {
        width: 511px;
        position: absolute;
        top: 370px;
        right: 50px;
        background: #FFFFFF;
        border: 2px solid #FF6D03;
        border-radius: 3px;
    }
    .Sname {
        position: absolute;
        left: 50px;
        top: 10px;
    }
    .Name {
        position: absolute;
        left: 50px;
        top: 90px;
    }
    .Pname {
        position: absolute;
        left: 50px;
        top: 170px;
    }
    .Number {
        position: absolute;
        left: 50px;
        top: 250px;
    }
    .Email {
        position: absolute;
        left: 50px;
        top: 330px;
    }
    .zzzz {
        position: absolute;
        height: 30px;
        left: 40.69%;
        right: 40.62%;
        bottom: 20px;
        background: #FF6D03;
        border: 6px solid #FF6D03;
    ");
            WriteLiteral("    border-radius: 6px;\n    }\n</style>\n<img src=\"/images/ellipse1.png\" class=\"ellipse1\" />\n<img src=\"/images/ellipse2.png\" class=\"ellipse2\" />\n<div class=\"Rectangle\">\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d7f639683a14e5ee16bd640b0142e19a1b7d31f76345", async() => {
                WriteLiteral("\n        <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 2337, "\"", 2363, 1);
#nullable restore
#line 111 "C:\Users\пк\Desktop\Cafe_project-master\CAFE\Views\Home\Addcustomer.cshtml"
WriteAttributeValue("", 2345, ViewBag.customers, 2345, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
        <table>
            <tr>
                <td class=""Sname""><p>Фамилия</p></td>
                <td><input type=""text"" name=""cus_Sname"" class=""add"" /></td>
                <td class=""Name""><p>Имя</p></td>
                <td><input type=""text"" name=""cus_Name"" class=""add1"" /></td>
                <td class=""Pname""><p>Отчество</p></td>
                <td><input type=""text"" name=""cus_Pname"" class=""add2"" /></td>
                <td class=""Number""><p>Номер телефона</p></td>
                <td><input type=""text"" name=""cus_number"" class=""add3"" /></td>
                <td class=""Email""><p>Почта</p></td>
                <td><input type=""text"" name=""cus_email"" class=""add4"" /></td>
            </tr>
            <tr><td><input type=""submit"" value=""Заказать"" class=""zzzz"" /> </td><td></td></tr>
        </table>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>\n");
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
