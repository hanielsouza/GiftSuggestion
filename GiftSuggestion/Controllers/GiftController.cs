using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using GiftSuggestion.Models;

namespace GiftSuggestion.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GiftController : ControllerBase
    {
        
        private readonly ILogger<GiftController> _logger;

        public GiftController(ILogger<GiftController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public ActionResult Post()
        {
            return Ok("produto tal cadastrado com sucesso");
        }
    }
}
