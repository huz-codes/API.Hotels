using System;
using System.Threading.Tasks;

namespace Com.API.Hotels.IntegrationTests.Borkers
{
    public partial class MainApiTestsBroker
    {
        public async ValueTask<Models.Hotels.HotelsTestsModel> Hotels() =>
            await this.actionLocator.Get<Models.Hotels.HotelsTestsModel>(Relatives.Hotels.HotelsRelativeUrls.Instance.Hotels, this.baseClient);

        public async ValueTask<Models.Hotels.HotelDto> Hotels(Guid HotelId) =>
            await this.actionLocator.Get<Models.Hotels.HotelDto>(Relatives.Hotels.HotelsRelativeUrls.Instance.HotelById(HotelId), this.baseClient);
    }
}
