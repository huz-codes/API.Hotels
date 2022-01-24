using Ardalis.Specification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.API.Hotels.Core.HotelAggregates.Specifications
{
    public class ExistedHotelsSpec : Specification<Aggregates.Hotel>
    {
        public ExistedHotelsSpec() =>
            Query.Where(item => !item.IsDeleted);
    }
}
