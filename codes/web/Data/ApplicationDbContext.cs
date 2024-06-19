using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using web.Models;

namespace web.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Book> Book { get; set; }
        public DbSet<Genre> Genre { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //Seed data for User & Role
            SeedUserRole(builder);

            //Seed data for table Genre
            SeedGenre(builder);

            //Seed data for table Book
            SeedBook(builder);
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

            var readerAccount = new IdentityUser
            {
                Id = "user2",
                UserName = "reader@gmail.com",
                Email = "reader@gmail.com",
                NormalizedUserName = "READER@GMAIL.COM",
                NormalizedEmail = "READER@GMAIL.COM",
                EmailConfirmed = true
            };

            //2. Declare hasher for password encryption
            var hasher = new PasswordHasher<IdentityUser>();

            //3. Setup password for accounts
            adminAccount.PasswordHash = hasher.HashPassword(adminAccount, "123456");
            readerAccount.PasswordHash = hasher.HashPassword(readerAccount, "123456");

            //4. Add accounts to database
            builder.Entity<IdentityUser>().HasData(adminAccount, readerAccount);

            //B) Setup IdentityRole
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = "role1",
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                },
                 new IdentityRole
                 {
                     Id = "role2",
                     Name = "Reader",
                     NormalizedName = "READER"
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

        private void SeedGenre(ModelBuilder builder)
        {
            builder.Entity<Genre>().HasData(
                new Genre
                {
                    GenreId = 1,
                    GenreName = "Programming"

                },
                new Genre
                {
                    GenreId = 2,
                    GenreName = "Self-help"
                },
                new Genre
                {
                    GenreId = 3,
                    GenreName = "Novel"
                }
             );
        }

        private void SeedBook(ModelBuilder builder)
        {
            builder.Entity<Book>().HasData(
                new Book
                {
                    BookId = 1,
                    BookTitle = "Clean Code",
                    BookPrice = 12.34,
                    BookCover = "https://images-na.ssl-images-amazon.com/images/I/51E2055ZGUL.jpg",
                    GenreId = 1
                },
                new Book
                {
                    BookId = 2,
                    BookTitle = "How to win friends & influence people",
                    BookPrice = 9.99,
                    BookCover = "https://rukminim2.flixcart.com/image/850/1000/kkr72q80/book/k/4/l/how-to-win-friends-influence-people-international-bestseller-original-imagyf2wgzsbgvba.jpeg?q=90&crop=false",
                    GenreId = 2
                },
                new Book
                {
                    BookId = 3,
                    BookTitle = "Harry Porter",
                    BookPrice = 6.78,
                    BookCover = "https://nhasachphuongnam.com/images/detailed/160/81YOuOGFCJL.jpg",
                    GenreId = 3
                }
             );
        }
    }
}
