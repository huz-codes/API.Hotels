using Com.API.Hotels.SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.API.Hotels.Core.Aggregates
{
    public class HotelRate : BaseEntity
    {
        public Guid RateId { get; set; }
        public int Rate { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
        public Guid HotelId { get; set; }
        public Hotel Hotel { get; set; }
    }
}
