using Newtonsoft.Json;
using SolutechSDK.Responses;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SolutechSDK.Requests
{
    public abstract class BaseRequest<TResponse>
        where TResponse: BaseResponse
    {
        protected const string URL_BASE = "https://www.solutek.online/api/whatsapp/gateway/json/";

        private readonly APIConfig config;

        protected abstract string EndPoint { get; }
        protected abstract HttpMethod Method { get; }

        [JsonProperty("email")]
        private string Email => config?.Email;
        [JsonProperty("token")]
        private string Token => config?.Token;
        [JsonProperty("idapp")]
        private string IdApp => config?.IdApp;

        public BaseRequest(APIConfig config)
            => this.config = config;

        protected abstract void Validate();

        public async Task<TResponse> SendAsync()
        {
            var jsonBody = JsonConvert.SerializeObject(this);
            using (var client = new HttpClient())
            {
                var request = new HttpRequestMessage(Method, EndPoint);
                request.Content = new StringContent(jsonBody, Encoding.UTF8, "application/json");
                var response = await client.SendAsync(request);
                var strResponse = await response.Content.ReadAsStringAsync();
                if (!response.IsSuccessStatusCode)
                    throw new HttpRequestException("Ocorreu um erro ao enviar uma mensagem para a solutek: " + response);
                return JsonConvert.DeserializeObject<TResponse>(strResponse);
            }
        }

        public TResponse Send()
            => SendAsync().GetAwaiter().GetResult();
    }
}
