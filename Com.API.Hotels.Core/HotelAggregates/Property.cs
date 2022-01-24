using Com.API.Hotels.SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.API.Hotels.Core.Aggregates
{
    public class Property : BaseEntity
    {
        public Guid PropertyId { get; set; }
        public string PropertyType { get; set; }
        public string PropertyNumber { get; set; }
        public string PropertyPricePerNight { get; set; }
        public decimal Discount { get; set; }
        public decimal Tax { get; set; }
        public DateTime AvailableFromDate { get; set; }
        public ICollection<Image> PropertyImages { get; set; }
    }
}
