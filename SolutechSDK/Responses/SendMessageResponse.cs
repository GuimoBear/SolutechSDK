using Newtonsoft.Json;

namespace SolutechSDK.Responses
{
    public class SendMessageResponse : BaseResponse
    {
        [JsonProperty("erro")]
        private string strError;
        [JsonProperty("sobre_o_erro")]
        private string errorMessage;

        public bool HasError => "sim".Equals(strError);
        public string ErrorMessage => errorMessage;
        [JsonProperty("whatsapp")]
        public string Whatsapp { get; private set; }
        [JsonProperty("mensagem")]
        public string Message { get; private set; }
        [JsonProperty("status")]
        public string Status { get; private set; }
        [JsonProperty("idlog")]
        public string IdLog { get; private set; }
    }
}
