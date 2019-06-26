using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using USC.Restaurante.Api.UoW.Infra;
using USC.Restaurante.Helpers;

namespace USC.Restaurante.Api.Controllers
{
    [Route("api/restaurantes")]
    [ApiController]
    public class RestauranteController : ControllerBase
    {
        private IRestautanteUoW _restauranteUoW;

        public RestauranteController(IRestautanteUoW restauranteUoW)
        {
            _restauranteUoW = restauranteUoW;
        }

        [Route(""), HttpGet]
        public async Task<IActionResult> GetRestaurantes()
        {
            var response = new ResponseContent();
            try
            {
                response.Object = await _restauranteUoW.restauranteBLL.GetAllRestauranteAsync();
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

        [Route("{idRestaurante}"), HttpGet]
        public async Task<IActionResult> GetRestaurante(long idRestaurante)
        {
            var response = new ResponseContent();
            try
            {
                response.Object = await _restauranteUoW.restauranteBLL.GetRestauranteAsync(idRestaurante);
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

        [Route(""), HttpPost]
        public async Task<IActionResult> PostRestaurante(Entities.Restaurante restaurante)
        {
            var response = new ResponseContent();
            try
            {
                response.Object = await _restauranteUoW.restauranteBLL.PostRestauranteAsync(restaurante);
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

        [Route("{idRestaurante}"), HttpPut]
        public async Task<IActionResult> PutRestaurante(Entities.Restaurante restaurante)
        {
            var response = new ResponseContent();
            try
            {
                response.Object = await _restauranteUoW.restauranteBLL.PutRestauranteAsync(restaurante);
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
