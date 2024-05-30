using System.ComponentModel.DataAnnotations;

namespace CustomeAuthentication.Models
{
    public class RegistrationViewModel
    {
        [Required(ErrorMessage = "First Name Required")]
       
        public string FirstName { get; set; }


        [Required(ErrorMessage = "Last Name Required")]
      
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email Name Required")]
      
      
        public string Email { get; set; }

        [Required(ErrorMessage = "UserName Name Required")]
     
        public string UserName { get; set; }


        [Required(ErrorMessage = "password Name Required")]
        [DataType(DataType.Password)]
        public string  Password { get; set; }
        [Compare("Password", ErrorMessage ="Please enter valid password")]

        [DataType(DataType.Password)]
        public string ConformPassword { get; set; }
    }
}
