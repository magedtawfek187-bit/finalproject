namespace final_project.Areas.Admin.ViewModels
{
    public class DashboardViewModel
    {
        
        public int TotalUsers { get; set; }
        public int TotalRestaurants { get; set; }
        public int TotalProducts { get; set; }
        public int TotalOrders { get; set; }
        public int TotalDrivers { get; set; }
        public int TotalDeliveries { get; set; }
        public int TotalReviews { get; set; }
        public decimal TotalRevenue { get; set; }

        
        public int PendingOrders { get; set; }
        public int PreparingOrders { get; set; }
        public int OnTheWayOrders { get; set; }
        public int DeliveredOrders { get; set; }
        public int CancelledOrders { get; set; }

        
        public List<string> TopRestaurantNames { get; set; } = new();
        public List<int> TopRestaurantOrders { get; set; } = new();

        
        public List<string> LastWeekDays { get; set; } = new();
        public List<int> LastWeekOrders { get; set; } = new();
    }
}
