using Microsoft.AspNetCore.Mvc;
using RentCar.Models;
using System.Diagnostics;

namespace RentCar.Controllers
{
    public class HomeController : Controller
    {

     
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Hakkimizda()
        {
            return View();
        }
        public IActionResult Arac()
        {
            return View();
        }

    }
}