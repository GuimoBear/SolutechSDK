using SolutechSDK.Responses;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace SolutechSDK.Requests
{
    public class CheckStatusRequest : BaseRequest<CheckStatusResponse>
    {
        protected override string EndPoint => URL_BASE + "status";
        protected override HttpMethod Method => HttpMethod.Post;

        public CheckStatusRequest(APIConfig config) : base(config) { }

        protected override void Validate() { }
    }
}
