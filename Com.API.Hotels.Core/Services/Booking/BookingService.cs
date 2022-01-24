using Ardalis.Result;
using Com.API.Hotels.Core.Interfaces;
using Com.API.Hotels.SharedKernel.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.API.Hotels.Core.Services.Booking
{
    public class BookingService : IBookingServices
    {

        private readonly IRepository<Aggregates.Booking> repository;
        private readonly IHotelServices hotelServices; 
        private ILogger logger;

        public BookingService(IRepository<Aggregates.Booking> repository, IHotelServices hotelServices, ILogger logger)
        {
            this.repository = repository;
            this.hotelServices = hotelServices;
            this.logger = logger;
        }
        public async ValueTask<Result<bool>> Book(Aggregates.Booking bookingDetails)
        {
            try
            {
                if (bookingDetails.CheckInDate == default ||
                       bookingDetails.PropertyId == default ||
                       bookingDetails.HotelId == default ||
                       bookingDetails.UserId == default)
                    return Result<bool>.Error(new[] { "Check in date, hotel id, property id and user id are required for completing the booking!" });

                var oHotel = await this.hotelServices.GetHotelDetailsByHotelId(bookingDetails.HotelId);
                if (oHotel == null)
                    return Result<bool>.Error(new[] { "Hotel is not exist!" });

                var PropertyAvailability = oHotel.Value.Properties.Where(o => o.PropertyId == bookingDetails.PropertyId &&
                                                                         o.AvailableFromDate <= bookingDetails.CheckInDate).SingleOrDefault();
                if (PropertyAvailability == null)
                    return Result<bool>.Error(new[] { $"property will not be available by this check in date {bookingDetails.CheckInDate}, nearest date is {PropertyAvailability.AvailableFromDate}" });

                bookingDetails.BookId = Guid.NewGuid();
                await repository.AddAsync(bookingDetails);
                await repository.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                logger.LogError($"Book request error");
                logger.LogError($"Book Exception Message {ex.Message}");
                logger.LogError($"Book Inner Exception {ex.InnerException}");
                logger.LogError($"Book Stack Trace {ex.StackTrace}");
                logger.LogError($"Book request error end log");

                return Result<bool>.Error(new[] { ex.Message });
            }

        } 
    }
}
