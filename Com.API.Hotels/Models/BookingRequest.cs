using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Com.API.Hotels.Models
{
    public class BookingRequest
    {
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }

        public Guid HotelId { get; set; }
        public Guid PropertyId { get; set; }
        public Guid UserId { get; set; }
    }
}
