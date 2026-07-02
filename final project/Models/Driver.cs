namespace final_project.Models
{
    public class Driver
    {
        public int driverid { get; set; }
        public string userid { get; set; }
        public string vehicletype { get; set; }
        public ApplicationUser User { get; set; }
        public string licensenumber { get; set; }

    }
}
