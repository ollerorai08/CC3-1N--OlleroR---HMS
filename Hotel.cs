using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC3_1N_HMS
{
    public class Hotel
    {
        public string HotelName { get; set; }
        public string Location { get; set; }
        public List<HotelRoom> Rooms { get; set; }

        public Hotel(string hotelName, string location)
        {
            HotelName = hotelName;
            Location = location;
            Rooms = new List<HotelRoom>();
        }

        public void AddRoom(int roomNumber, RoomStyle style, decimal bookingPrice)
        {
            Rooms.Add(new HotelRoom(roomNumber, style, bookingPrice));
        }

        public void DisplayAvailableRooms()
        {
            Console.WriteLine($"Available rooms at {HotelName}, {Location}:");
            foreach (var room in Rooms)
            {
                if (room.IsAvailable)
                {
                    Console.WriteLine($"Room Number: {room.RoomNumber}, Style: {room.Style}, Booking Price: {room.BookingPrice}");
                }
            }
        }
    }
}
