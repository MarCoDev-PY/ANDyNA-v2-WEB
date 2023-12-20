using Microsoft.AspNetCore.Mvc;

namespace ANDyNA_v2.Controllers
{
    public class InicioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
