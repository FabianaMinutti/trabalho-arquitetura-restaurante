using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using USC.Restaurante.Api.UoW.Infra;
using USC.Restaurante.Helpers;

namespace USC.Restaurante.Api.Controllers
{
    [Route("api/votos")]
    [ApiController]
    public class VotosController : ControllerBase
    {
        private IVotosUoW _votosUoW;

        public VotosController(IVotosUoW votosUoW)
        {
            _votosUoW = votosUoW;
        }

        [Route("{idUsuario}"), HttpGet]
        public async Task<IActionResult> GetVotosUsuario(long idUsuario)
        {
            var response = new ResponseContent();
            try
            {
                response.Object = await _votosUoW.votosBLL.GetVotosUsuario(idUsuario, null);
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
