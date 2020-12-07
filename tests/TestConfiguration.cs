using Microsoft.Extensions.Configuration;

namespace playing_with_rapidapi.tests
{
    public class TestConfiguration
    {
        public IConfiguration Configuration { get; set; }
        public TestConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .AddUserSecrets<TestConfiguration>();

            Configuration = builder.Build();
        }
    }
}
