using Microsoft.AspNetCore.Mvc;

namespace MvcTaskProject.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
