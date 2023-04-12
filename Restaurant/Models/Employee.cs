namespace Restaurant.Models
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Patronomic { get; set; }
        public DateOnly Birth { get; set; } //const
        public decimal Salary { get; set; } //const >0

    }
}
