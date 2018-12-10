using LainsaadantoService.Libs.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LainsaadantoService.Libs.Client
{
    public interface IGetLainsaadantoData
    {
        Task<DataModel> ReturnLainsaandantoData();
    }
}
