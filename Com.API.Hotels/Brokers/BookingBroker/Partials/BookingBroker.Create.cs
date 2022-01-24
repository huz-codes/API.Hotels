using Com.API.Hotels.Core.Aggregates;
using Com.API.Hotels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Com.API.Hotels.Brokers.BookingBroker
{
    public partial class BookingBroker
    {
        public async ValueTask<Tuple<bool, List<string>>> Book(BookingRequest booking)
        {
            var errors = new List<string>();
            var oBooking = new Booking 
            {
                CheckInDate = booking.CheckInDate,
                CheckOutDate = booking.CheckOutDate,
                HotelId = booking.HotelId,
                PropertyId = booking.PropertyId,
                UserId = booking.UserId
            };

            var oResult = await this.bookingServices.Book(oBooking);
            if (oResult.Errors.Any())
                errors = oResult.Errors.ToList();

            if(!oResult.Value)
                return Tuple.Create(false, errors);

            return Tuple.Create(true, errors);

        }
    }
}
