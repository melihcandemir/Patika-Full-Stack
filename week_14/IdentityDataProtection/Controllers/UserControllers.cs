using IndentityDataProtection.Context;
using IndentityDataProtection.Entities;
using IndentityDataProtection.Models;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;

namespace IndentityDataProtection.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserControllers : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IDataProtector _dataProtector;

        public UserControllers(IDataProtectionProvider dataProtectionProvider, AppDbContext context)
        {
            _dataProtector = dataProtectionProvider.CreateProtector("UserDataProtection");
            _context = context;
        }

        [HttpPost("register")]
        public IActionResult Register([FromBody] UserRegister data)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var user = _context.Users.FirstOrDefault(x => x.Email == data.Email);
            if (user != null)
            {
                return BadRequest("Bu e-posta adresi zaten kayıtlı.");
            }


            var newUser = new User
            {
                Email = data.Email,
                Password = _dataProtector.Protect(data.Password) // Şifreli bir şekilde kaydediyoruz
            };


            _context.Users.Add(newUser);
            _context.SaveChanges();

            return Ok("Kullanıcı başarıyla kaydedildi.");
        }

        [HttpGet("login")]
        public IActionResult Login([FromQuery] UserLogin data)
        {
            var user = _context.Users.FirstOrDefault(x => x.Email == data.Email);
            if (user == null)
            {
                return BadRequest("Kullanıcı bulunamadı.");
            }

            var decryptedPassword = _dataProtector.Unprotect(user.Password); // Şifreyi çöz
            if (decryptedPassword != data.Password)
            {
                return BadRequest("Şifre yanlış.");
            }

            return Ok("Giriş başarılı.");
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var users = _context.Users.ToList();
            return Ok(users);
        }


        [HttpGet("getbyid/{id}")]
        public IActionResult GetById(int id)
        {
            var user = _context.Users.FirstOrDefault(x => x.Id == id);
            if (user == null)
            {
                return NotFound("Kullanıcı bulunamadı.");
            }

            return Ok(user);
        }
    }
}