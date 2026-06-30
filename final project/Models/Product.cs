namespace final_project.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageURL { get; set; }
        public bool IsAvailable { get; set; }

        
        public int RestaurantID { get; set; }
        public int CategoryID { get; set; } 
        public Restaurant Restaurant { get; set; }
        public Category Category { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
    }
}
