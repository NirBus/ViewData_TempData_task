using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ViewData_TempData_task.Models;

namespace ViewData_TempData_task.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult Index()
        {
            List<Slider> sliders = new List<Slider>()
            {
                new Slider
                {
                    Id=1,
                    Image="https://htmldemo.net/juan/juan/assets/img/slider/slider-1.jpg"
                },

                new Slider
                {
                    Id=2,
                    Image="https://htmldemo.net/juan/juan/assets/img/slider/slider-2.jpg"
                }
            };

            ViewBag.Sliders=sliders;

            return View();
        }
    }
}
