using demo_auth_api.DTOs;
using demo_auth_api.Models;
using Microsoft.AspNetCore.Mvc;

namespace demo_auth_api.Controllers;

[ApiController]
[Route("api/customer/")]
public class AuthController : ControllerBase
{
    private readonly List<CustomerInfo> _customers = new();

    [HttpGet("login")]
    public IActionResult GetLogin()
    {
        var user = new GetLoginDto(email: "Md Ali Reza", "123456");
        return Ok(new ApiResponse<GetLoginDto>(user, message: "", errorList: []));
    }

    [HttpPost("login")]
    public IActionResult PostLogin([FromBody] PostLoginDto postLoginDto)
    {
        var info = new CustomerInfo()
        {
            Customer = new Customer()
            {
                Email = postLoginDto.Email, Password = postLoginDto.Password
            },
            Token = Guid.NewGuid().ToString(),
        };
        return Ok(new ApiResponse<CustomerInfo>(info, message: "", errorList: []));
    }

    [HttpPost("register")]
    public IActionResult RegisterCustomer([FromBody] RegisterDto registerDto)
    {
        var customer = new CustomerInfo()
        {
            Customer = new Customer()
            {
                Username = registerDto.Username, Email = registerDto.Email, Password = registerDto.Password,
            },
            Token = new Guid().ToString(),
        };

        _customers.Add(customer);

        return Ok(new ApiResponse<CustomerInfo>(customer, message: "", errorList: []));
    }

    [HttpGet("info")]
    public IActionResult GetCustomerInfo()
    {
        return Ok(new { });
    }
}