#pragma checksum "C:\Users\anyap\OneDrive\Рабочий стол\Новая папка\web\lab1\lab1\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0311f65af82cf38cfba36b5dc12053f7e31135c9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\anyap\OneDrive\Рабочий стол\Новая папка\web\lab1\lab1\Views\_ViewImports.cshtml"
using lab1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\anyap\OneDrive\Рабочий стол\Новая папка\web\lab1\lab1\Views\_ViewImports.cshtml"
using lab1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0311f65af82cf38cfba36b5dc12053f7e31135c9", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1b856ffc28bb915aac4f86c443e1a63cacffcc6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\anyap\OneDrive\Рабочий стол\Новая папка\web\lab1\lab1\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    <h1 class=\"display-4\">Calc Service Demonstration</h1>\r\n    <ul>\r\n        <li>\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 151, "\"", 187, 1);
#nullable restore
#line 9 "C:\Users\anyap\OneDrive\Рабочий стол\Новая папка\web\lab1\lab1\Views\Home\Index.cshtml"
WriteAttributeValue("", 158, Url.Action("ViewModel","My"), 158, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> Using Model Calc </a>\r\n        </li>\r\n        <li>\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 256, "\"", 294, 1);
#nullable restore
#line 12 "C:\Users\anyap\OneDrive\Рабочий стол\Новая папка\web\lab1\lab1\Views\Home\Index.cshtml"
WriteAttributeValue("", 263, Url.Action("ViewDataRes","My"), 263, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> Using ViewData Calc </a>\r\n        </li>\r\n        <li>\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 366, "\"", 403, 1);
#nullable restore
#line 15 "C:\Users\anyap\OneDrive\Рабочий стол\Новая папка\web\lab1\lab1\Views\Home\Index.cshtml"
WriteAttributeValue("", 373, Url.Action("ViewBagRes","My"), 373, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> Using ViewBag Calc </a>\r\n        </li>\r\n        <li>\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 474, "\"", 512, 1);
#nullable restore
#line 18 "C:\Users\anyap\OneDrive\Рабочий стол\Новая папка\web\lab1\lab1\Views\Home\Index.cshtml"
WriteAttributeValue("", 481, Url.Action("ViewService","My"), 481, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> Using Service Injection Calc </a>\r\n        </li>\r\n    </ul>\r\n</div>");
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