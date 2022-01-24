using Com.API.Hotels.SharedKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.API.Hotels.Core.Aggregates
{
    public class Address : BaseEntity
    {
        public Address()
        {
            this.StateProvinces = new HashSet<StateProvince>();
        }
        public Guid AddressId { get; set; }
        [ForeignKey("Country")]
        public Guid CountryId { get; set; }
        public Country Country { get; set; }
        [ForeignKey("Hotel")]
        public Guid HotelId { get; set; }
        public Hotel Hotel { get; set; }
        public virtual ICollection<StateProvince> StateProvinces { get; set; }
        public ICollection<CustomAttribute> CustomAttributes { get; set; }
        public ICollection<AddressLine> AddressLines { get; set; }
        public double Lat { get; set; }
        public double Long { get; set; }
        [MaxLength(6)]
        public string ZipPostalCode { get; set; }
        public int FaxNumber { get; set; }
        public string Email { get; set; }
        public int BuildingNumber { get; set; }
        public string StreetName { get; set; }
        public string LandMark { get; set; }

    }
}
