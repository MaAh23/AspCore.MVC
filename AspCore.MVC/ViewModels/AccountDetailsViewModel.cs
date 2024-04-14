using AspCore.MVC.Models;

namespace AspCore.MVC.ViewModels;

public class AccountDetailsViewModel
{
    public string Title { get; set; } = "Account Details";
    public AccountDetailsBasicInfoModel BasicInfo { get; set; } = new AccountDetailsBasicInfoModel()
    {
        ProfileImage = "images/accountpic.svg",
        Firstname = "Mahdi",
        Lastname = "Ahmadi",
        Email = "mahdi.ahmadi7@outlook.com"
    };
    
    public AccountDetailsAddressInfoModel AddressInfo { get; set; } = new AccountDetailsAddressInfoModel();
  
}
