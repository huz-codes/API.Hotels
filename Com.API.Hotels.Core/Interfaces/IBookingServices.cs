using Ardalis.Result;
using Com.API.Hotels.Core.Aggregates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.API.Hotels.Core.Interfaces
{
    public interface IBookingServices
    {
        public ValueTask<Result<bool>> Book(Booking bookingDetails);
    }
}
