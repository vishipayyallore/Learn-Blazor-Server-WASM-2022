using Microsoft.AspNetCore.Components;

namespace BlazorWASM.BasicsDemo.Pages._2RouteParameter
{
    public partial class RoutingDemo
    {

        [Parameter]
        public string Username { get; set; }

        protected override void OnInitialized()
        {
            Username = Username ?? "No Name";
        }

    }

}
