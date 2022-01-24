using Xunit;

namespace Com.API.Hotels.IntegrationTests.Borkers.Collections
{
    [CollectionDefinition(nameof(ApiTestsCollection))]
    public class ApiTestsCollection : ICollectionFixture<MainApiTestsBroker>
    {
    }
}
