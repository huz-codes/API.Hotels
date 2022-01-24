using Com.API.Hotels.SharedKernel;
using Com.API.Hotels.SharedKernel.Interfaces;
using System;
using System.Collections.Generic;

namespace Com.API.Hotels.Core.Aggregates
{
    public class Hotel : BaseEntity, IAggregateRoot
    {
        public Guid HotelId { get; set; }
        public string HotelName { get; set; }
        public string Description { get; set; }
        public ICollection<HotelRate> HotelRates { get; set; }
        public ICollection<UserHotelReviews> UserHotelReviews { get; set; }
        public ICollection<Address> Addresses { get; set; }
        public ICollection<Facility> Facilities { get; set; }
        public ICollection<Image> Images { get; set; }
        public ICollection<Property> Properties { get; set; }
        public bool IsDeleted { get; set; }
    }
}
