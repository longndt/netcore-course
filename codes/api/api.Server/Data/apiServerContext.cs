using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using api.Server.Models;
using Microsoft.AspNetCore.Identity;
using System.Drawing;

namespace api.Server.Data
{
    public class apiServerContext : DbContext
    {
        public apiServerContext(DbContextOptions<apiServerContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Book { get; set; } 

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            SeedBook(builder);
        }

        private void SeedBook(ModelBuilder builder)
        {
            builder.Entity<Book>().HasData(
                new Book
                {
                    BookId = 1,
                    BookTitle = "The Full Stack Developer",
                    BookPrice = 25,
                    BookQuantity = 10,
                    BookCover = "https://m.media-amazon.com/images/I/61svWgrmT0L._AC_UF1000,1000_QL80_.jpg"
                },
                new Book
                {
                    BookId = 2,
                    BookTitle = "ASP.NET Core Application Development",
                    BookPrice = 35,
                    BookQuantity = 20,
                    BookCover = "https://m.media-amazon.com/images/I/81iua0Wh34L._AC_UF1000,1000_QL80_.jpg"
                },
                new Book
                {
                    BookId = 3,
                    BookTitle = "Getting to know Vue.js",
                    BookPrice = 45,
                    BookQuantity = 30,
                    BookCover = "https://media.springernature.com/full/springer-static/cover-hires/book/978-1-4842-3781-6"
                }
            );
        }
    }
}
