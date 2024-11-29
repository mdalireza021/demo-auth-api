namespace demo_auth_api.DTOs;

public class GetLoginDto(string? email, string? password)
{
    public string? Email { get; set; } = email;
    public string? Password { get; set; } = password;
}
