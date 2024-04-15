using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MiddlewareDemoPrep2024.Services;

namespace MiddlewareDemoPrep2024.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InfoController : ControllerBase
    {
        private readonly InfoService _infoService;

        public InfoController(InfoService infoService)
        {
            _infoService = infoService;
        }


        // GET: api/<InfoController>
        [HttpGet]
        public string Get()
        {
            return _infoService.GetInformation();
        }

    }
}
