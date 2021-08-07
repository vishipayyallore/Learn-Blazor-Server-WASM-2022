using BlazorWASM.BasicsDemo.Model;
using System.Collections.Generic;

namespace BlazorWASM.BasicsDemo.Services
{

    public class HotelRoomSerivce
    {

        public static HotelRoom GetDemoRoom() => new()
        {
            Id = 1,

            RoomName = "Villa Suite",

            IsActive = true,

            Price = 499,

            RoomProperties = GetRoomProperties()
        };

        private static List<HotelRoomProperty> GetRoomProperties() => new()
        {
            new HotelRoomProperty { Id = 1, Name = "Sq Ft", Value = "100" },
            new HotelRoomProperty { Id = 2, Name = "Occupancy", Value = "3" }
        };

    }

}
