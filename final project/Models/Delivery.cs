namespace final_project.Models
{   public enum DeliveryStatus
    {
        Assigned,
        PickedUp,
        Delivered
    }
    public class Delivery 
    {
        public int deliveryId {  get; set; }
        public int orderId { get; set; }
        public int driverId { get; set; }
        public DateTime pickuptime { get; set; }
        public DateTime deliverytime { get; set; }
        public DeliveryStatus DeliveryStatus { get; set; } = DeliveryStatus.Assigned;

    }
}
