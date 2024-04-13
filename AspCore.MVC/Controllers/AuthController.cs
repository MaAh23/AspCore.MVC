using Microsoft.AspNetCore.Mvc;

namespace AspCore.MVC.Controllers;

public class AuthController : Controller
{
    public IActionResult SignUp()
    {
        return View();
    }
}
