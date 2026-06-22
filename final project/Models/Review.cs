namespace final_project.Models
{
    public class Review
    {
        public int reviewId { get; set; }
        public int customerId { get; set; }
        public int restaurantId { get; set; }
        public decimal rating { get; set; }
        public string comment { get; set; }
        public DateTime reviewdate { get; set; }= DateTime.Now;

    }
}
