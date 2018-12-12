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

        public async Task<List<DataModel>> ReturnLainsaandantoData()
        {
            var client = _httpClientFactory.CreateClient();
            string today = DateTime.Now.ToString("yyyy-dd-MM");
            string search = $"{{ \"asettamisPaivaAlku\": \"2015-05-29\",\"asettamisPaivaLoppu\": \"{today}\",\"size\": 600, \"tyyppi\": [\"LAINSAADANTO\"],\"tila\":[\"KAYNNISSA\"]}}";

            var httpContent = new StringContent(search);
            httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            var url = new Uri($"https://api.hankeikkuna.fi/api/v1/kohteet/haku");

            var response = await client.PostAsync(url, httpContent);
            string json;
            using (var content = response.Content)
            {
                json = await content.ReadAsStringAsync();
            }
            dynamic readyJson = JsonConvert.DeserializeObject(json);

            List<DataModel> dataModels = new List<DataModel>();
            foreach (dynamic item in readyJson.result)
            {
                DataModel dataModel = new DataModel();
                dataModel.LiittyLainsaadantoon = item.kohde.liittyyLainsaadantoon;
                dataModel.Tyyppi = item.kohde.tyyppi;
                dataModel.Tila = item.kohde.tila;
                dataModel.Nimi = item.kohde.nimi.fi;
                dataModel.Tiivistelma = item.kohde.tiivistelma.fi;
                dataModel.Rauennut = item.lainsaadanto.heTiedot.rauennut;
                dataModel.Vastuuministeri = DataModel.HaeMinisteri((string)item.lainsaadanto.heTiedot.vastuuministeri);
                dataModels.Add(dataModel);
            }

            return dataModels;
        }

    }
}
