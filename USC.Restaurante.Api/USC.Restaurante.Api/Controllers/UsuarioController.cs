using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using USC.Restaurante.Api.UoW.Infra;
using USC.Restaurante.Entities;
using USC.Restaurante.Helpers;

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
        public async Task<IActionResult> PostUsuario([FromBody] Usuario usuario)
        {
            var response = new ResponseContent();
            try
            {
                response.Object = await _usuarioUoW.usuarioBLL.PostUsuarioAsync(usuario);
                response.Message = "Requisição realizada com sucesso.";
                response.Status = true;
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                response.Status = false;
            }

            return Ok(response);
        }

        [Route("{idUsuario}"), HttpPut]
        public async Task<IActionResult> PutUsuario(long idUsuario)
        {
            return Ok("Usuário teste");
        }
    }
}