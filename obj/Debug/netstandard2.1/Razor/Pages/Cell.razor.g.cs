#pragma checksum "C:\Users\itesanovic\source\repos\TTTBlaze\TTTBlaze\Pages\Cell.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "87a16bc55e4e6467f3e45c519dbe382277dbcbc1"
// <auto-generated/>
#pragma warning disable 1591
namespace TTTBlaze.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\itesanovic\source\repos\TTTBlaze\TTTBlaze\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\itesanovic\source\repos\TTTBlaze\TTTBlaze\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\itesanovic\source\repos\TTTBlaze\TTTBlaze\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\itesanovic\source\repos\TTTBlaze\TTTBlaze\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\itesanovic\source\repos\TTTBlaze\TTTBlaze\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\itesanovic\source\repos\TTTBlaze\TTTBlaze\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\itesanovic\source\repos\TTTBlaze\TTTBlaze\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\itesanovic\source\repos\TTTBlaze\TTTBlaze\_Imports.razor"
using TTTBlaze;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\itesanovic\source\repos\TTTBlaze\TTTBlaze\_Imports.razor"
using TTTBlaze.Shared;

#line default
#line hidden
#nullable disable
    public partial class Cell : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "td");
            __builder.AddMarkupContent(1, "\r\n");
#nullable restore
#line 3 "C:\Users\itesanovic\source\repos\TTTBlaze\TTTBlaze\Pages\Cell.razor"
     if (val == 'X' || val == 'Y')
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "        ");
            __builder.OpenElement(3, "button");
            __builder.AddAttribute(4, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 5 "C:\Users\itesanovic\source\repos\TTTBlaze\TTTBlaze\Pages\Cell.razor"
                          Handler

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "disabled", true);
            __builder.AddAttribute(6, "class", "cell");
            __builder.AddContent(7, 
#nullable restore
#line 5 "C:\Users\itesanovic\source\repos\TTTBlaze\TTTBlaze\Pages\Cell.razor"
                                                          val

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n");
#nullable restore
#line 6 "C:\Users\itesanovic\source\repos\TTTBlaze\TTTBlaze\Pages\Cell.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(9, "        ");
            __builder.OpenElement(10, "button");
            __builder.AddAttribute(11, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "C:\Users\itesanovic\source\repos\TTTBlaze\TTTBlaze\Pages\Cell.razor"
                          Handler

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "class", "cell");
            __builder.AddContent(13, 
#nullable restore
#line 9 "C:\Users\itesanovic\source\repos\TTTBlaze\TTTBlaze\Pages\Cell.razor"
                                                 val

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n");
#nullable restore
#line 10 "C:\Users\itesanovic\source\repos\TTTBlaze\TTTBlaze\Pages\Cell.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 14 "C:\Users\itesanovic\source\repos\TTTBlaze\TTTBlaze\Pages\Cell.razor"
           
        [Parameter]
        public char val { get; set; }
        [Parameter]
        public EventCallback Handler { get; set; }
    

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591