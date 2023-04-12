namespace Restaurant.Models
{
    public class Table
    {
        public Guid Id { get; set; }
        public int SeatsCount { get; set; }

        public bool IsReserver { get; set; } //isReserved

        public Guid Department_id { get; set; }

    }
}
