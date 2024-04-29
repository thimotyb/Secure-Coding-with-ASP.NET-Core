using System.Security.Authentication;

namespace Globomantics.Survey.Services
{
    public class GlobomanticsApiService
    {
        private const string _apiPath = "https://my.api.mockaroo.com/users.json?key=df6343d0";
        public async Task<string> GetPublicData()
        {
            var handler = new HttpClientHandler
            {
                //SslProtocols = SslProtocols.Tls12 | SslProtocols.Tls13
                SslProtocols = SslProtocols.Ssl2
            };

            HttpClient client = new HttpClient(handler);

            HttpResponseMessage response = await client.GetAsync(_apiPath);
            string responseContent = "";
            if (response.IsSuccessStatusCode)
            {
                responseContent = await response.Content.ReadAsStringAsync();
            }

            return responseContent;
        }
    }

}