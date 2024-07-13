using System.ComponentModel.DataAnnotations;

namespace BookStore.Data.dtos
{
    public class RegisterDto
    {
        [Required(ErrorMessage = "User name is required.")]
        [StringLength(100, ErrorMessage = "Maximum 100 Characters.")]
        public string UserName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email is required.")]
        [StringLength(100, ErrorMessage = "Maximum 100 Characters.")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Invalid email address.")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Password is required.")]
        [StringLength(maximumLength: 30, ErrorMessage = "Password must be between 6 to 30 char.", MinimumLength = 6)]
        public string Password { get; set; } = string.Empty;
    }
    public class LoginDto 
    {
        [Required(ErrorMessage = "Email is required.")]
        [StringLength(100, ErrorMessage = "Maximum 100 Characters.")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Invalid email address.")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Password is required.")]
        public string Password { get; set; } = string.Empty;
    }

}
