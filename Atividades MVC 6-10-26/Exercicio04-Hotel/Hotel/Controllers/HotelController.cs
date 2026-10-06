using Microsoft.AspNetCore.Mvc;

namespace Hotel.Controllers
{
    public class HotelController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Quartos()
        {
            return View();
        }
        public IActionResult Servicos()
        {
            return View();
        }
        public IActionResult Contato()
        {
            return View();
        }
    }
}
