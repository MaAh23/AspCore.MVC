using Microsoft.AspNetCore.Mvc;

namespace AspCore.MVC.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
