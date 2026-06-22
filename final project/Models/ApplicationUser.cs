using Microsoft.AspNetCore.Identity;

namespace final_project.Models
{
    public class ApplicationUser : IdentityUser
    {
        
        public string fullname { get; set; }
        public string address { get; set; }
        public ICollection<Order> Orders { get; set; }
        public ICollection<Review> Reviews { get; set; }
        public Driver Driver { get; set; }

    }
}
