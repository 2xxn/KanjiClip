using Newtonsoft.Json;

namespace KanjiClip.AnkiConnectTypes
{
    public class Request
    {
        [JsonProperty("action")]
        public string Action { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }
        
        [JsonProperty("params", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic Params { get; set; }
    }
}
