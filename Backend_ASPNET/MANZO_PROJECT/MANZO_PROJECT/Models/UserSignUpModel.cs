using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASP_YETI_PROJECT.core.Models
{
    public class UserSignUpModel
    {
        [Required]
        [StringLength(255, MinimumLength = 3)]
        public string? Username { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 6)] // Adjust the minimum password length as needed
        public string Password { get; set; }

        [Required]
        public bool IsSeller { get; set; }

        [Required]
        public string? Country { get; set; }

        public string? Phone { get; set; }

        public string? Desc { get; set; }

        [NotMapped]
        [DataType(DataType.Upload)]
        public IFormFile? ProfilePicture { get; set; }
    }
}
