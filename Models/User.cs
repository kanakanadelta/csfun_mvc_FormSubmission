using System.ComponentModel.DataAnnotations;
namespace FormSubmission.Models
{
    public class User
    {
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "First Name")]
        [MinLength(4)]
        public string FirstName { get; set; }

        [Required]
        [MinLength(4)]
        [Display(Name = "First Name")]
        public string LastName { get; set; }

        [Required]
        [Range(0,int.MaxValue, ErrorMessage = "Please Enter Valid Age")]
        [Display(Name = "Age")]
        public int Age { get; set; }

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