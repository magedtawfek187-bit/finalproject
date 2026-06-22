namespace final_project.Models
{
    public enum OrderStatus
    {
        Pending,
        Preparing,
        OnTheWay,
        Delivered,
        Cancelled
    }

    public class Order
    {
        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.Now;
        public decimal TotalAmount { get; set; }
        public OrderStatus Status { get; set; } = OrderStatus.Pending;
        public string CustomerID { get; set; }
        public ApplicationUser Customer { get; set; }
        public ICollection<Orderitem> OrderItems { get; set; }
        public Payment Payment { get; set; }
        public delivery Delivery { get; set; }

    }
}
