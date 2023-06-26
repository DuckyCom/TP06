using Microsoft.AspNetCore.Mvc;

namespace TP06.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
