using LainsaadantoService.Libs.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LainsaadantoService.Libs.Services
{
    public interface ILainsaadantoService
    {
        Task<List<DataModel>> GetLainsaadantoData();
    }
}
