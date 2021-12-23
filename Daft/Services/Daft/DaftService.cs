using Daft.Services.Daft.Listing.Models;
using Daft.Services.Daft.Property.Models;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Daft.Services.Daft
{
    public partial class DaftService
    {
        private string _accessToken;
        private readonly HttpClient _httpClient;

        public DaftService()
        {
            _httpClient = GetHttpClient();
        }

        private HttpClient GetHttpClient() => new HttpClient(new HttpClientHandler
        {
            AutomaticDecompression = System.Net.DecompressionMethods.All
        });

        public async Task<ListingResponse> GetListing(ListingRequest listingRequest)
        {
            using var request = new HttpRequestMessage(new HttpMethod("POST"), "https://gateway.daft.ie/old/v1/listings");
            request.Headers.TryAddWithoutValidation("authority", "gateway.daft.ie");
            request.Headers.TryAddWithoutValidation("pragma", "no-cache");
            request.Headers.TryAddWithoutValidation("cache-control", "no-cache, no-store");
            request.Headers.TryAddWithoutValidation("sec-ch-ua", "^^");
            request.Headers.TryAddWithoutValidation("sec-ch-ua-mobile", "?0");
            request.Headers.TryAddWithoutValidation("authorization", $"Bearer {_accessToken}");
            request.Headers.TryAddWithoutValidation("accept", "application/json");
            request.Headers.TryAddWithoutValidation("expires", "0");
            request.Headers.TryAddWithoutValidation("user-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/96.0.4664.110 Safari/537.36");
            request.Headers.TryAddWithoutValidation("brand", "daft");
            request.Headers.TryAddWithoutValidation("platform", "web");
            request.Headers.TryAddWithoutValidation("sec-ch-ua-platform", "^^");
            request.Headers.TryAddWithoutValidation("origin", "https://www.daft.ie");
            request.Headers.TryAddWithoutValidation("sec-fetch-site", "same-site");
            request.Headers.TryAddWithoutValidation("sec-fetch-mode", "cors");
            request.Headers.TryAddWithoutValidation("sec-fetch-dest", "empty");
            request.Headers.TryAddWithoutValidation("referer", "https://www.daft.ie/");
            request.Headers.TryAddWithoutValidation("accept-language", "en-GB,en-US;q=0.9,en;q=0.8,es;q=0.7");

            request.Content = new StringContent(JsonConvert.SerializeObject(listingRequest));
            request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");

            var response = await _httpClient.SendAsync(request);

            response.EnsureSuccessStatusCode();

            return JsonConvert.DeserializeObject<ListingResponse>(await response.Content.ReadAsStringAsync());
        }

        public async Task<PropertyResponse> GetProperty(int id)
        {
            using var request = new HttpRequestMessage(new HttpMethod("GET"), $"https://www.daft.ie/_next/data/Vegbv9CV_D9ff3d0bYLe_/property.json?id={id}");

            var response = await _httpClient.SendAsync(request);

            response.EnsureSuccessStatusCode();

            return JsonConvert.DeserializeObject<PropertyResponse>(await response.Content.ReadAsStringAsync());
        }
    }
}
