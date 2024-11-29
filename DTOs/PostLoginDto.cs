using System.ComponentModel.DataAnnotations;

namespace demo_auth_api.DTOs;
public class PostLoginDto(string email, string password)
{
    [Required(ErrorMessage = "Email is required")]
    public required string Email { get; set; } = email;

    [Required(ErrorMessage = "Password is required")]
    [StringLength(1000, MinimumLength = 6, ErrorMessage = "Password must be atLeast 6 characters")]
    public required string Password { get; set; } = password;
}