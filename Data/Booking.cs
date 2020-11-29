﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalHotelReservation.Data
{
    public class Booking
    {
        //public int ID { get; set; }
        public int UserID { get; set; }
        public int RoomID { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public int numAdults { get; set; }
        public int numChildren { get; set; }
    }
}
