using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MvcPrac.Models;

namespace MvcPrac.Controllers
{
    public class HomeController : Controller
    {
        

        public IActionResult Index()
        {
            return View();
        }

       
    }
}
