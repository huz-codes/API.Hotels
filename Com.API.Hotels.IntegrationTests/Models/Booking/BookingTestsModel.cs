using System;

namespace Com.API.Hotels.IntegrationTests.Models.Booking
{
    public class BookingTestsModel
    {
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }

        public Guid HotelId { get; set; }
        public Guid PropertyId { get; set; }
        public Guid UserId { get; set; }
    }
}
