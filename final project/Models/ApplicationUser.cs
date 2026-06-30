using Microsoft.AspNetCore.Identity;

namespace final_project.Models
{
    public class ApplicationUser : IdentityUser
    {

        public string FullName { get; set; }
        public string Address { get; set; }
        public ICollection<Order> Orders { get; set; }
        public ICollection<Review> Reviews { get; set; }
        public Driver Driver { get; set; }

    }
}
