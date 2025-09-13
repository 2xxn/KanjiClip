using Newtonsoft.Json;

namespace KanjiClip.AnkiConnectTypes
{
    public class AddCard
    {
        [JsonProperty("note")]
        public Note Note;
    }
}
