using System.ComponentModel.DataAnnotations;

namespace final_project.Areas.Admin.ViewModels
{
    public class UserViewModel
    {
        public string Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsLocked { get; set; }
        public IList<string> Roles { get; set; } = new List<string>();
    }

    public class CreateUserViewModel
    {
        [Required(ErrorMessage = "Required named")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Required email")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Required phone number")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Required password")]
        [MinLength(6)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public string Address { get; set; }

        
        public List<string> AvailableRoles { get; set; } = new();
        public List<string> SelectedRoles { get; set; } = new();
    }

    public class EditUserViewModel
    {
        public string Id { get; set; }

        [Required(ErrorMessage = "Required named")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Required email")]
        [EmailAddress]
        public string Email { get; set; }

        public string PhoneNumber { get; set; }
        public string Address { get; set; }

        public List<string> AvailableRoles { get; set; } = new();
        public List<string> SelectedRoles { get; set; } = new();
    }
}