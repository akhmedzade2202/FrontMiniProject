using Microsoft.AspNetCore.Mvc;

namespace FiorelloMVCProject.Controllers
{
    public class PagesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
