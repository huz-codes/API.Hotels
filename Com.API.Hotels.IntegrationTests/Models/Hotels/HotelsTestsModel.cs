using System;
using System.Collections.Generic;

namespace Com.API.Hotels.IntegrationTests.Models.Hotels
{
    public class HotelsTestsModel
    {
        public List<HotelDto> Hotels { get; set; }
    }
    public class HotelDto
    {
        public Guid HotelId { get; set; }
        public string HotelName { get; set; }
        public string Description { get; set; }
        public List<HotelRates> HotelRates { get; set; }
        public List<HotelReviews> UserHotelReviews { get; set; }
        public List<Address> Addresses { get; set; }
        public List<Facility> Facilities { get; set; }
        public List<Image> Images { get; set; }
        public List<Property> Properties { get; set; }
    }

    public class HotelRates
    {
        public Guid RateId { get; set; }
        public int Rate { get; set; }
    }
    public class HotelReviews
    {
        public Guid ReviewId { get; set; }
        public string Review { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string UserImage { get; set; }
    }

    public class Address
    {
        public Guid AddressId { get; set; }
        public string Country { get; set; }
        public List<States> StateProvinces { get; set; }
        public List<AddressLines> AddressLines { get; set; }
        public double Lat { get; set; }
        public double Long { get; set; }
        public string ZipPostalCode { get; set; }
        public int FaxNumber { get; set; }
        public string Email { get; set; }
        public int BuildingNumber { get; set; }
        public string StreetName { get; set; }
        public string LandMark { get; set; }
    }

    public class States
    {
        public Guid StateProvinceId { get; set; }
        public string StateProvinceName { get; set; }
    }
    public class AddressLines
    {
        public Guid AddressLineId { get; set; }
        public string AddressLineDescription { get; set; }
    }

    public class Facility
    {
        public Guid FacilityId { get; set; }
        public string FacilityName { get; set; }
        public string FacilityDescription { get; set; }
        public string FacilityIconName { get; set; }
    }

    public class Image
    {
        public Guid ImageId { get; set; }
        public string ImageName { get; set; }
        public string ImagePath { get; set; }
    }

    public class Property
    {
        public Guid PropertyId { get; set; }
        public string PropertyType { get; set; }
        public string PropertyNumber { get; set; }
        public string PropertyPricePerNight { get; set; }
        public decimal Discount { get; set; }
        public decimal Tax { get; set; }
        public DateTime AvailableFromDate { get; set; }
        public List<Image> PropertyImages { get; set; }
    }
}
