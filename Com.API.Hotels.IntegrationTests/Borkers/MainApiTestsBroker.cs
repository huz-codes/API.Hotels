using Com.API.Hotels.IntegrationTests.ServiceEngine;
using System.Net.Http;

namespace Com.API.Hotels.IntegrationTests.Borkers
{
    public partial class MainApiTestsBroker
    {
        private readonly HttpClient baseClient;
        private readonly HttpClientServiceHelper actionLocator;
        public MainApiTestsBroker()
        {
            this.baseClient = new HttpClient();
            this.actionLocator = new HttpClientServiceHelper();
        }
    }
}
