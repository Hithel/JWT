
using System.ComponentModel.DataAnnotations;

namespace APIProyecto.Dtos;
    public class RegisterDto
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
    }
