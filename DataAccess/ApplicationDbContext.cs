using DataAccess.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class ApplicationDbContext : IdentityDbContext<Person>
    {
        public DbSet<Phone> Phones { get; set; }
        public DbSet<Category> Categories { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            Phone[] phones = new Phone[3];
            phones[0] = new Phone();
            phones[0].Id = 1;
            phones[0].Name = "IPhone 7";
            phones[0].CategoryId = 1;
            phones[0].Price = 500;
            phones[1] = new Phone();
            phones[1].Id = 2;
            phones[1].Name = "IPhone 8";
            phones[1].CategoryId = 1;
            phones[1].Price = 600;
            phones[2] = new Phone();
            phones[2].Id = 3;
            phones[2].Name = "IPhone 9";
            phones[2].CategoryId = 1;
            phones[2].Price = 700;

            Category[] categories = new Category[2];
            categories[0] = new Category();
            categories[0].Id = 1;
            categories[0].Name = "Smartphone";
            categories[1] = new Category();
            categories[1].Id = 2;
            categories[1].Name = "Buttonphone";

            builder.Entity<Phone>().HasData(phones);
            builder.Entity<Category>().HasData(categories);
        }
    }
}