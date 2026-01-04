using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using MVC_Activity.Models; // Replace with your actual namespace

namespace MVC_Activity.Controllers
{
    public class PinsController : Controller
    {
        private static List<Pin> pins = new();

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Pin pin)
        {
            pin.Id = pins.Count + 1;
            pins.Add(pin);

            return RedirectToAction("Index", "Home");
        }

        public IActionResult Details(int id)
        {
            var pin = pins.FirstOrDefault(p => p.Id == id);
            return View(pin);
        }
    }
}
