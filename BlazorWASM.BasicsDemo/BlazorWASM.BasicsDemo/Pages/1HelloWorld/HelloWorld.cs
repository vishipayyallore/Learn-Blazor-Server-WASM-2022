using Microsoft.AspNetCore.Components;

namespace BlazorWASM.BasicsDemo.Pages._1HelloWorld
{

    public partial class HelloWorld
    {
        [Parameter]
        public string UserName { get; set; }
    }

}
