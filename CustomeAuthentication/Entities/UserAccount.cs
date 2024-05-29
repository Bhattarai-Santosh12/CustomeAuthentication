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
        [MaxLength(100, ErrorMessage ="More then 50 character")]
        public string FirstName { get; set; }


        [Required(ErrorMessage = "Last Name Required")]
        [MaxLength(100, ErrorMessage = "More then 50 character")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email Name Required")]
        [MaxLength(100, ErrorMessage = "More then 100 character")]
        public string Email { get; set; }

        [Required(ErrorMessage = "UserName Name Required")]
        [MaxLength(100, ErrorMessage = "More then 30 character")]
        public string UserName { get; set; }


        [Required(ErrorMessage = "password Name Required")]
        [MaxLength(100, ErrorMessage = "More then 20 character")]
        public int Password { get; set; }
    }
}
