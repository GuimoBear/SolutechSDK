using Newtonsoft.Json;

namespace SolutechSDK.Responses
{
    public class BaseResponse
    {
        [JsonProperty("erro")]
        private string strError;
        [JsonProperty("sobre_o_erro")]
        private string errorMessage;

        public bool HasError => "sim".Equals(strError);
        public string ErrorMessage => errorMessage;
    }
}
