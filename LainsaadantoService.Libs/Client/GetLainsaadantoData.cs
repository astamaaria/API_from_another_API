using LainsaadantoService.Libs.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace LainsaadantoService.Libs.Client
{
    public class GetLainsaadantoData :IGetLainsaadantoData
    {
        public async Task<DataModel> ReturnLainsaandantoData()
        {
            using (var client = new HttpClient())
            {
            var url = new Uri($"https://api.hankeikkuna.fi/api/v1/kohteet/haku");

            var response = await client.GetAsync(url);
            string json;
            using (var content = response.Content)
            {
                json = await content.ReadAsStringAsync();
            }
            return JsonConvert.DeserializeObject<DataModel>(json);
            }
        }

    }
}
