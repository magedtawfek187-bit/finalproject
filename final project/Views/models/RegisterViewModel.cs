using System.ComponentModel.DataAnnotations;

namespace final_project.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Required name")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Required email")]
        [EmailAddress(ErrorMessage = "wrong email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Required phone number")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Required address")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Required password")]
        [MinLength(6, ErrorMessage = "at least 6 letters")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "reconfirm password")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "wrong password")]
        public string ConfirmPassword { get; set; }
    }
}