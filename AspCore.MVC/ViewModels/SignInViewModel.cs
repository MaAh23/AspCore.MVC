using AspCore.MVC.Models;

namespace AspCore.MVC.ViewModels;

public class SignInViewModel
{
    public string Title { get; set; } = "Sign In";

    public SignInModel Form { get; set; } = new SignInModel();
   
}

