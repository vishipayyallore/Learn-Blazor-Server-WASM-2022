using BlazorWASM.BasicsDemo.Model;
using BlazorWASM.BasicsDemo.Services;

namespace BlazorWASM.BasicsDemo.Pages._4OneWayDataBinding
{

    public partial class OneWayDataBindingDemo
    {
        public HotelRoom DemoRoom { get; set; } = new();

        protected override void OnInitialized()
        {
            DemoRoom = HotelRoomSerivce.GetDemoRoom();
        }
    }

}
