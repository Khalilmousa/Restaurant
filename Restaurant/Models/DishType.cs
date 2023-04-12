namespace Restaurant.Models
{
    public class DishType
    {
        public Guid Id { get; set; }
        public string Name {get;set; } 

        public DishType? ParentDishType { get; set; }


    }
}
