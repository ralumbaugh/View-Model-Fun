#pragma checksum "C:\Users\Ryan\CSharpStack\ViewModelFun\Views\Home\Users.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d3f5f6079c0c534a6edf71ca478ac030d2a74d3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Users), @"mvc.1.0.view", @"/Views/Home/Users.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Users.cshtml", typeof(AspNetCore.Views_Home_Users))]
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
#line 1 "C:\Users\Ryan\CSharpStack\ViewModelFun\Views\_ViewImports.cshtml"
using ViewModelFun;

#line default
#line hidden
#line 2 "C:\Users\Ryan\CSharpStack\ViewModelFun\Views\_ViewImports.cshtml"
using ViewModelFun.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d3f5f6079c0c534a6edf71ca478ac030d2a74d3", @"/Views/Home/Users.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7312364e6c23e4cb7805f9e5f986831fce186000", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Users : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<User>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(19, 118, true);
            WriteLiteral("<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Here are some users!</h1>\r\n</div>\r\n<div class=\"card\">\r\n    <ul>\r\n");
            EndContext();
#line 7 "C:\Users\Ryan\CSharpStack\ViewModelFun\Views\Home\Users.cshtml"
         foreach(User user in Model){

#line default
#line hidden
            BeginContext(176, 36, true);
            WriteLiteral("            <li class=\"text-center\">");
            EndContext();
            BeginContext(213, 14, false);
#line 8 "C:\Users\Ryan\CSharpStack\ViewModelFun\Views\Home\Users.cshtml"
                               Write(user.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(227, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(229, 13, false);
#line 8 "C:\Users\Ryan\CSharpStack\ViewModelFun\Views\Home\Users.cshtml"
                                               Write(user.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(242, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 9 "C:\Users\Ryan\CSharpStack\ViewModelFun\Views\Home\Users.cshtml"
        }

#line default
#line hidden
            BeginContext(260, 17, true);
            WriteLiteral("    </ul>\r\n</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<User>> Html { get; private set; }
    }
}
#pragma warning restore 1591
