using Com.API.Hotels.SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.API.Hotels.Core.Aggregates
{
    public class Facility : BaseEntity
    {
        public Guid FacilityId { get; set; }
        public string FacilityName { get; set; }
        public string FacilityDescription { get; set; }
        public string FacilityIconName { get; set; }
    }
}
