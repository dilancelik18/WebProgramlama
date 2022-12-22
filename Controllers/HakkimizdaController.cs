using Microsoft.AspNetCore.Mvc;

namespace RentCar.Controllers
{
    public class HakkimizdaController: Controller
    {

        public IActionResult Hakkimizda()
        {
            return View();
        }
    }
}
