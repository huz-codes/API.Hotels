using Com.API.Hotels.SharedKernel;
using Com.API.Hotels.SharedKernel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.API.Hotels.Core.Aggregates
{
    public class Booking : BaseEntity, IAggregateRoot
    {
        public Guid BookId { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }

        public Guid HotelId { get; set; }
        public Hotel Hotel { get; set; }
        public Guid PropertyId { get; set; }
        public Property Property { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
    }
}
