using System.ComponentModel.DataAnnotations;

namespace Jwt.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Email doldurulmalıdır!")]
        [EmailAddress(ErrorMessage = "Geçerli bir email adresi giriniz!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Şifre doldurulmalıdır!")]
        public string Password { get; set; }
    }
}