using Com.API.Hotels.SharedKernel;
using System;
using System.Collections.Generic;

namespace Com.API.Hotels.Core.Aggregates
{
    public class StateProvince : BaseEntity
    {
        public StateProvince()
        {
            this.Addresses = new HashSet<Address>();
        }
        public Guid StateProvinceId { get; set; }
        public string StateProvinceName { get; set; }
        public Guid CountryId { get; set; }
        public Country Country { get; set; }
        public virtual ICollection<Address> Addresses  { get; set; }

    }
}
