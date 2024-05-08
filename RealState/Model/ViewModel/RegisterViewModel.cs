using System.ComponentModel.DataAnnotations;

namespace RealEstate.Model.ViewModel
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100 , ErrorMessage = "The ",MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name ="Confirm password")]
        [Compare("Password" ,ErrorMessage ="")]
        public string ConfirmPassword { get; set;}

        public string FullName { get; set; }

        public string ReturnUrl { get; set; }
		public string PhoneNumber { get; internal set; }
	}
}
