using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiparAppServices.ViewModels.Authentication
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; } = null!;

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; } = null!;

        [Required(ErrorMessage = "Confirm password is required")]
        [Compare("Password", ErrorMessage = "The Password and Confirm Password do not match.")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Age is required")]
        [Range(0, 100)]
        public int Age { get; set; }

        [Required(ErrorMessage = "Phone number is required")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; } = null!;

        [Required(ErrorMessage = "First name is required")]
        [StringLength(30)]
        public string FirstName { get; set; } = null!;

        [Required(ErrorMessage = "last name is required")]
        [StringLength(30)]
        public string LastName { get; set; } = null!;

        [Required(ErrorMessage = "Username is required")]
        [StringLength(50)]
        public string Username { get; set; } = null!;
    }
}
