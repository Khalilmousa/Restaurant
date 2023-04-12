namespace Restaurant.Models
{
    public class Ingridient
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid Dish_id { get; set; }

    }
}
