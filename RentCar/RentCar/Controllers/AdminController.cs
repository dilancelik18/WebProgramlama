using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace RentCar.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Authorize(Policy = "RequireManager")]

        public IActionResult Manager()
        {
            return View();
        }

        [Authorize(Policy ="RequireAdmin")]

        public IActionResult Admin()
        {
            return View();
        }
    }
}
