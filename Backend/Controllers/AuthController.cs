using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private static List<Student> _users = new();

        [HttpPost("register")]
        public IActionResult Register([FromBody] Student newUser)
        {
            if (_users.Any(u => u.UStudentEmail == newUser.UStudentEmail))
                return Conflict(new { message = "Email already registered" });

            newUser.Id = _users.Count + 1;
            _users.Add(newUser);
            return Created("", new { message = "User registered successfully", userId = newUser.Id });
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginRequest login)
        {
            var user = _users.FirstOrDefault(u => u.UStudentEmail == login.Email);
            if (user == null)
                return NotFound(new { message = "User not found" });

            if (!user.ValidatePassword(login.Password))
                return Unauthorized(new { message = "Invalid credentials" });

            return Ok(new { message = "Login successful", user });
        }
    }

    public class LoginRequest
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
