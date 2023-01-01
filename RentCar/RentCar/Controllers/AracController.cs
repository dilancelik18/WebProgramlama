using Microsoft.AspNetCore.Mvc;
using RentCar.Models.Siniflar;

namespace RentCar.Controllers
{
	public class AracController : Controller
	{
        ApplicationDbContext c = new ApplicationDbContext();
        public IActionResult Arac()
        {
            var arac = c.aracs.ToList();
            return View(arac);
        }
    }
}
