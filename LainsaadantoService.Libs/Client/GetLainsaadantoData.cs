using LainsaadantoService.Libs.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace LainsaadantoService.Libs.Client
{
    public class GetLainsaadantoData :IGetLainsaadantoData
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public GetLainsaadantoData(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<DataModel> ReturnLainsaandantoData()
        {
            var client = _httpClientFactory.CreateClient();
            string today = DateTime.Now.ToString("yyyy-dd-MM");
            string search = $"{{ \"asettamisPaivaAlku\": \"2015-05-29\",\"asettamisPaivaLoppu\": \"{today}\",\"size\": 10, \"tyyppi\": [\"LAINSAADANTO\"],\"tila\":[\"KAYNNISSA\"]}}";

            var httpContent = new StringContent(search);
            httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            var url = new Uri($"https://api.hankeikkuna.fi/api/v1/kohteet/haku");

            var response = await client.PostAsync(url, httpContent);
            string json;
            using (var content = response.Content)
            {
                json = await content.ReadAsStringAsync();
            }
            return JsonConvert.DeserializeObject<DataModel>(json);
        }

    }
}
