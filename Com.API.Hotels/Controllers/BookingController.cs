using Com.API.Hotels.Brokers.BookingBroker;
using Com.API.Hotels.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Com.API.Hotels.Controllers
{
    public class BookingController : BaseController
    {
        private readonly BookingBroker bookingBroker;
        public BookingController(BookingBroker bookingBroker) =>
            this.bookingBroker = bookingBroker;

        [HttpPost("/hotels/{Id:Guid}/book")]
        public async ValueTask<ActionResult> Book([FromBody] BookingRequest bookingRequest, Guid Id)
        {
            bookingRequest.HotelId = Id;
            var oResult = await this.bookingBroker.Book(bookingRequest);
            if (oResult.Item2.Any())
                return UnprocessableEntity(oResult.Item2);

            if (!oResult.Item1)
                return UnprocessableEntity("There is an issue please try again!");

            return Ok(oResult.Item1);
        }
    }
}
