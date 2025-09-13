using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace KanjiClip
{
    internal class ImgBB
    {
        public const string ApiUrl = "https://api.imgbb.com/1/upload";

        private readonly string apiKey;
        private readonly HttpClient httpClient;

        public ImgBB(string apiKey)
        {
            this.apiKey = apiKey;
            this.httpClient = new HttpClient();
        }

        private string ConvertToBase64(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, ImageFormat.Png);     
                byte[] imageBytes = ms.ToArray();
                return Convert.ToBase64String(imageBytes);
            }
        }

        public async Task<string> UploadPhoto(Image img)
        {
            var query = HttpUtility.ParseQueryString(string.Empty);
            query["expiration"] = "600";
            query["key"] = apiKey;

            var uriBuilder = new UriBuilder(ApiUrl) { Query = query.ToString() };
            var data = ConvertToBase64(img);

            MultipartFormDataContent form = new MultipartFormDataContent
            {
                { new StringContent(data), "image" }
            };

            var response = await httpClient.PostAsync(uriBuilder.ToString(), form);

            if (!response.IsSuccessStatusCode)
            {
                return null;
            }

            var responseJson = await response.Content.ReadAsStringAsync();
            dynamic jsonResponse = Newtonsoft.Json.JsonConvert.DeserializeObject(responseJson);

            return jsonResponse.data.url.ToString();
        }
    }
}
