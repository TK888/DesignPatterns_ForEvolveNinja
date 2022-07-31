using Microsoft.AspNetCore.Mvc;

namespace NinjaAPI_ForEvolve.Controllers
{
    public class NinjaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
