using BlazorWASM.BasicsDemo.Model;
using BlazorWASM.BasicsDemo.Services;

namespace BlazorWASM.BasicsDemo.Pages._6DropDownList
{

    public partial class DropDownListDemo
    {
        public HotelRoom DemoRoom { get; set; } = new();

        public string RoomPropertySelected { get; set; } = string.Empty;

        protected override void OnInitialized()
        {
            DemoRoom = HotelRoomSerivce.GetDemoRoom();
        }

    }

}
