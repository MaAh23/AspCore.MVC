﻿using AspCore.MVC.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AspCore.MVC.Controllers;

public class AuthController : Controller
{
    //[Route("/signup")]
    //[HttpGet]
    //public IActionResult SignUp()

    //{
    //    var viewModel = new SignUpViewModel();
    //    return View(viewModel);
    //}

    //[Route("/signup")]
    //[HttpPost]
    //public IActionResult SignUp(SignUpViewModel viewModel)

    //{  
    //        return View(viewModel);
    //}

    [Route("/signup")]
    [HttpGet]
    public IActionResult SignUp() => View(new SignUpViewModel());

    

    [Route("/signup")]
    [HttpPost]
    public IActionResult SignUp(SignUpViewModel viewModel)

    {
        if (!ModelState.IsValid)
        {
            return View(viewModel);
        }

        return RedirectToAction("Index", "Home");
    }






    [Route("/signin")]
    [HttpGet]
    public IActionResult SignIn()

    {
        var viewModel = new SignInViewModel();
        return View(viewModel);
    }

    [Route("/signin")]
    [HttpPost]
    public IActionResult SignIn(SignInViewModel viewModel)

    {
        return View(viewModel);
    }
}
