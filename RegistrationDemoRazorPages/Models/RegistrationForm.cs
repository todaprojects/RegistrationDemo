using System.ComponentModel.DataAnnotations;

namespace RegistrationDemoRazorPages.Models
{
    public class RegistrationForm
    {
        [Required(ErrorMessage = "Please enter your name.")]
        [StringLength(20, ErrorMessage = "Name too long (20 character limit).")]
        [RegularExpression(@"^[(\p{L}+\s*)$]+", ErrorMessage = "The Name field should contain letters!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter your age.")]
        [Range(1, 140, ErrorMessage = "Please enter number between 1-140.")]
        public int? Age { get; set; }

        [Required(ErrorMessage = "Please enter your email.")]
        [RegularExpression(@"^[^@\s]+@[^@\s]+\.[^@\s]+$",
            ErrorMessage = "The Email field is not a valid e-mail address.")]
        public string Email { get; set; }
    }
}