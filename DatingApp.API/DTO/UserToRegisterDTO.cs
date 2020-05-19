using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.DTO
{
    public class UserToRegisterDTO
    {
        [Required]
        public string UserName { get; set; }
        [StringLength(8,MinimumLength = 4,ErrorMessage ="You must use a password between 4 and 8 characters")]        
        public string Password { get; set; }
    }
}