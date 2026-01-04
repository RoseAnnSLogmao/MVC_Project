using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVC_Activity.Models;

namespace MVC_Activity.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var pins = new List<Pin>
    {
        new Pin { Id = 1, Title = "Nature", ImageUrl = "/images/nature.jpg", Description = "Green vibes" },
        new Pin { Id = 2, Title = "Art", ImageUrl = "/images/art.jpg", Description = "Creative mood" }
    };

    return View(pins);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Login()
    {
        return View();
    }

    public IActionResult Register()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
