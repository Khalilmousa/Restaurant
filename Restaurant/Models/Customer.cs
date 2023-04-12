using Microsoft.AspNetCore.Identity;

namespace Restaurant.Models
{
    public class Customer : IdentityUser<Guid> // IdentityUser<Guid>
    {
        public Guid Id { get; set; }
        public DateTime date {get;set; } //constraint more than worktime

        public string Name { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }

        public List<Order>? Orders { get; set; }


    }
}
