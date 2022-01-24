using Com.API.Hotels.Brokers;
using Com.API.Hotels.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Com.API.Hotels.Controllers
{
    public class HotelsController : BaseController
    {
        private readonly HotelBroker hotelBroker;
        public HotelsController(HotelBroker hotelBroker) =>
            this.hotelBroker = hotelBroker;

        [HttpGet("/hotels")]
        public async ValueTask<ActionResult<HotelResponse>> Hotels()
        {
            var oResult = await this.hotelBroker.GetHotels();
            if (oResult.Item2.Any())
                return UnprocessableEntity(oResult.Item2);

            if (oResult.Item1.Hotels.Count == 0)
                return NotFound("Hotels list is empty!");

            return Ok(oResult.Item1);
        }

        [HttpGet("/hotels/{Id:Guid}/details")]
        public async ValueTask<ActionResult<HotelDto>> HotelById(Guid Id)
        {
            var oResult = await this.hotelBroker.GetHotels(Id);
            if (oResult.Item2.Any())
                return UnprocessableEntity(oResult.Item2);

            return Ok(oResult.Item1);
        }
    }
}
