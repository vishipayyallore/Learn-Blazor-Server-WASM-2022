using BlazorWASM.BasicsDemo.Model;
using BlazorWASM.BasicsDemo.Services;

namespace BlazorWASM.BasicsDemo.Pages._5TwoWayDataBinding
{
    public partial class TwoWayDataBindingDemo
    {
        public HotelRoom DemoRoom { get; set; } = new();

        protected override void OnInitialized()
        {
            DemoRoom = HotelRoomSerivce.GetDemoRoom();
        }
    }
}
