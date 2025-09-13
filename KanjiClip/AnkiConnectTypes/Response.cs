using Newtonsoft.Json;

namespace KanjiClip.AnkiConnectTypes
{
    public class Response<T>
    {
        [JsonProperty("result")]
        public T Result { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }
    }
}
