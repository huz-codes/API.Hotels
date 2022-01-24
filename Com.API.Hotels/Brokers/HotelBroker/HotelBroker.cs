using Com.API.Hotels.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Com.API.Hotels.Brokers
{
    public partial class HotelBroker
    {
        private readonly IHotelServices hotelServices;
        public HotelBroker(IHotelServices hotelServices) =>
            this.hotelServices = hotelServices;
    }
}
