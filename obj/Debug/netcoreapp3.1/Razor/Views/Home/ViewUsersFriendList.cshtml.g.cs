#pragma checksum "C:\Users\joeld\Desktop\C#\Project\Views\Home\ViewUsersFriendList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e19f8d2a33191913e6355a07ec98d1e86cbe8d0a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ViewUsersFriendList), @"mvc.1.0.view", @"/Views/Home/ViewUsersFriendList.cshtml")]
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
#line 1 "C:\Users\joeld\Desktop\C#\Project\Views\_ViewImports.cshtml"
using C_Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\joeld\Desktop\C#\Project\Views\_ViewImports.cshtml"
using C_Project.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e19f8d2a33191913e6355a07ec98d1e86cbe8d0a", @"/Views/Home/ViewUsersFriendList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6f317e8aec25df0a119fc927c1dcb1b7b3cd0f8", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ViewUsersFriendList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h3 class=\"text-center\">");
#nullable restore
#line 1 "C:\Users\joeld\Desktop\C#\Project\Views\Home\ViewUsersFriendList.cshtml"
                   Write(ViewBag.OneUser.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\'s friendlist</h3>\r\n<ul>\r\n");
#nullable restore
#line 3 "C:\Users\joeld\Desktop\C#\Project\Views\Home\ViewUsersFriendList.cshtml"
     foreach (FriendList row in ViewBag.FriendFriendlist.Users)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li> <img style=\"height:100px; width:100px; object-fit: cover; border-radius: 50%;\"");
            BeginWriteAttribute("src", " src=\"", 234, "\"", 256, 1);
#nullable restore
#line 5 "C:\Users\joeld\Desktop\C#\Project\Views\Home\ViewUsersFriendList.cshtml"
WriteAttributeValue("", 240, row.Users.Photo, 240, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 257, "\"", 278, 1);
#nullable restore
#line 5 "C:\Users\joeld\Desktop\C#\Project\Views\Home\ViewUsersFriendList.cshtml"
WriteAttributeValue("", 263, row.Users.Name, 263, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> <a");
            BeginWriteAttribute("href", " href=\"", 283, "\"", 319, 2);
            WriteAttributeValue("", 290, "ViewOneUser/", 290, 12, true);
#nullable restore
#line 5 "C:\Users\joeld\Desktop\C#\Project\Views\Home\ViewUsersFriendList.cshtml"
WriteAttributeValue("", 302, row.Users.UserId, 302, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> ");
#nullable restore
#line 5 "C:\Users\joeld\Desktop\C#\Project\Views\Home\ViewUsersFriendList.cshtml"
                                                                                                                                                                              Write(row.Users.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a> </li> <br>\r\n");
#nullable restore
#line 6 "C:\Users\joeld\Desktop\C#\Project\Views\Home\ViewUsersFriendList.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>");
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
