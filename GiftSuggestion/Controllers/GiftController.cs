using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using GiftSuggestion.Models;
using GiftSuggestion.Business;
using System.Threading.Tasks;

namespace GiftSuggestion.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GiftController : ControllerBase
    {
        private readonly IGiftBusiness _giftBusiness;
        private readonly ILogger<GiftController> _logger;

        public GiftController(IGiftBusiness giftBusiness, ILogger<GiftController> logger)
        {
            _giftBusiness = giftBusiness;
            _logger = logger;
        }

        [HttpPost]
        [Route("cadastrar")]
        public async Task<IActionResult> Post([FromBody] GiftModel model)
        {
            var giftCadastrado = await _giftBusiness.Cadastrar(model);
            return Ok(giftCadastrado); // adicionar uma mensagem indicando que o nome foi cadastrado
        }
    }
}
