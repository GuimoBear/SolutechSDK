using Newtonsoft.Json;

namespace SolutechSDK.Responses
{
    public class CheckStatusResponse : BaseResponse
    {
        [JsonProperty("logado")]
        public string Logged { get; private set; }
        [JsonProperty("pronto")]
        public string Ready { get; private set; }
        [JsonProperty("nome")]
        public string Name { get; private set; }
        [JsonProperty("telefone")]
        public string Cellphone { get; private set; }
    }
}
