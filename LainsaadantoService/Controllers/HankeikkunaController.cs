using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LainsaadantoService.Libs.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LainsaadantoService.Controllers
{
    
    public class HankeikkunaController : ControllerBase
    {
        private readonly ILainsaadantoService _lainsaadantoaService;
        public HankeikkunaController(ILainsaadantoService lainsaadantoService)
        {
            _lainsaadantoaService = lainsaadantoService;
        }

        [HttpGet]
        [Route("api/v1/hankeikkuna/lainsaadanto/")]
        public async Task<ActionResult> GetLainsaadantoData()
        {
            var result = await _lainsaadantoaService.GetLainsaadantoData();
            var query = from item in result
                        where item.Rauennut == false
                        where item.LiittyLainsaadantoon == true
                        group item by new { item.Vastuuministeri.LastName, item.Tila };

            return Ok(query);
        }

    }
}