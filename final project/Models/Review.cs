namespace final_project.Models
{
    public class Review
    {
        public int ReviewID { get; set; }
        public string CustomerID { get; set; } 
        public int RestaurantID { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
        public DateTime ReviewDate { get; set; } = DateTime.Now;

        public ApplicationUser Customer { get; set; }
        public Restaurant Restaurant { get; set; }
    }
}