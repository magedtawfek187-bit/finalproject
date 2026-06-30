using System.ComponentModel.DataAnnotations;

namespace final_project.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Required email")]
        [EmailAddress(ErrorMessage = "wrong email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Required password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}