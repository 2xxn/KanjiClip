using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace KanjiClip
{
    public class TranslationResponse {
        [JsonProperty("kanji")]
        public string Kanji { get; set; }

        [JsonProperty("translation")]
        public string Translation { get; set; }

        [JsonProperty("romaji")]
        public string Romaji { get; set; }
    }

    internal class NanoGPTClient
    {
        public const string DefaultUrl = "https://nano-gpt.com/api/v1";
        public const string Model = "chatgpt-4o-latest";

        private readonly string token;
        private readonly string apiUrl;
        private readonly HttpClient httpClient;

        private const string prompt = "You are an OCR Translator. Look at the kanji provided in the screenshot, write it down along with the translation in English and romanization (no special characters like ū, ō, or other diacritics) in the following JSON format: {\"kanji\": \"<kanji>\", \"translation\": \"<translation>\", \"romaji\": \"<romaji>\"}. Only provide the JSON object, nothing else.";

        public NanoGPTClient(string token, string url = DefaultUrl)
        {
            this.token = token;
            this.apiUrl = url;
            this.httpClient = new HttpClient();

            this.httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
            this.httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows; Windows NT 10.1; en-US) Gecko/20100101 Firefox/45.6");
        }

        public async Task<TranslationResponse> Translate(string imgUrl)
        {
            // There's a 1000 different ways to do this in a cleaner manner but I don't care
            var userMessage = new { role = "user", content = new object[]{new{ type = "image_url", image_url = new { url = imgUrl, detail = "high" } } } };
            var systemMessage = new{ role = "system", content = new object[]{ new { type = "text", text = prompt } } };

            var requestBody = new
            {
                model = Model,
                stream = false,
                messages = new object[]
                {
                    systemMessage,
                    userMessage
                }
            };

            var requestJson = JsonConvert.SerializeObject(requestBody);
            var content = new StringContent(requestJson, Encoding.UTF8, "application/json");

            var response = await httpClient.PostAsync($"{apiUrl}/chat/completions", content);
            var responseJson = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                return null;
            }


            dynamic jsonResponse = JsonConvert.DeserializeObject(responseJson);

            string result = jsonResponse.choices[0].message.content.ToString();

            result = result.StartsWith("```json") ? result.Substring(7).Trim() : result;
            result = result.StartsWith("```") ? result.Substring(3).Trim() : result;
            result = result.EndsWith("```") ? result.Substring(0, result.Length - 3).Trim() : result;

            return JsonConvert.DeserializeObject<TranslationResponse>(result);
        }
    }
}
