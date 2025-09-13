using Newtonsoft.Json;
using System.Collections.Generic;

namespace KanjiClip.AnkiConnectTypes
{
    public class Fields
    {
        public string Front { get; set; }
        public string Back { get; set; }
    }

    public class Note
    {
        [JsonProperty("deckName")]
        public string DeckName { get; set; }

        [JsonProperty("modelName")]
        public string ModelName { get; set; }

        [JsonProperty("fields")]
        public Fields NoteFields { get; set; }

        [JsonProperty("tags")]
        public List<string> Tags { get; set; }
    }
}
