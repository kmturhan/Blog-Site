#pragma checksum "G:\Taze-Project\WebApplication1\WebApplication1\Views\Home\DetailPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c616087ae4c4d10f371790c7cb77436d4f0ca6a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_DetailPage), @"mvc.1.0.view", @"/Views/Home/DetailPage.cshtml")]
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
#line 1 "G:\Taze-Project\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c616087ae4c4d10f371790c7cb77436d4f0ca6a", @"/Views/Home/DetailPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99dd170d95206ce8ea10a491a4597f2c07e4f445", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_DetailPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MergeClass>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "G:\Taze-Project\WebApplication1\WebApplication1\Views\Home\DetailPage.cshtml"
  
    ViewData["Title"] = "DetailPage";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n    <div class=\"container\">\r\n        \r\n        <div class=\"row\">\r\n");
#nullable restore
#line 12 "G:\Taze-Project\WebApplication1\WebApplication1\Views\Home\DetailPage.cshtml"
             foreach (var item in Model.mainList)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <!-- Post Content Column -->\r\n            <div class=\"col-lg-8\">\r\n\r\n                <!-- Title -->\r\n                <h1 class=\"mt-4\">");
#nullable restore
#line 18 "G:\Taze-Project\WebApplication1\WebApplication1\Views\Home\DetailPage.cshtml"
                            Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n                <!-- Author -->\r\n                <hr>\r\n                <!-- Date/Time -->\r\n                <p>Posted on ");
#nullable restore
#line 23 "G:\Taze-Project\WebApplication1\WebApplication1\Views\Home\DetailPage.cshtml"
                        Write(item.Create_Time);

#line default
#line hidden
#nullable disable
            WriteLiteral(".</p>\r\n                <hr>\r\n                <!-- Preview Image -->\r\n                <img class=\"img-fluid rounded\" src=\"http://placehold.it/900x300\"");
            BeginWriteAttribute("alt", " alt=\"", 705, "\"", 711, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                <hr>\r\n                <!-- Post Content -->\r\n                <p class=\"lead\">\r\n                    ");
#nullable restore
#line 30 "G:\Taze-Project\WebApplication1\WebApplication1\Views\Home\DetailPage.cshtml"
               Write(item.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>\r\n                <p class=\"lead\">\r\n                    ");
#nullable restore
#line 33 "G:\Taze-Project\WebApplication1\WebApplication1\Views\Home\DetailPage.cshtml"
               Write(item.Short_Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>\r\n                <hr>\r\n            </div>\r\n");
#nullable restore
#line 37 "G:\Taze-Project\WebApplication1\WebApplication1\Views\Home\DetailPage.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

            <!-- Sidebar Widgets Column -->
            <div class=""col-md-4"">
                <!-- Search Widget -->
                <div class=""card my-4"">
                    <h5 class=""card-header"">Create New Post</h5>
                    <div class=""card-body"">
                        <div class=""input-group"">
                            ");
#nullable restore
#line 47 "G:\Taze-Project\WebApplication1\WebApplication1\Views\Home\DetailPage.cshtml"
                       Write(Html.ActionLink("Create New", "AddOrEdit", "Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>
                    </div>
                </div>
                <!-- Categories Widget -->
                <div class=""card my-4"">
                    <h5 class=""card-header"">Categories</h5>
                    <div class=""card-body"">
                        <div class=""row"">
                            <div class=""col-lg-6"">
                                <ul class=""list-unstyled mb-0"">
");
#nullable restore
#line 58 "G:\Taze-Project\WebApplication1\WebApplication1\Views\Home\DetailPage.cshtml"
                                     foreach (var item in Model.categoryName)
                                    {
                                        if (item != null)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <li>\r\n                                                ");
#nullable restore
#line 63 "G:\Taze-Project\WebApplication1\WebApplication1\Views\Home\DetailPage.cshtml"
                                           Write(Html.ActionLink(item, "CategoryPost", "Home", new { test = item }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </li>\r\n");
#nullable restore
#line 65 "G:\Taze-Project\WebApplication1\WebApplication1\Views\Home\DetailPage.cshtml"
                                        }
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </ul>
                            </div>
                        </div>
                    </div>
                </div>

                <!-- Side Widget -->
                <div class=""card my-4"">
                    <h5 class=""card-header"">Side Widget</h5>
                    <div class=""card-body"">
                        You can put anything you want inside of these side widgets. They are easy to use, and feature the new Bootstrap 4 card containers!
                    </div>
                </div>

            </div>

        </div>
        <!-- /.row -->
    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MergeClass> Html { get; private set; }
    }
}
#pragma warning restore 1591
