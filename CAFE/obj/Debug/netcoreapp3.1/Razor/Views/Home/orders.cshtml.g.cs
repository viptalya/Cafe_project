#pragma checksum "C:\Users\пк\Desktop\Cafe_project\CAFE\Views\Home\orders.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c63db93fc51eb949ea0d2683fd4d4e60821001c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_orders), @"mvc.1.0.view", @"/Views/Home/orders.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c63db93fc51eb949ea0d2683fd4d4e60821001c", @"/Views/Home/orders.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3fd85fbb743dc2cf8f6e8b79d960c0e2b811f9fa", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_orders : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CAFE.Models.order>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Logincourier", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Addcourier", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\пк\Desktop\Cafe_project\CAFE\Views\Home\orders.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("<link href=\"https://fonts.googleapis.com/css2?family=Reem+Kufi&display=swap\" rel=\"stylesheet\">\r\n<link href=\"https://fonts.googleapis.com/css2?family=Montserrat&display=swap\" rel=\"stylesheet\">\r\n");
#nullable restore
#line 7 "C:\Users\пк\Desktop\Cafe_project\CAFE\Views\Home\orders.cshtml"
 if (User.Identity.IsAuthenticated)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>");
#nullable restore
#line 9 "C:\Users\пк\Desktop\Cafe_project\CAFE\Views\Home\orders.cshtml"
  Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>ЗАКАЗЫ</p>\r\n    <table>\r\n");
#nullable restore
#line 12 "C:\Users\пк\Desktop\Cafe_project\CAFE\Views\Home\orders.cshtml"
         foreach (var c in ViewBag.Orders)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td><p>");
#nullable restore
#line 15 "C:\Users\пк\Desktop\Cafe_project\CAFE\Views\Home\orders.cshtml"
              Write(c.orderId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></td>\r\n            <td><p>");
#nullable restore
#line 16 "C:\Users\пк\Desktop\Cafe_project\CAFE\Views\Home\orders.cshtml"
              Write(c.order_time);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></td>\r\n            <td><p>");
#nullable restore
#line 17 "C:\Users\пк\Desktop\Cafe_project\CAFE\Views\Home\orders.cshtml"
              Write(c.price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></td>\r\n");
#nullable restore
#line 18 "C:\Users\пк\Desktop\Cafe_project\CAFE\Views\Home\orders.cshtml"
             foreach (var k in ViewBag.Customers)
            {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\пк\Desktop\Cafe_project\CAFE\Views\Home\orders.cshtml"
                     if (k.customerId == c.customerId)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td><p>");
#nullable restore
#line 23 "C:\Users\пк\Desktop\Cafe_project\CAFE\Views\Home\orders.cshtml"
                              Write(k.cus_Sname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></td>\r\n                            <td><p>");
#nullable restore
#line 24 "C:\Users\пк\Desktop\Cafe_project\CAFE\Views\Home\orders.cshtml"
                              Write(k.cus_Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></td>\r\n                            <td><p>");
#nullable restore
#line 25 "C:\Users\пк\Desktop\Cafe_project\CAFE\Views\Home\orders.cshtml"
                              Write(k.cus_Pname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></td>\r\n                            <td><p>");
#nullable restore
#line 26 "C:\Users\пк\Desktop\Cafe_project\CAFE\Views\Home\orders.cshtml"
                              Write(k.cus_number);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></td>\r\n                        </tr>\r\n");
#nullable restore
#line 28 "C:\Users\пк\Desktop\Cafe_project\CAFE\Views\Home\orders.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\пк\Desktop\Cafe_project\CAFE\Views\Home\orders.cshtml"
                     
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\пк\Desktop\Cafe_project\CAFE\Views\Home\orders.cshtml"
             foreach (var x in ViewBag.Mos)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\пк\Desktop\Cafe_project\CAFE\Views\Home\orders.cshtml"
                 if (c.orderId == x.orderId)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td><p>");
#nullable restore
#line 35 "C:\Users\пк\Desktop\Cafe_project\CAFE\Views\Home\orders.cshtml"
                          Write(x.order_items_quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></td>\r\n");
#nullable restore
#line 36 "C:\Users\пк\Desktop\Cafe_project\CAFE\Views\Home\orders.cshtml"
                         foreach (var z in ViewBag.menu_items)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\пк\Desktop\Cafe_project\CAFE\Views\Home\orders.cshtml"
                             if (x.menu_itemId == z.menu_itemId)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td><p>");
#nullable restore
#line 40 "C:\Users\пк\Desktop\Cafe_project\CAFE\Views\Home\orders.cshtml"
                                  Write(z.menu_item_name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></td>\r\n");
#nullable restore
#line 41 "C:\Users\пк\Desktop\Cafe_project\CAFE\Views\Home\orders.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\пк\Desktop\Cafe_project\CAFE\Views\Home\orders.cshtml"
                             
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tr>\r\n");
#nullable restore
#line 44 "C:\Users\пк\Desktop\Cafe_project\CAFE\Views\Home\orders.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\Users\пк\Desktop\Cafe_project\CAFE\Views\Home\orders.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td><p><a");
            BeginWriteAttribute("href", " href=\"", 1627, "\"", 1634, 0);
            EndWriteAttribute();
            WriteLiteral(">Взять заказ</a></p></td>\r\n        </tr>\r\n");
#nullable restore
#line 48 "C:\Users\пк\Desktop\Cafe_project\CAFE\Views\Home\orders.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c63db93fc51eb949ea0d2683fd4d4e60821001c11422", async() => {
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Выход\" />\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 53 "C:\Users\пк\Desktop\Cafe_project\CAFE\Views\Home\orders.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c63db93fc51eb949ea0d2683fd4d4e60821001c13506", async() => {
                WriteLiteral("Вход");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c63db93fc51eb949ea0d2683fd4d4e60821001c14870", async() => {
                WriteLiteral("Регистрация");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 58 "C:\Users\пк\Desktop\Cafe_project\CAFE\Views\Home\orders.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CAFE.Models.order> Html { get; private set; }
    }
}
#pragma warning restore 1591
