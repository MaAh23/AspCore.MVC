using AspCore.MVC.Helpers;
using System.ComponentModel.DataAnnotations;

namespace AspCore.MVC.Models;

public class SignUpModel
{

    [DataType(DataType.Text)]
    [Display(Name = "First name" , Prompt ="Enter your first name", Order = 0)]
    [Required(ErrorMessage = "Invalid first name")]
    [MinLength(2)]

    public string Firstname { get; set; } = null!;

    [DataType(DataType.Text)]
    [Display(Name = "Last name", Prompt = "Enter your last name", Order = 1)]
    [Required(ErrorMessage = "Invalid last name")]
    [MinLength(2)]

    public string Lastname { get; set; } = null!;


    [Display(Name = "Email address ", Prompt = "Enter your email address", Order = 2)]
    [DataType(DataType.EmailAddress)]
    [Required(ErrorMessage = "Invalid email address")]
    

    public string Email { get; set; } = null!;

    
    [Display(Name = "Password", Prompt = "Enter your password", Order = 3)]
    [DataType(DataType.Password)]
    [Required(ErrorMessage = "Invalid password")]
    

    public string Password { get; set; } = null!;


    [Display(Name = "Confirm password", Prompt = "Confirm yuor passsword", Order = 4)]
    [DataType(DataType.Password)]
    [Required(ErrorMessage = "Password must be confirmed")]
    [Compare(nameof(Password), ErrorMessage ="Password does not match ")]

    public string ConfirmPassword { get; set; } = null!;



    [Display(Name = "I agree to the Terms and Conditions", Order = 5)]
    [CheckBoxRequired(ErrorMessage = "You must accept the terms and conditions to proceed.")]

    public bool TersmAndConditions { get; set; } = false;



}


