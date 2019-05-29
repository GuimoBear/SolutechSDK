using System.Net.Http;
using Newtonsoft.Json;
using SolutechSDK.Enums;
using SolutechSDK.Responses;

namespace SolutechSDK.Requests
{
    public class SendMessageRequest : BaseRequest<SendMessageResponse>
    {
        protected override string EndPoint => URL_BASE + "enviar";
        protected override HttpMethod Method => HttpMethod.Post;

        [JsonProperty]
        private string midia
            => Midia.ToString().ToLower();

        [JsonProperty]
        private string emoji
            => UsaEmoji.ToString().ToLower();

        [JsonProperty("idmsg")]
        public string IdMessage { get; set; }
        [JsonIgnore]
        public TipoMidia Midia { get; set; }
        [JsonProperty("url_anexo")]
        public string UrlAnexo { get; set; }
        [JsonProperty("whatsapp")]
        public string Whatsapp { get; set; }
        [JsonProperty("mensagem")]
        public string Mensagem { get; set; }
        [JsonIgnore]
        public UsaEmoji UsaEmoji { get; set; }

        public SendMessageRequest(APIConfig config) : base(config) { }

        protected override void Validate() { }
    }
}
