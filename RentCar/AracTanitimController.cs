using Microsoft.AspNetCore.Mvc;
using RentCar.Models;
using System.Diagnostics;


namespace RentCar.Controllers
{
    public class AracTanitimController : Controller
    {
        public int fiyat { get; set; }
        public int ID { get; set; }
        public string model { get; set; }
    }
}
