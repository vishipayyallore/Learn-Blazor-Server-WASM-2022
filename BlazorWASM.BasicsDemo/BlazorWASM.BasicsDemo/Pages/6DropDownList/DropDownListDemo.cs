using BlazorWASM.BasicsDemo.Model;

namespace BlazorWASM.BasicsDemo.Pages._6DropDownList
{

    public partial class DropDownListDemo
    {
        public HotelRoom DemoRoom { get; set; } = new();

        protected override void OnInitialized()
        {

            DemoRoom = new HotelRoom
            {
                Id = 1,
                RoomName = "Villa Suite",
                IsActive = true,
                Price = 499
            };

        }

    }

}
