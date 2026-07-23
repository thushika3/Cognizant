using JwtDemo.Models;
using JwtDemo.Services;
using Microsoft.AspNetCore.Mvc;

namespace JwtDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly TokenService _tokenService;

        public AuthController(TokenService tokenService)
        {
            _tokenService = tokenService;
        }

        [HttpPost("login")]
        public IActionResult Login(LoginModel model)
        {
            // Dummy credentials
            if (model.Username == "admin" &&
                model.Password == "password")
            {
                var token = _tokenService.GenerateToken(model.Username);

                return Ok(new
                {
                    Message = "Login Successful",
                    Token = token
                });
            }

            return Unauthorized(new
            {
                Message = "Invalid Username or Password"
            });
        }
    }
}
