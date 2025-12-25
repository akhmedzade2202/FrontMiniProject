using Microsoft.AspNetCore.Mvc;

namespace FiorelloMVCProject.Controllers
{
    public class PortfolioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
