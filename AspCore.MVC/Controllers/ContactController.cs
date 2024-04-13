using Microsoft.AspNetCore.Mvc;

namespace AspCore.MVC.Controllers;

public class ContactController : Controller
{
    public IActionResult Contact()
    {
        return View();
    }
}
