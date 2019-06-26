using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using USC.Restaurante.Api.DTO;
using USC.Restaurante.Api.UoW.Infra;
using USC.Restaurante.Entities;
using USC.Restaurante.Helpers;

namespace USC.Restaurante.Api.Controllers
{
    [Route("api/autenticacao")]
    [ApiController]
    public class AutenticadorController : ControllerBase
    {
        private IAutenticadorUoW _autenticadorUoW;

        public AutenticadorController(IAutenticadorUoW autenticadorUoW)
        {
            _autenticadorUoW = autenticadorUoW;
        }

        [Route(""), HttpPost]
        public async Task<IActionResult> PostAutenticaAsync(Usuario usuario)
        {
            var response = new ResponseContent();
            try
            {
                response.Object = await _autenticadorUoW.autenticadorBLL.PostAutenticaAsync(usuario);
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
    }
}
