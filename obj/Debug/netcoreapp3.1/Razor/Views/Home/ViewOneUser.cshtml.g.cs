#pragma checksum "C:\Users\joeld\Desktop\C#\Project\Views\Home\ViewOneUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "70483d512c97f145dbb7c9a52b1c02a5cc603cda"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ViewOneUser), @"mvc.1.0.view", @"/Views/Home/ViewOneUser.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70483d512c97f145dbb7c9a52b1c02a5cc603cda", @"/Views/Home/ViewOneUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6f317e8aec25df0a119fc927c1dcb1b7b3cd0f8", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ViewOneUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            BeginWriteAttribute("src", " src=\"", 369, "\"", 397, 1);
#nullable restore
#line 16 "C:\Users\joeld\Desktop\C#\Project\Views\Home\ViewOneUser.cshtml"
WriteAttributeValue("", 375, ViewBag.OneUser.Photo, 375, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 398, "\"", 439, 4);
#nullable restore
#line 16 "C:\Users\joeld\Desktop\C#\Project\Views\Home\ViewOneUser.cshtml"
WriteAttributeValue("", 404, ViewBag.OneUser.Name, 404, 21, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 425, "\'s", 425, 2, true);
            WriteAttributeValue(" ", 427, "profile", 428, 8, true);
            WriteAttributeValue(" ", 435, "pic", 436, 4, true);
            EndWriteAttribute();
            WriteLiteral(" style=\"height:100px; width:100px; object-fit: cover; border-radius: 50%;\">\r\n        </div>\r\n    </div>\r\n    <div id=\"Container3\" style=\"height:100px;\">\r\n        <div id=\"LinkBar\"> \r\n            <a");
            BeginWriteAttribute("href", " href=\"", 637, "\"", 685, 2);
            WriteAttributeValue("", 644, "/ViewUsersFriends/", 644, 18, true);
#nullable restore
#line 21 "C:\Users\joeld\Desktop\C#\Project\Views\Home\ViewOneUser.cshtml"
WriteAttributeValue("", 662, ViewBag.OneUser.UserId, 662, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> View Friends </a> | <a href=\"/ViewAllUsers\"> View Users </a> | <a href=\"/CreatePost\"> Create New Post </a> | <a href=\"#\"> Direct Message </a>\r\n        </div>\r\n    </div>\r\n</div>\r\n<div>\r\n    ");
#nullable restore
#line 26 "C:\Users\joeld\Desktop\C#\Project\Views\Home\ViewOneUser.cshtml"
Write(ViewBag.OneUser.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br>\r\n");
#nullable restore
#line 27 "C:\Users\joeld\Desktop\C#\Project\Views\Home\ViewOneUser.cshtml"
      
        bool found = false;
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\joeld\Desktop\C#\Project\Views\Home\ViewOneUser.cshtml"
         foreach (FriendList row in ViewBag.UserFriendList.Friend)
        {
            if( row.FriendId == ViewBag.OneUser.UserId)
            {
                found = true;
            } 

        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\joeld\Desktop\C#\Project\Views\Home\ViewOneUser.cshtml"
         
        if(found)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <a");
            BeginWriteAttribute("href", " href=\"", 1198, "\"", 1242, 2);
            WriteAttributeValue("", 1205, "/RemoveFriend/", 1205, 14, true);
#nullable restore
#line 39 "C:\Users\joeld\Desktop\C#\Project\Views\Home\ViewOneUser.cshtml"
WriteAttributeValue("", 1219, ViewBag.OneUser.UserId, 1219, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Remove Friend</a> <br>\r\n");
#nullable restore
#line 40 "C:\Users\joeld\Desktop\C#\Project\Views\Home\ViewOneUser.cshtml"
        } else{

#line default
#line hidden
#nullable disable
            WriteLiteral("            <a");
            BeginWriteAttribute("href", " href=\"", 1299, "\"", 1340, 2);
            WriteAttributeValue("", 1306, "/AddFriend/", 1306, 11, true);
#nullable restore
#line 41 "C:\Users\joeld\Desktop\C#\Project\Views\Home\ViewOneUser.cshtml"
WriteAttributeValue("", 1317, ViewBag.OneUser.UserId, 1317, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Add Friend</a> <br>\r\n");
#nullable restore
#line 42 "C:\Users\joeld\Desktop\C#\Project\Views\Home\ViewOneUser.cshtml"
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<div id=\"postContainer\">\r\n");
#nullable restore
#line 46 "C:\Users\joeld\Desktop\C#\Project\Views\Home\ViewOneUser.cshtml"
     foreach(UserPost row in ViewBag.AllPost)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div style=\"background-color: black; width: 50vw; margin: 15px auto; padding: 10px;\" id=\"Post\">\r\n            <p>Posted By: ");
#nullable restore
#line 49 "C:\Users\joeld\Desktop\C#\Project\Views\Home\ViewOneUser.cshtml"
                     Write(row.PostedBY.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" On ");
#nullable restore
#line 49 "C:\Users\joeld\Desktop\C#\Project\Views\Home\ViewOneUser.cshtml"
                                           Write(row.CreatedAt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            ");
#nullable restore
#line 50 "C:\Users\joeld\Desktop\C#\Project\Views\Home\ViewOneUser.cshtml"
       Write(row.PostContent);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 52 "C:\Users\joeld\Desktop\C#\Project\Views\Home\ViewOneUser.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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