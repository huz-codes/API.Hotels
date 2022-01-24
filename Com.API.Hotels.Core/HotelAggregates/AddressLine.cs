using Com.API.Hotels.SharedKernel;
using System;

namespace Com.API.Hotels.Core.Aggregates
{
    public class AddressLine : BaseEntity
    {
        public Guid AddressLineId { get; set; }
        public string AddressLineDescription { get; set; }
        public Guid AddressId { get; set; }
        public Address Address { get; set; }
    }
}
