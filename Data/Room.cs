using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalHotelReservation.Data
{
    public class Room
    {
        //public int ID { get; set; }
        public int LocationID { get; set; }
        public int RoomTypeID { get; set; }
        public int BookingID { get; set; }
        public ICollection<Location> Locations { get; set; }
        public ICollection<Booking> Bookings { get; set; }
        public RoomType RoomType { get; set; }
    }
}
