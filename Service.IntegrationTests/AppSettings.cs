namespace Service.IntegrationTests
{
    using Microsoft.Extensions.Configuration;

    internal static class AppSettings
    {
        private static ServiceOptions Configuration { get; }

        static AppSettings()
        {
            var configurationBuilder = new ConfigurationBuilder();
            configurationBuilder.AddJsonFile("config.json");
            Configuration = configurationBuilder.Build().Get<ServiceOptions>();
        }

        public static string ServiceUrl => Configuration.ServiceUrl;
    }
}
