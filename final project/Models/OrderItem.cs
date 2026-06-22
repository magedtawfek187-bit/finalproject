namespace final_project.Models
{
    public class Orderitem
    {
        public int orderitemid { get; set; }
        public int orderid { get; set; }
        public int productid { get; set; }
        public int quantity { get; set; }
        public decimal uniteprice { get; set; }
    }
}
