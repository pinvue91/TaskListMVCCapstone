#pragma checksum "C:\Users\pin\source\repos\ToDoMVC\ToDoMVC\Views\ToDoMVC\Users.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3301251ad4b23841dd5c9d824aa7ed517d49f596"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ToDoMVC_Users), @"mvc.1.0.view", @"/Views/ToDoMVC/Users.cshtml")]
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
#line 1 "C:\Users\pin\source\repos\ToDoMVC\ToDoMVC\Views\_ViewImports.cshtml"
using ToDoMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\pin\source\repos\ToDoMVC\ToDoMVC\Views\_ViewImports.cshtml"
using ToDoMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3301251ad4b23841dd5c9d824aa7ed517d49f596", @"/Views/ToDoMVC/Users.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bdf43cfe5def8d5b68cb30948f0b89beef1c94b4", @"/Views/_ViewImports.cshtml")]
    public class Views_ToDoMVC_Users : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AspNetUsers>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n    <h2>Here are our users:</h2>\r\n\r\n");
#nullable restore
#line 5 "C:\Users\pin\source\repos\ToDoMVC\ToDoMVC\Views\ToDoMVC\Users.cshtml"
 foreach(AspNetUsers user in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p><b>User Name:</b> ");
#nullable restore
#line 7 "C:\Users\pin\source\repos\ToDoMVC\ToDoMVC\Views\ToDoMVC\Users.cshtml"
                    Write(user.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p><b>User ID:</b> ");
#nullable restore
#line 8 "C:\Users\pin\source\repos\ToDoMVC\ToDoMVC\Views\ToDoMVC\Users.cshtml"
                  Write(user.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <hr />\r\n");
#nullable restore
#line 10 "C:\Users\pin\source\repos\ToDoMVC\ToDoMVC\Views\ToDoMVC\Users.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<AspNetUsers>> Html { get; private set; }
    }
}
#pragma warning restore 1591
