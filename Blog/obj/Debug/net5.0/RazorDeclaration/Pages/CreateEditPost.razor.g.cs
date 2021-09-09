// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Blog.Pages
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
#line 4 "C:\Users\Marko\Desktop\C#\Seminar_C#_solo\finished_version\seminar_c#\seminar_csharp\Blog\Pages\CreateEditPost.razor"
using Blog.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/create")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/edit/{url}")]
    public partial class CreateEditPost : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 53 "C:\Users\Marko\Desktop\C#\Seminar_C#_solo\finished_version\seminar_c#\seminar_csharp\Blog\Pages\CreateEditPost.razor"
       
    [Parameter]
    public string Url { get; set; }

    Post newBlogPost = new Post();
    string userName;
    string currentPageName = "";

    protected override async Task OnInitializedAsync()
    {
        userName = await LocalStorage.GetItemAsync<string>("username");
        currentPageName = GetCurrentPageName();

        if (currentPageName.Equals(Url))
        {
            newBlogPost = PostService.GetBlogPostByUrl(Url);
        }
    }

    public void SubmitForm()
    {
        if (currentPageName.Equals("create"))
        {
            var user = UserService.GetUserByCredentials(userName);
            newBlogPost.User = user;
            PostService.CreatePost(newBlogPost);

        }
        else if (currentPageName.Equals(Url))
        {
            PostService.EditPost(Url, newBlogPost);
        }
        NavigationManager.NavigateTo("");
    }

    private string GetCurrentPageName()
    {
        string path = NavigationManager.Uri;
        int pos = path.LastIndexOf('/') + 1;
        path = path.Substring(pos, path.Length - pos);

        return path;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Services.PostService.IPostService PostService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Services.UserService.IUserService UserService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISyncLocalStorageService LocalStorageSync { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocalStorageService LocalStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
    }
}
#pragma warning restore 1591