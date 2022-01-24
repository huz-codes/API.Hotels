using Com.API.Hotels.IntegrationTests.Borkers;
using Com.API.Hotels.IntegrationTests.Borkers.Collections;
using FluentAssertions;
using System;
using System.Threading.Tasks;
using Xunit;

namespace Com.API.Hotels.IntegrationTests.APIs.Hotels
{
    [Collection(nameof(ApiTestsCollection))]
    public class HotelsApiTests
    {
        private readonly MainApiTestsBroker mainApiTestsBroker;
        public HotelsApiTests(MainApiTestsBroker mainApiTestsBroker) =>
            this.mainApiTestsBroker = mainApiTestsBroker;

        [Fact]
        public async Task ShouldGetAllHotels()
        {
            //given

            //when
            Models.Hotels.HotelsTestsModel HotelsTestsModelResponse =
                await this.mainApiTestsBroker.Hotels();

            int HotelsCount = HotelsTestsModelResponse.Hotels.Count;

            //then
            HotelsCount.Should().BeGreaterThan(0);
        }

        [Fact]
        public async Task ShouldGetHotelById()
        {
            //given
            Guid HotelId = Guid.Parse(Constants.TestsConstants.TestsHotelId);

            //when
            Models.Hotels.HotelDto HotelsTestsModelResponse =
                await this.mainApiTestsBroker.Hotels(HotelId);
            //then
            HotelsTestsModelResponse.Should().NotBeNull();
        }
    }
}
