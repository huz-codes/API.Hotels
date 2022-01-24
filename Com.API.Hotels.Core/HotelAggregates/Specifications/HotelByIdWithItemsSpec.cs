using Ardalis.Specification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.API.Hotels.Core.HotelAggregates.Specifications
{
    public class HotelByIdWithItemsSpec : Specification<Aggregates.Hotel>, ISingleResultSpecification
    {
        public HotelByIdWithItemsSpec(Guid hotelId) =>
            Query.Where(hotel => hotel.HotelId == hotelId)
                 .Include(hotel => hotel.HotelRates)
                 .Include(hotel => hotel.UserHotelReviews)
                 .Include(hotel => hotel.Addresses)
                 .Include(hotel => hotel.Facilities)
                 .Include(hotel => hotel.Images)
                 .Include(hotel => hotel.Properties);
    }
}
