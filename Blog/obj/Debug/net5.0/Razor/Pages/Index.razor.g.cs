#pragma checksum "C:\Users\Marko\Desktop\C#\Seminar_C#_solo\finished_version\seminar_c#\seminar_csharp\Blog\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "522fdf2efbf5b221ea6013b7fc344d116febf643"
// <auto-generated/>
#pragma warning disable 1591
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
#line 11 "C:\Users\Marko\Desktop\C#\Seminar_C#_solo\finished_version\seminar_c#\seminar_csharp\Blog\_Imports.razor"
using Blog.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Marko\Desktop\C#\Seminar_C#_solo\finished_version\seminar_c#\seminar_csharp\Blog\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.OpenElement(2, "main");
            __builder.AddAttribute(3, "role", "main");
            __builder.AddAttribute(4, "class", "pb-3");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "post-header");
            __builder.AddMarkupContent(7, "<h1>Blog posts</h1>\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(8);
            __builder.AddAttribute(9, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(10, "button");
                __builder2.AddAttribute(11, "class", "btn btn-info h-50 m-1");
                __builder2.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "C:\Users\Marko\Desktop\C#\Seminar_C#_solo\finished_version\seminar_c#\seminar_csharp\Blog\Pages\Index.razor"
                                                                    CreateNew

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(13, "Create new");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n        ");
            __builder.OpenComponent<Blog.Shared.BlogPosts>(15);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 20 "C:\Users\Marko\Desktop\C#\Seminar_C#_solo\finished_version\seminar_c#\seminar_csharp\Blog\Pages\Index.razor"
       
    private void CreateNew()
    {
        NavigationManager.NavigateTo("/create");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
    }
}
#pragma warning restore 1591
