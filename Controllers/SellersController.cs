using Microsoft.AspNetCore.Mvc;

namespace LojaVirtual.Controllers
{
    public class SellersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}