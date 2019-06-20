using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using USC.Restaurante.Api.UoW.Infra;

namespace USC.Restaurante.Api.Controllers
{
    [Route("api/usuarios")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private IUsuarioUoW _usuarioUoW;

        public UsuarioController(IUsuarioUoW usuarioUoW)
        {
            _usuarioUoW = usuarioUoW;
        }

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