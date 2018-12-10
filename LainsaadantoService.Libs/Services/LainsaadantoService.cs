using LainsaadantoService.Libs.Client;
using LainsaadantoService.Libs.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LainsaadantoService.Libs.Services
{
    public class LainsaadantoService :ILainsaadantoService
    {
        private readonly IGetLainsaadantoData _getLainsaadantoData;

        public LainsaadantoService(IGetLainsaadantoData getLainsaadantoData)
        {
            _getLainsaadantoData = getLainsaadantoData;
        }
        public async Task<DataModel> GetLainsaadantoData()
        {
            return await _getLainsaadantoData.ReturnLainsaandantoData();
        }
        
    }
}
