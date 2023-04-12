namespace Restaurant.Models
{
    public class OrderViewModel
    {
        public Guid Id { get; set; }
        public DateTime time { get; set; } 
        public DateOnly date { get; set; }

    }
}
