using System;
using System.ComponentModel.DataAnnotations;

namespace EducationDepartment.Models.ViewModels
{
    public class RegisterViewModel
    {
		[Required]
		[EmailAddress]
		[Display(Name = "Email")]
		public string Email { get; set; }

		[Required]
		[StringLength(20, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 8)]
		[DataType(DataType.Password)]
		[Display(Name = "Password")]
		public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare(nameof(Password), ErrorMessage = "비밀번호와 일치하지 않습니다")]
        public string ConfirmPassword { get; set; }
    }
}
