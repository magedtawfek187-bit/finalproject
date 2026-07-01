namespace final_project.Models
{   public enum DeliveryStatus
    {
        Assigned,
        PickedUp,
        Delivered
    }
    
        public class Delivery
        {
            public int DeliveryID { get; set; }      
            public int OrderID { get; set; }         
            public int DriverID { get; set; }        
            public DateTime? PickupTime { get; set; }   
            public DateTime? DeliveryTime { get; set; } 
            public DeliveryStatus Status { get; set; } = DeliveryStatus.Assigned; 

            public Order Order { get; set; }
            public Driver Driver { get; set; }
        }

    }

