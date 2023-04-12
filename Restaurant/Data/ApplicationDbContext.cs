using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Restaurant.Models;

namespace Restaurant.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public static string DbPath
        {
            get
            {
                var folder = Environment.SpecialFolder.LocalApplicationData;
                var path = Environment.GetFolderPath(folder);

                var directory = Directory.CreateDirectory(Path.Join(path, "LiteDb"));
                var db = Path.Join(directory.FullName, "LiteDb.db");

                return db;
            }
        }


        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"DataSource={DbPath}");

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Dish> Dishes { get; set; }
        public DbSet<DishType> DishTypes { get; set; }
        public DbSet<Ingridient> Ingridients { get; set; }

        public DbSet<Deparment> Deparments { get; set; }
        public DbSet<Table> Tables { get; set; }

    }
}