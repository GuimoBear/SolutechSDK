using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolutechSDK.Responses
{
    public class CheckLimitResponse : BaseResponse
    {
        [JsonProperty("limite_diario")]
        public int DailyLimit { get; private set; }
        [JsonProperty("limite_diario_usado")]
        public int UsedDailyLimit { get; private set; }
        [JsonProperty("limite_diario_restante")]
        public int RemainingDailyLimit { get; private set; }
        [JsonProperty("expira")]
        public DateTime ExpireAt { get; private set; }
    }
}
