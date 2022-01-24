using Com.API.Hotels.IntegrationTests.Relatives.Booking;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Com.API.Hotels.IntegrationTests.Borkers
{
    public partial class MainApiTestsBroker
    {
        public async ValueTask<HttpResponseMessage> Book(Guid HotelId, Models.Booking.BookingTestsModel bookingModel) =>
            await this.actionLocator.Post<Models.Booking.BookingTestsModel>(BookingRelativeUrls.Instance.Book(HotelId), bookingModel, this.baseClient);
    }
}
