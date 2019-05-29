namespace SolutechSDK
{
    public class APIConfigBuilder
    {
        private APIConfig config;
        public APIConfigBuilder()
            => config = new APIConfig();

        public APIConfigBuilder WithEmail(string email)
        {
            config.Email = email;
            return this;
        }

        public APIConfigBuilder WithToken(string token)
        {
            config.Token = token;
            return this;
        }

        public APIConfigBuilder WithIdApp(string idApp)
        {
            config.IdApp = idApp;
            return this;
        }

        public APIConfig Build()
            => config;

    }

    public class APIConfig
    {
        public string Email { get; internal set; }
        public string Token { get; internal set; }
        public string IdApp { get; internal set; }

        internal APIConfig() { }

        public APIConfig(string email, string token, string idApp)
        {
            Email = email;
            Token = token;
            IdApp = idApp;
        }
    }
}
