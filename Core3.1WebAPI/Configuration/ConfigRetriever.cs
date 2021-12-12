using Core3._1WebAPI.Configuration;
using Core3dot1WebAPI.Configuration.Interfaces;
using Microsoft.Extensions.Configuration;

namespace Core3dot1WebAPI.Configuration
{
    public class ConfigRetriever : IConfigRetriever
    {
        public IConfiguration Configuration { get; set; }

        public ConfigRetriever(IConfiguration config)
        {
            Configuration = config;
        }

        public Core3dot1WebAPIConfiguration Get()
        {
            var config = new Core3dot1WebAPIConfiguration()
            {
                ThirdPartyAPI = Configuration["ThirdPartyAPIURL"]
            };
            return config;
        }
    }
}
