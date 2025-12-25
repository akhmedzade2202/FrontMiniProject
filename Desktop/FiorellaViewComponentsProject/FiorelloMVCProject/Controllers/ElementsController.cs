using Microsoft.AspNetCore.Mvc;

namespace FiorelloMVCProject.Controllers
{
    public class ElementsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
