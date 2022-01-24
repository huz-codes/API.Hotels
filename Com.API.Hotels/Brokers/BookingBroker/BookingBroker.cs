using Com.API.Hotels.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Com.API.Hotels.Brokers.BookingBroker
{
    public partial class BookingBroker
    {
        private readonly IBookingServices bookingServices;
        public BookingBroker(IBookingServices bookingServices) =>
            this.bookingServices = bookingServices;
    }
}
