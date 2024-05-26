using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using lab1.Models;
using Microsoft.AspNetCore.Identity;

namespace lab1.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<lab1.Models.Laptop> Laptop { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //Seed data for User & Role
            SeedUserRole(builder);

            //Seed data for table Laptop
            SeedLaptop(builder);
        }

        private void SeedUserRole(ModelBuilder builder)
        {
            //A) Setup IdentityUser
            //1. Create accounts
            var adminAccount = new IdentityUser
            {
                Id = "user1",
                UserName = "admin@gmail.com",
                Email = "admin@gmail.com",
                NormalizedUserName = "ADMIN@GMAIL.COM",
                NormalizedEmail = "ADMIN@GMAIL.COM",
                EmailConfirmed = true
            };

            var userAccount = new IdentityUser
            {
                Id = "user2",
                UserName = "user@gmail.com",
                Email = "user@gmail.com",
                NormalizedUserName = "USER@GMAIL.COM",
                NormalizedEmail = "USER@GMAIL.COM",
                EmailConfirmed = true
            };

            //2. Declare hasher for password encryption
            var hasher = new PasswordHasher<IdentityUser>();

            //3. Setup password for accounts
            adminAccount.PasswordHash = hasher.HashPassword(adminAccount, "123456");
            userAccount.PasswordHash = hasher.HashPassword(userAccount, "123456");

            //4. Add accounts to database
            builder.Entity<IdentityUser>().HasData(adminAccount, userAccount);

            //B) Setup IdentityRole
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = "role1",
                    Name = "Administrator",
                    NormalizedName = "ADMINISTRATOR"
                },
                 new IdentityRole
                 {
                     Id = "role2",
                     Name = "User",
                     NormalizedName = "USER"
                 });

            //C) Setup IdentityUserRole
            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    UserId = "user1",
                    RoleId = "role1"
                },
                new IdentityUserRole<string>
                {
                    UserId = "user2",
                    RoleId = "role2"
                }
             );
        }

        private void SeedLaptop(ModelBuilder builder)
        {
            builder.Entity<Laptop>().HasData(
                new Laptop
                {
                    Id = 1,
                    Brand = "Apple",
                    Model = "Macbook Pro M2",
                    Quantity = 10,
                    Price = 2345,
                    Image = "https://bizweb.dktcdn.net/100/444/581/products/macbook-m1-vs-intel-1536x1268-6c00654d-ad87-4caf-8b88-aa6c34048199.png?v=1656134590567"
                },
                new Laptop
                {
                    Id = 12,
                    Brand = "Dell",
                    Model = "XPS15",
                    Quantity = 15,
                    Price = 1999,
                    Image = "https://thegioiso365.vn/wp-content/uploads/2023/04/Dell-xps-9530-3.png"
                },
                new Laptop
                {
                    Id = 3,
                    Brand = "LG",
                    Model = "Gram 17",
                    Quantity = 22,
                    Price = 2024,
                    Image = "https://product.hstatic.net/1000333506/product/pc-gram-17z90q-b-gallery-02_dd780c6249ec430b84f82ed466fffd6e.jpg"
                }
             );
        }
    }
}
