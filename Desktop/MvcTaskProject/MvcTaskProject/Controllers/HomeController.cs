using Microsoft.AspNetCore.Mvc;
using MvcTaskProject.Data;
using MvcTaskProject.Models;
using MvcTaskProject.ViewModels;

namespace MvcTaskProject.Controllers
{
    
        public class HomeController : Controller
        {
            private readonly AppDbContext _context;
            public HomeController(AppDbContext context)
            {
                _context = context;
            }

            public IActionResult Index()
            {
            List<Slider> sliders = _context.Sliders.ToList();
            SliderInfo sliderInfo = _context.SliderInfos.FirstOrDefault();

                // Eğer SliderInfo yoksa, default bir tane oluştur
                if (sliderInfo == null)
                {
                    sliderInfo = new SliderInfo
                    {
                        Title = "Welcome",
                        Description = "Default description",
                        SignatureImage = "default.png"
                    };
                }

                HomeVM model = new HomeVM()
                {
                    Sliders = sliders,
                    SliderInfo = sliderInfo
                };

                return View(model);
            }
        }
    }

