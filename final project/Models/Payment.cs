namespace final_project.Models
{ 
    public enum PaymentMethode
    {
        cash,
        creditcard,
        onlinepayment

    }
    public enum PaymentStatus
    {
        pending,
        completed,
        failed,
        refund
    }
    public class Payment
    {
        public int paymentId { get; set; }
        public int orderId { get; set; }
        public int amount { get; set; }
        public PaymentStatus paymentstatus { get; set; } = PaymentStatus.pending;
        public PaymentMethode paymentMethode { get; set; }
        public DateTime paymenttime { get; set; }= DateTime.Now;
    }
}
