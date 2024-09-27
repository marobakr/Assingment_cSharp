using System.ComponentModel.DataAnnotations;

namespace Mvc03.Demo.PL.ViewModels.Auth;

public class ResetPasswordViewModel
{
    [Required(ErrorMessage = "Password Is Required !!")]
    [DataType(DataType.Password)]
    public string Password { get; set; }
    
    [Required(ErrorMessage = "ConfirmPassword Is Required !!")]
    [DataType(DataType.Password)]
    [Compare(nameof(Password), ErrorMessage = "ConfirmPassword Not Match Password !!")]
    public string ConfirmPassword { get; set; }
}