using System.Diagnostics;
using FiorelloMVCProject.Data;
using FiorelloMVCProject.Models;
using FiorelloMVCProject.Services.Interfaces;
using FiorelloMVCProject.ViewsModel;
using FiorelloMVCProject.ViewsModel.Blog;
using FiorelloMVCProject.ViewsModel.Expert;
using FiorelloMVCProject.ViewsModel.Slider;
using FiorelloMVCProject.ViewsModel.SliderInfo;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FiorelloMVCProject.Controllers
{
    public class HomeController : Controller
    {
        public async Task <IActionResult> Index()
        {
            return View();
        }
    }
}
