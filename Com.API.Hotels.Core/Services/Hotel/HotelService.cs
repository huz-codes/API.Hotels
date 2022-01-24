using Ardalis.Result;
using Com.API.Hotels.Core.HotelAggregates.Specifications;
using Com.API.Hotels.Core.Interfaces;
using Com.API.Hotels.SharedKernel.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.API.Hotels.Core.Services.Hotel
{
    public class HotelService : IHotelServices
    {
        private readonly IReadRepository<Aggregates.Hotel> repository;
        private ILogger logger;
        public HotelService(IReadRepository<Aggregates.Hotel> repository, ILogger logger)
        {
            this.repository = repository;
            this.logger = logger;
        }

        public async ValueTask<Result<List<Aggregates.Hotel>>> GetHotels()
        {
            try
            {
                var oResult = await this.repository.ListAsync();
                var existedHotelsSpec = new ExistedHotelsSpec();
                var hotels = existedHotelsSpec.Evaluate(oResult).ToList();
                if (!hotels.Any())
                    return Result<List<Aggregates.Hotel>>.NotFound();

                return hotels;
            }
            catch (Exception ex)
            {
                logger.LogError($"GetHotels request error");
                logger.LogError($"GetHotels Exception Message {ex.Message}");
                logger.LogError($"GetHotels Inner Exception {ex.InnerException}");
                logger.LogError($"GetHotels Stack Trace {ex.StackTrace}");
                logger.LogError($"GetHotels request error end log");

                return Result<List<Aggregates.Hotel>>.Error(new[] { ex.Message });
            }
        }

        public async ValueTask<Result<Aggregates.Hotel>> GetHotelDetailsByHotelId(Guid hotelId)
        {
            try
            {
                var hotelSpec = new HotelByIdWithItemsSpec(hotelId);
                var hotel = await this.repository.GetBySpecAsync(hotelSpec);
                if (hotel.IsDeleted)
                    return Result<Aggregates.Hotel>.NotFound();

                return hotel;
            }
            catch (Exception ex)
            {
                logger.LogError($"GetHotelDetailsByHotelId request error");
                logger.LogError($"GetHotelDetailsByHotelId Exception Message {ex.Message}");
                logger.LogError($"GetHotelDetailsByHotelId Inner Exception {ex.InnerException}");
                logger.LogError($"GetHotelDetailsByHotelId Stack Trace {ex.StackTrace}");
                logger.LogError($"GetHotelDetailsByHotelId request error end log");

                return Result<Aggregates.Hotel>.Error(new[] { ex.Message });
            }

        }
    }
}
