using System.ComponentModel.DataAnnotations;

namespace IndentityDataProtection.Models
{
    public class UserRegister
    {
        [Required(ErrorMessage = "Kullanıcı adı alanı gereklidir.")]
        [EmailAddress(ErrorMessage = "Geçersiz e-posta adresi.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Ad alanı gereklidir.")]
        public string Password { get; set; }
    }
}