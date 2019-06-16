using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace USC.Restaurante.Api.Controllers
{
    [Route("api/usuarios")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        [Route(""), HttpGet]
        public async Task<IActionResult> GetUsuarios()
        {
            return Ok("Usuário teste");
        }

        [Route("{idUsuario}"), HttpGet]
        public async Task<IActionResult> GetUsuario(long idUsuario)
        {
            return Ok("Usuário teste");
        }

        [Route(""), HttpPost]
        public async Task<IActionResult> PostUsuario()
        {
            return Ok("Usuário teste");
        }

        [Route("{idUsuario}"), HttpPut]
        public async Task<IActionResult> PutUsuario(long idUsuario)
        {
            return Ok("Usuário teste");
        }
    }
}