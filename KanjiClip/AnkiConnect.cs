using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using KanjiClip.AnkiConnectTypes;

namespace KanjiClip
{
    public class AnkiConnect
    {
        // Default URL for AnkiConnect, no idea if it's configurable
        public const string DefaultUrl = "http://127.0.0.1:8765";

        private readonly HttpClient httpClient = new HttpClient();

        public AnkiConnect()
        {
            this.httpClient = new HttpClient();
        }

        private async Task<Response<T>> Invoke<T>(string action, dynamic parameters = null, string url = DefaultUrl)
        {
            var request = new Request
            {
                Action = action,
                Version = 6,
                Params = parameters
            };

            var requestJson = JsonConvert.SerializeObject(request);
            var content = new StringContent(requestJson, Encoding.UTF8, "application/json");

            var response = await httpClient.PostAsync(url, content);
            var responseJson = await response.Content.ReadAsStringAsync();

            var result = JsonConvert.DeserializeObject<Response<T>>(responseJson);

            return result;
        }

        public async Task<bool> IsAnkiConnectPresent()
        {
            try
            {
                var response = await Invoke<object>("version");

                return response.Error == null;
            }
            catch
            {
                return false;
            }
        }

        public async Task<List<string>> GetDecks()
        {
            var response = await Invoke<List<string>>("deckNames");

            return response.Result;
        }

        public async Task<bool> AddNote(Note note)
        {
            var response = await Invoke<object>("addNote", new AddCard{ Note = note });

            return response.Error == null;
        }
    }
}
