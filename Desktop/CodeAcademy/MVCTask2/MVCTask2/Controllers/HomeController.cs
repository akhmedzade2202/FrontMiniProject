using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WebApplicationMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // Task 1: Məhsullar siyahısı
            List<string> products = new List<string>()
            {
                "Xosu",
                "Kantdisanata",
                "Aparatlar",
                "Balaeli"
            };

            ViewData["Products"] = products;

            
            bool isSuccess = true; 
            ViewBag.IsSuccess = isSuccess;

            return View();
        }
    }
}
