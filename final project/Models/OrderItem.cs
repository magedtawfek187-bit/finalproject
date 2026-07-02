namespace final_project.Models
{
    public class OrderItem
    {
        public int Orderitemid { get; set; }
        public int Orderid { get; set; }
        public int Productid { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public Order Order { get; set; }       
        public Product Product { get; set; }
    }
}
