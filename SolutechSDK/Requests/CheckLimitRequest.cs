using SolutechSDK.Responses;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace SolutechSDK.Requests
{
    public class CheckLimitRequest : BaseRequest<CheckLimitResponse>
    {
        protected override string EndPoint => URL_BASE + "limites";
        protected override HttpMethod Method => HttpMethod.Post;

        public CheckLimitRequest(APIConfig config) : base(config) { }

        protected override void Validate() { }
    }
}
