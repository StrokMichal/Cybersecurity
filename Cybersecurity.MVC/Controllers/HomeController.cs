using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Cybersecurity.MVC.Models;

namespace Cybersecurity.MVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
    public IActionResult About()
    {
        var model = new About()
        {
            Title = "Cybersec app",
            Description = "jakis opis",
            Tags = ["car", "app", "free"]
        };

        return View(model);
    }
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
