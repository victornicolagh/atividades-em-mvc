using Microsoft.AspNetCore.Mvc;

namespace Exercicio03_Cinema.Controllers
{
    public class CinemaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Filmes()
        {
            return View();
        }
        public IActionResult Ingressos()
        {
            return View();
        }
    }
}
