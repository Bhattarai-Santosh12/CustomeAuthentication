using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace CustomeAuthentication.Entities
{
    [Index(nameof(Email), IsUnique= true)]
    public class UserAccount
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="First Name Required")]
        
        public string FirstName { get; set; }


        [Required(ErrorMessage = "Last Name Required")]
      
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email Name Required")]

        public string Email { get; set; }

        [Required(ErrorMessage = "UserName Name Required")]
       
        public string UserName { get; set; }

        public string Roles { get; set; }


        [Required(ErrorMessage = "password Name Required")]
       
        public string Password { get; set; }
    }
}
