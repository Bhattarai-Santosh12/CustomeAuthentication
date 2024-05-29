using System.ComponentModel.DataAnnotations;

namespace CustomeAuthentication.Models
{
    public class RegistrationViewModel
    {
        [Required(ErrorMessage = "First Name Required")]
        [MaxLength(100, ErrorMessage = "More then 50 character")]
        public string FirstName { get; set; }


        [Required(ErrorMessage = "Last Name Required")]
        [MaxLength(100, ErrorMessage = "More then 50 character")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email Name Required")]
        [MaxLength(100, ErrorMessage = "More then 100 character")]
        [EmailAddress(ErrorMessage ="Enter valid email")]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Enter valid email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "UserName Name Required")]
        [MaxLength(100, ErrorMessage = "More then 30 character")]
        public string UserName { get; set; }


        [Required(ErrorMessage = "password Name Required")]
        [StringLength(100, MinimumLength =5, ErrorMessage = "More then 20 character")]
        [DataType(DataType.Password)]
        public int  Password { get; set; }
        [Compare("Password", ErrorMessage ="Please enter valid password")]
        [DataType(DataType.Password)]

        public int ConformPassword { get; set; }
    }
}
