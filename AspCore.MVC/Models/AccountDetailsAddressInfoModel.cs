using System.ComponentModel.DataAnnotations;

namespace AspCore.MVC.Models;

public class AccountDetailsAddressInfoModel
{
    [Display(Name = "First name", Prompt = "Enter your first name", Order = 0)]
    [Required(ErrorMessage = "Invalid first name")]
    public string Addressline_1{ get; set; } = null!;


    [Display(Name = "Last name", Prompt = "Enter your last name", Order = 1)]
    public string? Addressline_2{ get; set; } 


    [Display(Name = "Postalcode", Prompt = "Enter your postalcode", Order = 2)]
    [Required(ErrorMessage = "Invalid postalcode")]
    [DataType(DataType.PostalCode)]
    public string PostalCode { get; set; } = null!;


    [Display(Name = "City", Prompt = "Enter your city", Order = 3)]
    [Required(ErrorMessage = "Invalid city")]
    public string City { get; set; } = null!;
}
