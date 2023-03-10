using System.ComponentModel.DataAnnotations;

namespace Travel.Ui.WebApi.DTO
{
    public class UserLoginRequestDTO
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
