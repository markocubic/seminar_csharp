#pragma checksum "C:\Users\Marko\Desktop\C#\Seminar_C#_solo\finished_version\seminar_c#\seminar_csharp\Blog\Shared\BlogPosts.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "782b101182f6f9bb043f7ad18eb9b45cb73fb31f"
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
#line 1 "C:\Users\Marko\Desktop\C#\Seminar_C#_solo\finished_version\seminar_c#\seminar_csharp\Blog\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Marko\Desktop\C#\Seminar_C#_solo\finished_version\seminar_c#\seminar_csharp\Blog\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Marko\Desktop\C#\Seminar_C#_solo\finished_version\seminar_c#\seminar_csharp\Blog\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Marko\Desktop\C#\Seminar_C#_solo\finished_version\seminar_c#\seminar_csharp\Blog\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Marko\Desktop\C#\Seminar_C#_solo\finished_version\seminar_c#\seminar_csharp\Blog\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Marko\Desktop\C#\Seminar_C#_solo\finished_version\seminar_c#\seminar_csharp\Blog\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Marko\Desktop\C#\Seminar_C#_solo\finished_version\seminar_c#\seminar_csharp\Blog\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Marko\Desktop\C#\Seminar_C#_solo\finished_version\seminar_c#\seminar_csharp\Blog\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Marko\Desktop\C#\Seminar_C#_solo\finished_version\seminar_c#\seminar_csharp\Blog\_Imports.razor"
using Blog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Marko\Desktop\C#\Seminar_C#_solo\finished_version\seminar_c#\seminar_csharp\Blog\_Imports.razor"
using Blog.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Marko\Desktop\C#\Seminar_C#_solo\finished_version\seminar_c#\seminar_csharp\Blog\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Marko\Desktop\C#\Seminar_C#_solo\finished_version\seminar_c#\seminar_csharp\Blog\Shared\BlogPosts.razor"
using Blog.Models;

