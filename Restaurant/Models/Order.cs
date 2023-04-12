namespace Restaurant.Models
{
    public class Order
    {
        public Guid Id { get; set; }
        public DateTime Date {get;set; } //constraint more than worktime

        public List<Dish> Dishes { get; set; } 
        public Guid Customer_Id { get; set; }
        public Guid Employee_Id { get; set; }
        

    }
}
