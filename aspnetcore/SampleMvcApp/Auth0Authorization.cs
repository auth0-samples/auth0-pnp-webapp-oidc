using Newtonsoft.Json;

namespace SampleMvcApp
{
    public class Auth0Authorization
    {
        [JsonProperty("groups")]
        public string[] Groups { get; set; }
    }
}