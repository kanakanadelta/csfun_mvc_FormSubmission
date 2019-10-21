using System.ComponentModel.DataAnnotations;
namespace FormSubmission.Models
{
    public class UserLogin
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email Address")]
        [MinLength(4)]
        public string Email { get; set; }
        
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        [MinLength(8)]
        public string Password { get; set; }
    }
}