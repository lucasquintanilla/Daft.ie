using Daft.Services.Daft.Auth.Models;
using Daft.Services.Daft.Property.Models;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace Daft.Services.Daft
{
    public partial class DaftService
    {
        public async Task Auth()
        {
            var handler = new HttpClientHandler
            {
                AutomaticDecompression = System.Net.DecompressionMethods.All
            };
            handler.CookieContainer.Add(new System.Net.Cookie("daftCC", "\"{\"version\":1,\"createDate\":1634766522658,\"lastUpdated\":1634766522658,\"expires\":1650491322658,\"strictlyNecessary\":true,\"analytics\":true,\"functional\":true,\"advertising\":true}\"", "/", ".daft.ie"));
            handler.CookieContainer.Add(new System.Net.Cookie("daftBB", "true", "/", ".daft.ie"));
            handler.CookieContainer.Add(new System.Net.Cookie("session", "eyJyZXR1cm5UbyI6Ii9mb3ItcmVudC9hcGFydG1lbnQtNjEtc291dGgtZ3JlYXQtZ2Vvcmdlcy1zdHJlZXQtZHVibGluLTIvMzY0NzA5NiIsInBhc3Nwb3J0Ijp7fSwidXNlclN1YiI6IjNiMjM4YTFlLTcwNmYtNGYzNy05NmM1LTNlYTU5MDI5ZGJlYSIsImxhc3RSZWZyZXNoIjoxNjQwMTM2MzY1MTQyfQ==", "/", ".daft.ie"));
            handler.CookieContainer.Add(new System.Net.Cookie("session.sig", "uzRhb7mxZBjDOBc6MiSLK8UgNIU", "/", ".daft.ie"));

            using var httpClient = new HttpClient(handler);
            using var request = new HttpRequestMessage(new HttpMethod("POST"), "https://www.daft.ie/api/user");
            request.Headers.TryAddWithoutValidation("authority", "www.daft.ie");
            request.Headers.TryAddWithoutValidation("content-length", "0");
            request.Headers.TryAddWithoutValidation("pragma", "no-cache");
            request.Headers.TryAddWithoutValidation("cache-control", "no-cache");
            request.Headers.TryAddWithoutValidation("sec-ch-ua", "^^");
            request.Headers.TryAddWithoutValidation("accept", "application/json, text/plain, */*");
            request.Headers.TryAddWithoutValidation("sec-ch-ua-mobile", "?0");
            request.Headers.TryAddWithoutValidation("user-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/96.0.4664.110 Safari/537.36");
            request.Headers.TryAddWithoutValidation("sec-ch-ua-platform", "^^");
            request.Headers.TryAddWithoutValidation("origin", "https://www.daft.ie");
            request.Headers.TryAddWithoutValidation("sec-fetch-site", "same-origin");
            request.Headers.TryAddWithoutValidation("sec-fetch-mode", "cors");
            request.Headers.TryAddWithoutValidation("sec-fetch-dest", "empty");
            request.Headers.TryAddWithoutValidation("referer", "https://www.daft.ie/sharing/ireland?sort=priceAsc&firstPublishDate_from=now-3d^%^2Fd&location=dublin-2-dublin&location=dublin-4-dublin&location=dublin-6-dublin");
            request.Headers.TryAddWithoutValidation("accept-language", "en-GB,en-US;q=0.9,en;q=0.8,es;q=0.7");

            var response = await httpClient.SendAsync(request);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            var authResponse = JsonConvert.DeserializeObject<AuthResponse>(content);

            _accessToken = authResponse.AccessToken;
        }
    }
}
