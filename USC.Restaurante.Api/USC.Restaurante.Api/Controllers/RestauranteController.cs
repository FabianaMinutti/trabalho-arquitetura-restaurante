using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace USC.Restaurante.Api.Controllers
{
    [Route("api/restaurantes")]
    [ApiController]
    public class RestauranteController : ControllerBase
    {
        [Route(""), HttpGet]
        public async Task<IActionResult> GetRestaurantes()
        {
            return Ok("Teste");
        }

        [Route("{idRestaurante}"), HttpGet]
        public async Task<IActionResult> GetRestaurante(long idRestaurante)
        {
            return Ok("Teste");
        }

        [Route(""), HttpPost]
        public async Task<IActionResult> PostRestaurante()
        {
            return Ok("Teste");
        }

        [Route("{idRestaurante}"), HttpPut]
        public async Task<IActionResult> PutRestaurante(long idRestaurante)
        {
            return Ok("Teste");
        }
    }
}
