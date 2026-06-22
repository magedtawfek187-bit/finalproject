namespace final_project.Models
{
    public class Restaurant
    {
        public int RestaurantID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public double Rating { get; set; }
        public ICollection<Product> Products { get; set; }
        public ICollection<Review> Reviews { get; set; }
    }
}
