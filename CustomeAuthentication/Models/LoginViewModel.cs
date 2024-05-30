using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CustomeAuthentication.Models
{
    public class LoginViewModel
    {

        [Required(ErrorMessage = "UserName or Email Name Required")]
        [MaxLength(100, ErrorMessage = "More then 30 character")]
        [DisplayName("Username or Email")]
        public string UserNameorEmail { get; set; }



        [Required(ErrorMessage = "password Name Required")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "More then 20 character")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
