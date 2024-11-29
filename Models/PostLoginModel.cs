namespace demo_auth_api.Models;

public class PostLoginModel
{
    public Customer? Customer {get;set;}
    public required string Token {get;set;}
}