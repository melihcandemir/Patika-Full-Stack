using Jwt.Context;
using Jwt.Entities;
using Jwt.Jwt;
using Jwt.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Jwt.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly JwtAppDbContext _context;
        private readonly JwtHelper _jwtHelper;

        public AuthController(JwtAppDbContext context, JwtHelper JwtHelper)
        {
            _context = context;
            _jwtHelper = JwtHelper;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginModel model)
        {
            var user = await _context.Users
                .FirstOrDefaultAsync(u => u.Email == model.Email && u.Password == model.Password);

            if (user == null)
                return Unauthorized("Geçeriz kullanıcı bilgisi!");

            var token = _jwtHelper.GenerateToken(user);

            return Ok(new { token });
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] LoginModel model)
        {
            if (await _context.Users.AnyAsync(u => u.Email == model.Email))
                return BadRequest("Bu e-posta adresi zaten kayıtlı!");

            var user = new User
            {
                Email = model.Email,
                Password = model.Password
            };

            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return Ok("Kayıt başarılı!");
        }
    }
}