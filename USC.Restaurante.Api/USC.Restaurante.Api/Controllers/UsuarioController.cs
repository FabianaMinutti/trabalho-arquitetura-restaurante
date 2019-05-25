using Microsoft.AspNetCore.Mvc;

namespace USC.Restaurante.Api.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}