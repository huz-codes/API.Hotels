using Com.API.Hotels.SharedKernel;
using System;

namespace Com.API.Hotels.Core.Aggregates
{
    public class CustomAttribute : BaseEntity
    {
        public Guid CustomAttributeId { get; set; }
        public string CustomAttributeName { get; set; }
        public string CustomAttributeValue { get; set; }
        public Guid AddressId { get; set; }
        public Address Address { get; set; }
    }
}
