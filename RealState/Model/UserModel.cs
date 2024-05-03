using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace RealState.Model
{
    public class UserModel : IdentityUser
    {
        [Required(ErrorMessage ="Please  your Full Name insert ")]
        [MaxLength(100,ErrorMessage ="Not mehr 100 character")]

        public string? FullName { get; set; } 
    }
}
