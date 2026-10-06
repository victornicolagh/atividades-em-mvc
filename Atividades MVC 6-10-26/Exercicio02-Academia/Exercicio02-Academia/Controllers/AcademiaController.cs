using Microsoft.AspNetCore.Mvc;

namespace Exercicio02_Academia.Controllers
{
    public class AcademiaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Musculacao()
        {
            return View();
        }
        public IActionResult Cardio()
        {
            return View();
        }
        public IActionResult Planos()
        {
            return View();
        }
    }
}
