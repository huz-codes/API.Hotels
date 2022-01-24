using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Com.API.Hotels.IntegrationTests.ServiceEngine
{
    public class HttpClientServiceHelper
    {
        public async ValueTask<TGet> Get<TGet>(string url, HttpClient clientObject)
        {
            var clientResponse = await clientObject.GetStringAsync(url);
            return Newtonsoft.Json.JsonConvert.DeserializeObject<TGet>(clientResponse);
        }

        public async ValueTask<HttpResponseMessage> Post<TPost>(string url, TPost clientModel, HttpClient clientObject)
        {
            string clientContent = Newtonsoft.Json.JsonConvert.SerializeObject(clientModel);
            HttpResponseMessage clientResponse = await clientObject.PostAsync(url, new StringContent(clientContent, Encoding.UTF8, "application/json"));
            return clientResponse;
        }

        public async ValueTask<HttpResponseMessage> Put<TPost>(string url, TPost clientModel, HttpClient clientObject)
        {
            string clientContent = Newtonsoft.Json.JsonConvert.SerializeObject(clientModel);
            HttpResponseMessage clientResponse = await clientObject.PutAsync(url, new StringContent(clientContent, Encoding.UTF8, "application/json"));
            return clientResponse;
        }
    }
}
