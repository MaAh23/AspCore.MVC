using AspCore.MVC.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AspCore.MVC.Controllers;

public class AuthController : Controller
{
    [Route("/signup")]
    [HttpGet]
    public IActionResult SignUp()
        
    {
        var viewModel = new SignUpViewModel();
        return View(viewModel);
    }


    [Route("/signup")]
    [HttpPost]
    public IActionResult SignUp(SignUpViewModel viewModel)

    {
      
            return View(viewModel);

        
    }
}
