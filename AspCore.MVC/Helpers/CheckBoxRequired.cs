using System.ComponentModel.DataAnnotations;

namespace AspCore.MVC.Helpers;

public class CheckBoxRequired : ValidationAttribute
{
    public override bool IsValid(object? value) => value is bool b && b;
}