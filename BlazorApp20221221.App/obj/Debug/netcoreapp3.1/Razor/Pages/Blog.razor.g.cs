#pragma checksum "C:\Users\Ahkar Toe Maw\source\repos\BlazorApp20221221\BlazorApp20221221.App\Pages\Blog.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "699eb75dec689c1c1657f13224298696616f936e"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp20221221.App.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Ahkar Toe Maw\source\repos\BlazorApp20221221\BlazorApp20221221.App\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ahkar Toe Maw\source\repos\BlazorApp20221221\BlazorApp20221221.App\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Ahkar Toe Maw\source\repos\BlazorApp20221221\BlazorApp20221221.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Ahkar Toe Maw\source\repos\BlazorApp20221221\BlazorApp20221221.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Ahkar Toe Maw\source\repos\BlazorApp20221221\BlazorApp20221221.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Ahkar Toe Maw\source\repos\BlazorApp20221221\BlazorApp20221221.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Ahkar Toe Maw\source\repos\BlazorApp20221221\BlazorApp20221221.App\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Ahkar Toe Maw\source\repos\BlazorApp20221221\BlazorApp20221221.App\_Imports.razor"
using BlazorApp20221221.App;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Ahkar Toe Maw\source\repos\BlazorApp20221221\BlazorApp20221221.App\_Imports.razor"
using BlazorApp20221221.App.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Ahkar Toe Maw\source\repos\BlazorApp20221221\BlazorApp20221221.App\_Imports.razor"
using BlazorApp20221221.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Ahkar Toe Maw\source\repos\BlazorApp20221221\BlazorApp20221221.App\_Imports.razor"
using BlazorApp20221221.Models.DataModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Ahkar Toe Maw\source\repos\BlazorApp20221221\BlazorApp20221221.App\_Imports.razor"
using BlazorApp20221221.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Ahkar Toe Maw\source\repos\BlazorApp20221221\BlazorApp20221221.App\_Imports.razor"
using BlazorApp20221221.DataAccess;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/blog")]
    public partial class Blog : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Blog</h3>\r\n");
            __builder.OpenElement(1, "form");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "form-group");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "input");
            __builder.AddAttribute(7, "type", "text");
            __builder.AddAttribute(8, "class", "form-control");
            __builder.AddAttribute(9, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 5 "C:\Users\Ahkar Toe Maw\source\repos\BlazorApp20221221\BlazorApp20221221.App\Pages\Blog.razor"
                                                              reqModel.BlogTitle

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => reqModel.BlogTitle = __value, reqModel.BlogTitle));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n        ");
            __builder.OpenElement(12, "input");
            __builder.AddAttribute(13, "type", "text");
            __builder.AddAttribute(14, "class", "form-control");
            __builder.AddAttribute(15, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 6 "C:\Users\Ahkar Toe Maw\source\repos\BlazorApp20221221\BlazorApp20221221.App\Pages\Blog.razor"
                                                              reqModel.BlogAuthor

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => reqModel.BlogAuthor = __value, reqModel.BlogAuthor));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n        ");
            __builder.OpenElement(18, "input");
            __builder.AddAttribute(19, "type", "text");
            __builder.AddAttribute(20, "class", "form-control");
            __builder.AddAttribute(21, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 7 "C:\Users\Ahkar Toe Maw\source\repos\BlazorApp20221221\BlazorApp20221221.App\Pages\Blog.razor"
                                                              reqModel.BlogContent

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => reqModel.BlogContent = __value, reqModel.BlogContent));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n    ");
            __builder.OpenElement(25, "button");
            __builder.AddAttribute(26, "type", "button");
            __builder.AddAttribute(27, "class", "btn btn-primary");
            __builder.AddAttribute(28, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "C:\Users\Ahkar Toe Maw\source\repos\BlazorApp20221221\BlazorApp20221221.App\Pages\Blog.razor"
                                                            Save

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(29, "Save");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n");
            __builder.OpenElement(32, "table");
            __builder.AddAttribute(33, "class", "table");
            __builder.AddMarkupContent(34, "\r\n    ");
            __builder.AddMarkupContent(35, "<thead>\r\n        <tr>\r\n            <th scope=\"col\">#</th>\r\n            <th scope=\"col\">Title</th>\r\n            <th scope=\"col\">Author</th>\r\n            <th scope=\"col\">Content</th>\r\n        </tr>\r\n    </thead>\r\n    ");
            __builder.OpenElement(36, "tbody");
            __builder.AddMarkupContent(37, "\r\n");
#nullable restore
#line 21 "C:\Users\Ahkar Toe Maw\source\repos\BlazorApp20221221\BlazorApp20221221.App\Pages\Blog.razor"
          
            int count = 0;
            foreach (var item in lst)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(38, "                ");
            __builder.OpenElement(39, "tr");
            __builder.AddMarkupContent(40, "\r\n                    ");
            __builder.OpenElement(41, "td");
#nullable restore
#line 26 "C:\Users\Ahkar Toe Maw\source\repos\BlazorApp20221221\BlazorApp20221221.App\Pages\Blog.razor"
__builder.AddContent(42, ++count);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n                    ");
            __builder.OpenElement(44, "td");
#nullable restore
#line 27 "C:\Users\Ahkar Toe Maw\source\repos\BlazorApp20221221\BlazorApp20221221.App\Pages\Blog.razor"
__builder.AddContent(45, item.BlogTitle);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n                    ");
            __builder.OpenElement(47, "td");
#nullable restore
#line 28 "C:\Users\Ahkar Toe Maw\source\repos\BlazorApp20221221\BlazorApp20221221.App\Pages\Blog.razor"
__builder.AddContent(48, item.BlogAuthor);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n                    ");
            __builder.OpenElement(50, "td");
#nullable restore
#line 29 "C:\Users\Ahkar Toe Maw\source\repos\BlazorApp20221221\BlazorApp20221221.App\Pages\Blog.razor"
__builder.AddContent(51, item.BlogContent);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n");
#nullable restore
#line 31 "C:\Users\Ahkar Toe Maw\source\repos\BlazorApp20221221\BlazorApp20221221.App\Pages\Blog.razor"
            }
        

#line default
#line hidden
#nullable disable
            __builder.AddContent(54, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
