using Microsoft.AspNetCore.Mvc;

namespace Restaurante.Controllers
{
    public class Restaurante : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Cardapio()
        {
            return View();
        }
        public IActionResult Bebidas()
        {
            return View();
        }
        public IActionResult Contato()
        {
            return View();
        }
    }
}
