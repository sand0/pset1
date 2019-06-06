using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Frendzone.Models.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        public string Nikname { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Birthday Date")]
        [DataType(DataType.Date)]
        public DateTime BirthdayDate { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "Different Passwords!")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        public string PasswordConfirm { get; set; }
    }
}
