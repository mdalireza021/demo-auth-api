using System.ComponentModel.DataAnnotations;

namespace demo_auth_api.Models;

public class LoginModel
{
    [Required(ErrorMessage = "email is required")]
    public required string Email { get; set; }
    
    [Required(ErrorMessage = "password is required")]
    public required string Password { get; set; }
}