#line default
#line hidden
#nullable disable
    public partial class BlogPosts : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "search input-group");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "form-outline");
            __builder.OpenElement(4, "input");
            __builder.AddAttribute(5, "type", "search");
            __builder.AddAttribute(6, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 12 "C:\Users\Marko\Desktop\C#\Seminar_C#_solo\finished_version\seminar_c#\seminar_csharp\Blog\Shared\BlogPosts.razor"
                           (e) => { SearchValue=(string)e.Value;}

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "id", "form1");
            __builder.AddAttribute(8, "class", "form-control");
            __builder.AddAttribute(9, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 11 "C:\Users\Marko\Desktop\C#\Seminar_C#_solo\finished_version\seminar_c#\seminar_csharp\Blog\Shared\BlogPosts.razor"
                       SearchValue

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => SearchValue = __value, SearchValue));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n    ");
            __builder.OpenElement(12, "button");
            __builder.AddAttribute(13, "type", "button");
            __builder.AddAttribute(14, "class", "btn btn-primary");
            __builder.AddAttribute(15, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "C:\Users\Marko\Desktop\C#\Seminar_C#_solo\finished_version\seminar_c#\seminar_csharp\Blog\Shared\BlogPosts.razor"
                                                            () => SearchPostsByTitle()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(16, "\r\n        Search\r\n    ");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 20 "C:\Users\Marko\Desktop\C#\Seminar_C#_solo\finished_version\seminar_c#\seminar_csharp\Blog\Shared\BlogPosts.razor"
 foreach (var post in Posts)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "post-item col-12 border p-3 mt-3");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "post-item-header");
            __builder.OpenElement(21, "h3");
            __builder.AddContent(22, 
#nullable restore
#line 25 "C:\Users\Marko\Desktop\C#\Seminar_C#_solo\finished_version\seminar_c#\seminar_csharp\Blog\Shared\BlogPosts.razor"
                 post.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n            ");
            __builder.OpenElement(24, "p");
            __builder.AddContent(25, 
#nullable restore
#line 28 "C:\Users\Marko\Desktop\C#\Seminar_C#_solo\finished_version\seminar_c#\seminar_csharp\Blog\Shared\BlogPosts.razor"
                 post.DateCreated

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n\r\n        ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "post-item-info");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "post-item-info-left");
            __builder.AddContent(31, 
#nullable restore
#line 34 "C:\Users\Marko\Desktop\C#\Seminar_C#_solo\finished_version\seminar_c#\seminar_csharp\Blog\Shared\BlogPosts.razor"
                 post.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n            ");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "post-item-info-right");
            __builder.AddContent(35, 
#nullable restore
#line 37 "C:\Users\Marko\Desktop\C#\Seminar_C#_solo\finished_version\seminar_c#\seminar_csharp\Blog\Shared\BlogPosts.razor"
                 post.User.UserName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n        ");
            __builder.OpenElement(37, "button");
            __builder.AddAttribute(38, "class", "mt-2 mr-2 btn btn-info h-30");
            __builder.AddAttribute(39, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 40 "C:\Users\Marko\Desktop\C#\Seminar_C#_solo\finished_version\seminar_c#\seminar_csharp\Blog\Shared\BlogPosts.razor"
                                                              () => navigateToPost(post.Id, Buttons.Show)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(40, "Show");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(42);
            __builder.AddAttribute(43, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
#nullable restore
#line 43 "C:\Users\Marko\Desktop\C#\Seminar_C#_solo\finished_version\seminar_c#\seminar_csharp\Blog\Shared\BlogPosts.razor"
                 if (isPostFromCurrentUser(post.Id))
                {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(44, "button");
                __builder2.AddAttribute(45, "class", "mt-2 mr-2 btn btn-warning h-30");
                __builder2.AddAttribute(46, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 45 "C:\Users\Marko\Desktop\C#\Seminar_C#_solo\finished_version\seminar_c#\seminar_csharp\Blog\Shared\BlogPosts.razor"
                                                                             () => navigateToPost(post.Id, Buttons.Edit)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(47, "Edit");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\r\n                    ");
                __builder2.OpenElement(49, "button");
                __builder2.AddAttribute(50, "class", "mt-2 mr-2 btn btn-danger h-30");
                __builder2.AddAttribute(51, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 46 "C:\Users\Marko\Desktop\C#\Seminar_C#_solo\finished_version\seminar_c#\seminar_csharp\Blog\Shared\BlogPosts.razor"
                                                                            () => navigateToPost(post.Id, Buttons.Delete)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(52, "Delete");
                __builder2.CloseElement();
#nullable restore
#line 47 "C:\Users\Marko\Desktop\C#\Seminar_C#_solo\finished_version\seminar_c#\seminar_csharp\Blog\Shared\BlogPosts.razor"
                }

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 51 "C:\Users\Marko\Desktop\C#\Seminar_C#_solo\finished_version\seminar_c#\seminar_csharp\Blog\Shared\BlogPosts.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 53 "C:\Users\Marko\Desktop\C#\Seminar_C#_solo\finished_version\seminar_c#\seminar_csharp\Blog\Shared\BlogPosts.razor"
       
    private List<Post> Posts = new List<Post>();
    private string SearchValue { get; set; } = "";
    string loggedInUser;

    enum Buttons
    {
        Show = 1,
        Edit = 2,
        Delete = 3,
    }

    protected override async Task OnInitializedAsync()
    {
        Posts = await PostService.GetPosts();

        loggedInUser = await LocalStorage.GetItemAsync<string>("username");
    }

    void navigateToPost(Guid id, Buttons button)
    {
        if (button == Buttons.Show)
        {
            NavigationManager.NavigateTo("/blog-post/" + id);
        }
        else if (button == Buttons.Edit)
        {
            NavigationManager.NavigateTo("/edit/" + id);
        }
        else if (button == Buttons.Delete)
        {
            PostService.DeletePost(id.ToString());
            NavigationManager.NavigateTo("", forceLoad: true);
        }
    }

    public bool isPostFromCurrentUser(Guid postId)
    {
        Post post = PostService.GetBlogPostByUrl(postId.ToString());
        if (post.User.UserName == loggedInUser)
        {
            return true;
        }
        return false;
    }

    public void SearchPostsByTitle()
    {
        Posts = PostService.SearchPostsByTitle(SearchValue);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Services.PostService.IPostService PostService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocalStorageService LocalStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
