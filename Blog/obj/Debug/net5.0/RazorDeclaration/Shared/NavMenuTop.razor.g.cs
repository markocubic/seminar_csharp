// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 11 "C:\Users\Marko\Desktop\Seminar_C#_solo\seminar_backend_test\Blog\_Imports.razor"
using Blog.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Marko\Desktop\Seminar_C#_solo\seminar_backend_test\Blog\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
    public partial class NavMenuTop : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 44 "C:\Users\Marko\Desktop\Seminar_C#_solo\seminar_backend_test\Blog\Shared\NavMenuTop.razor"
       
    string userName;
    protected override async Task OnInitializedAsync()
    {
        userName = await LocalStorage.GetItemAsync<string>("username");
        await AuthStateProvider.GetAuthenticationStateAsync();
    }

    protected override void OnInitialized()
    {
        UriHelper.LocationChanged += DetectNavigation;
    }

    private async void DetectNavigation(object sender, LocationChangedEventArgs e)
    {
        userName = await LocalStorage.GetItemAsync<string>("username");
        await AuthStateProvider.GetAuthenticationStateAsync();
    }

    private async void Logout()
    {
        await LocalStorage.RemoveItemAsync("username");
        await AuthStateProvider.GetAuthenticationStateAsync();
        NavigationManager.NavigateTo("");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager UriHelper { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISyncLocalStorageService LocalStorageSync { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocalStorageService LocalStorage { get; set; }
    }
}
#pragma warning restore 1591
