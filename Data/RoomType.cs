using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalHotelReservation.Data
{
    public class RoomType
    {
        //public int ID { get; set; }
        public int NumBeds { get; set; }
        public bool View { get; set; }
        public bool Smoker { get; set; }
        public decimal BasicPrice { get; set; }
        public int MaxOccupancy { get; set; }
    }
}
