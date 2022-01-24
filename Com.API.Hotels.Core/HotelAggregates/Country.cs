using Com.API.Hotels.SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.API.Hotels.Core.Aggregates
{
    public class Country : BaseEntity
    {
        public Guid CountryId { get; set; }
        public string CountryName { get; set; }
        public ICollection<StateProvince> StateProvinces { get; set; }
    }
}
