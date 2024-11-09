using System.ComponentModel.DataAnnotations;

namespace ASP_YETI_PROJECT.core.Models
{
    public class UserSignInModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 6)] // Adjust the minimum password length as needed
        public string Password { get; set; }

        public bool RememberMe { get; set; }


    }
}
