using Com.API.Hotels.IntegrationTests.Borkers;
using Com.API.Hotels.IntegrationTests.Borkers.Collections;
using FluentAssertions;
using System;
using System.Threading.Tasks;
using Xunit;

namespace Com.API.Hotels.IntegrationTests.APIs.Booking
{
    [Collection(nameof(ApiTestsCollection))]
    public class BookingApiTests
    {
        private readonly MainApiTestsBroker mainApiTestsBroker;
        public BookingApiTests(MainApiTestsBroker mainApiTestsBroker) =>
            this.mainApiTestsBroker = mainApiTestsBroker;

        [Fact]
        public async Task ShouldBookPropertyFromHotel()
        {
            //given
            Guid HotelId = Guid.Parse(Constants.TestsConstants.TestsHotelId);
            Models.Booking.BookingTestsModel BookingTestsRandomObject = 
                Randoms.ApiRandomModelsGenerator.Instance.ApiRandomBookingGenerator();

            //when
            System.Net.Http.HttpResponseMessage httpResponse = await this.mainApiTestsBroker.Book(HotelId, BookingTestsRandomObject);

            //then
            httpResponse.Should().Equals(System.Net.HttpStatusCode.OK);
        }
    }
}
