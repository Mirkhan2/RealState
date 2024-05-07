using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace RealEstate.Model
{
    public class UserModel : IdentityUser
    {
        [Required(ErrorMessage = "لطفا نام کامل خود را وارد کنید")]
        [MaxLength(100, ErrorMessage = "نام کامل شما نمی تواند از 100 کاراکتر بیشتر باشد")]
        public string FullName { get; set; }
    }
}
