namespace Restaurant.Models
{
    public class Dish
    {
        public Guid Id { get; set; }
        public List<Ingridient> Ingridients { get; set; }
        public string? Image { get; set; }


    }
}
