using Com.API.Hotels.SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.API.Hotels.Core.Aggregates
{
    public class UserHotelReviews : BaseEntity
    {
        public Guid ReviewId { get; set; }
        public string Review { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
        public Guid HotelId { get; set; }
        public Hotel Hotel { get; set; }
    }
}
