#pragma checksum "C:\Users\joeld\Desktop\C#\Project\Views\Home\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73f58dea36e3205fe21d2a9e1751bb8622e6ede6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Dashboard), @"mvc.1.0.view", @"/Views/Home/Dashboard.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"73f58dea36e3205fe21d2a9e1751bb8622e6ede6", @"/Views/Home/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6f317e8aec25df0a119fc927c1dcb1b7b3cd0f8", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<style>
    #Container1{
        display:flex;
        align-content: center;
    }
    #Container3{
        align-items: center;
    }
    #postContainer{
        
    }
</style>
<div id=""Container1"">
    <div id=""Container2"" style=""background-color: white; height:100px; width:100px; border-radius: 50%;"">
        <div id=""ProfilePic"">
            <img");
            BeginWriteAttribute("src", " src=\"", 369, "\"", 400, 1);
#nullable restore
#line 16 "C:\Users\joeld\Desktop\C#\Project\Views\Home\Dashboard.cshtml"
WriteAttributeValue("", 375, ViewBag.LoggedUser.Photo, 375, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 401, "\"", 445, 4);
#nullable restore
#line 16 "C:\Users\joeld\Desktop\C#\Project\Views\Home\Dashboard.cshtml"
WriteAttributeValue("", 407, ViewBag.LoggedUser.Name, 407, 24, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 431, "\'s", 431, 2, true);
            WriteAttributeValue(" ", 433, "profile", 434, 8, true);
            WriteAttributeValue(" ", 441, "pic", 442, 4, true);
            EndWriteAttribute();
            WriteLiteral(@" style=""height:100px; width:100px; object-fit: cover; border-radius: 50%;"">
        </div>
    </div>
    <div id=""Container3"" style=""height:100px;"">
        <div id=""LinkBar""> 
            <a href=""/ViewFriends""> View Friends </a> | <a href=""/ViewAllUsers""> View Users </a> | <a href=""/CreatePost""> Create New Post </a> | <a href=""/ViewDirectMesseges""> Direct Message </a>
        </div>
    </div>
</div>
<div>
    ");
#nullable restore
#line 26 "C:\Users\joeld\Desktop\C#\Project\Views\Home\Dashboard.cshtml"
Write(ViewBag.LoggedUser.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br>\r\n    <a href=\"/AddProfilePic\">Add Profile Pic</a> <br>\r\n    <a");
            BeginWriteAttribute("href", " href=\"", 965, "\"", 1014, 2);
            WriteAttributeValue("", 972, "/ViewLoggedUser/", 972, 16, true);
#nullable restore
#line 28 "C:\Users\joeld\Desktop\C#\Project\Views\Home\Dashboard.cshtml"
WriteAttributeValue("", 988, ViewBag.LoggedUser.UserId, 988, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">View Your Post </a>\r\n</div>\r\n<div id=\"postContainer\">\r\n");
#nullable restore
#line 31 "C:\Users\joeld\Desktop\C#\Project\Views\Home\Dashboard.cshtml"
     foreach(UserPost row in ViewBag.AllPost)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div style=\"background-color: black; width: 50vw; margin: 15px auto; padding: 10px;\" id=\"Post\">\r\n            <p>Posted By: ");
#nullable restore
#line 34 "C:\Users\joeld\Desktop\C#\Project\Views\Home\Dashboard.cshtml"
                     Write(row.PostedBY.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" On ");
#nullable restore
#line 34 "C:\Users\joeld\Desktop\C#\Project\Views\Home\Dashboard.cshtml"
                                           Write(row.CreatedAt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            ");
#nullable restore
#line 35 "C:\Users\joeld\Desktop\C#\Project\Views\Home\Dashboard.cshtml"
       Write(row.PostContent);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 37 "C:\Users\joeld\Desktop\C#\Project\Views\Home\Dashboard.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
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
