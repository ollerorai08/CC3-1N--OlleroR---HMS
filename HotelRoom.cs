using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC3_1N_HMS
{
    public enum RoomStyle
    {
        TwinRoom,
        KingRoom,
        QueenRoom
    }
    public class HotelRoom
    {
        public int RoomNumber { get; set; }
        public RoomStyle Style { get; set; }
        public bool IsAvailable { get; set; }
        public decimal BookingPrice { get; set; }

        public HotelRoom(int roomNumber, RoomStyle style, decimal bookingPrice)
        {
            RoomNumber = roomNumber;
            Style = style;
            IsAvailable = true;
            BookingPrice = bookingPrice;
        }
    }
}
