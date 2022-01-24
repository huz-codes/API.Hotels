using Com.API.Hotels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Com.API.Hotels.Brokers
{
    public partial class HotelBroker
    {
        public async ValueTask<Tuple<HotelResponse, List<string>>> GetHotels()
        {
            var errors = new List<string>();
            var oHotelResponse = new HotelResponse();
            var oResult = await this.hotelServices.GetHotels();
            if (oResult.Errors.Any())
                errors = oResult.Errors.ToList();

            if (oResult.Value.Count == 0)
                return Tuple.Create(oHotelResponse, errors);

            
            var hotelDTOs = oResult.Value.Select(hotel => new HotelDto
            {
                HotelId = hotel.HotelId,
                Description = hotel.Description,
                HotelName = hotel.HotelName,
                HotelRates = hotel.HotelRates?.Select(o => new HotelRates
                {
                    Rate = o.Rate,
                    RateId = o.RateId
                }).ToList(),

                UserHotelReviews = hotel.UserHotelReviews?.Select(o => new HotelReviews
                {
                    Review = o.Review,
                    ReviewId = o.ReviewId,
                    UserEmail = o.User.Email,
                    UserImage = o.User.ImagePath,
                    UserName = o.User.UserName
                }).ToList(),

                Facilities = hotel.Facilities?.Select(o => new Facility 
                {
                    FacilityId = o.FacilityId,
                    FacilityDescription = o.FacilityDescription,
                    FacilityIconName = o.FacilityIconName,
                    FacilityName = o.FacilityName
                }).ToList(),

                Images = hotel.Images?.Select(images => new Image 
                {
                    ImageId = images.ImageId,
                    ImageName = images.ImageName,
                    ImagePath = images.ImagePath
                }).ToList(),

                Properties = hotel.Properties?.Select(o => new Property 
                {
                    PropertyId = o.PropertyId,
                    PropertyType = o.PropertyType,
                    PropertyNumber = o.PropertyNumber,
                    PropertyPricePerNight = o.PropertyPricePerNight,
                    Discount = o.Discount,
                    Tax = o.Tax,
                    AvailableFromDate = o.AvailableFromDate,
                    PropertyImages = o.PropertyImages?.Select(oImg => new Image 
                    {
                        ImageId = oImg.ImageId,
                        ImageName = oImg.ImageName,
                        ImagePath = oImg.ImagePath
                    }).ToList()
                    
                }).ToList(),

                Addresses = hotel.Addresses?.Select(o => new Address 
                {
                    AddressId = o.AddressId,
                    BuildingNumber = o.BuildingNumber,
                    Country = o.Country.CountryName,
                    Email = o.Email,
                    StreetName = o.StreetName,
                    FaxNumber = o.FaxNumber,
                    LandMark = o.LandMark,
                    ZipPostalCode = o.ZipPostalCode,
                    Lat = o.Lat,
                    Long = o.Long,
                    AddressLines = o.AddressLines.Select(oAddressLines => new AddressLines
                    {
                        AddressLineDescription = oAddressLines.AddressLineDescription,
                        AddressLineId = oAddressLines.AddressLineId
                    }).ToList(),
                    StateProvinces = o.StateProvinces.Select(oState => new States
                    {
                        StateProvinceId = oState.StateProvinceId,
                        StateProvinceName = oState.StateProvinceName
                    }).ToList()

                }).ToList()


            }).ToList();
            oHotelResponse.Hotels = hotelDTOs;
            return Tuple.Create(oHotelResponse, errors);
        }

        public async ValueTask<Tuple<HotelDto, List<string>>> GetHotels(Guid hotelId)
        {
            var errors = new List<string>();
            var oHotelDto = new HotelDto();
            var oResult = await this.GetHotels();
            if (oResult.Item2.Any())
                errors = oResult.Item2;

            if (oResult.Item1.Hotels.Count == 0)
                return Tuple.Create(oHotelDto, errors);

            oHotelDto = oResult.Item1.Hotels.FirstOrDefault(o => o.HotelId == hotelId);
            return Tuple.Create(oHotelDto, errors);
        }
    }
}
