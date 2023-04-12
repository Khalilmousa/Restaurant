namespace Restaurant.Models
{
    public class Deparment
    {
        public Guid Id { get; set; }
        public DateTime WorkingTime {get;set; } //constraint more than worktime
        public string Name { get; set; }
        public string Adress { get; set; }
        public string Phone { get; set; }
        
        public List<Employee> Employees { get; set; }

    }
}
