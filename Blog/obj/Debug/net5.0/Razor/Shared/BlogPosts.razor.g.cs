#pragma checksum "C:\Users\Marko\Desktop\Seminar_C#_solo\seminar_backend_test\Blog\Shared\BlogPosts.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "59093961bbaf876100fc0fd229333d46dd6e2adb"
// <auto-generated/>
#pragma warning disable 1591
namespace Blog.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Marko\Desktop\Seminar_C#_solo\seminar_backend_test\Blog\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Marko\Desktop\Seminar_C#_solo\seminar_backend_test\Blog\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Marko\Desktop\Seminar_C#_solo\seminar_backend_test\Blog\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Marko\Desktop\Seminar_C#_solo\seminar_backend_test\Blog\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Marko\Desktop\Seminar_C#_solo\seminar_backend_test\Blog\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Marko\Desktop\Seminar_C#_solo\seminar_backend_test\Blog\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Marko\Desktop\Seminar_C#_solo\seminar_backend_test\Blog\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Marko\Desktop\Seminar_C#_solo\seminar_backend_test\Blog\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Marko\Desktop\Seminar_C#_solo\seminar_backend_test\Blog\_Imports.razor"
using Blog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Marko\Desktop\Seminar_C#_solo\seminar_backend_test\Blog\_Imports.razor"
using Blog.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Marko\Desktop\Seminar_C#_solo\seminar_backend_test\Blog\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Marko\Desktop\Seminar_C#_solo\seminar_backend_test\Blog\Shared\BlogPosts.razor"
using Blog.Models;

#line default
#line hidden
#nullable disable
    public partial class BlogPosts : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 7 "C:\Users\Marko\Desktop\Seminar_C#_solo\seminar_backend_test\Blog\Shared\BlogPosts.razor"
 foreach (var post in Posts)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "post-item col-12 border p-3 mt-3");
            __builder.AddAttribute(2, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "C:\Users\Marko\Desktop\Seminar_C#_solo\seminar_backend_test\Blog\Shared\BlogPosts.razor"
                                                            () => navigateToPost(post.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "post-item-header");
            __builder.OpenElement(5, "h3");
            __builder.AddContent(6, 
#nullable restore
#line 12 "C:\Users\Marko\Desktop\Seminar_C#_solo\seminar_backend_test\Blog\Shared\BlogPosts.razor"
                 post.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n            ");
            __builder.OpenElement(8, "p");
            __builder.AddContent(9, 
#nullable restore
#line 15 "C:\Users\Marko\Desktop\Seminar_C#_solo\seminar_backend_test\Blog\Shared\BlogPosts.razor"
                 post.DateCreated

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n\r\n        ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "post-item-info");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "post-item-info-left");
            __builder.AddContent(15, 
#nullable restore
#line 21 "C:\Users\Marko\Desktop\Seminar_C#_solo\seminar_backend_test\Blog\Shared\BlogPosts.razor"
                 post.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n            ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "post-item-info-right");
            __builder.AddContent(19, 
#nullable restore
#line 24 "C:\Users\Marko\Desktop\Seminar_C#_solo\seminar_backend_test\Blog\Shared\BlogPosts.razor"
                 post.User.UserName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 28 "C:\Users\Marko\Desktop\Seminar_C#_solo\seminar_backend_test\Blog\Shared\BlogPosts.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "C:\Users\Marko\Desktop\Seminar_C#_solo\seminar_backend_test\Blog\Shared\BlogPosts.razor"
       
    private List<Post> Posts = new List<Post>();
    protected override async Task OnInitializedAsync()
    {
        await jsRuntime.InvokeVoidAsync("console.log", "OnInitializedAsync");
        await jsRuntime.InvokeVoidAsync("console.log", "Test", await PostService.GetPosts());

        Posts = await PostService.GetPosts();
        await jsRuntime.InvokeVoidAsync("console.log", "Fetch Success!", Posts);
    }

    void navigateToPost(Guid id)
    {
        jsRuntime.InvokeVoidAsync("console.log", "Go to post", id);
        NavigationManager.NavigateTo("/blog-post/" + id);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Services.PostService.IPostService PostService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591