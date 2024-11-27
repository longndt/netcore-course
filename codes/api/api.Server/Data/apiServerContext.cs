using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using api.Server.Models;

namespace api.Server.Data
{
    public class apiServerContext : DbContext
    {
        public apiServerContext(DbContextOptions<apiServerContext> options)
            : base(options)
        {
        }

        public DbSet<api.Server.Models.Book> Book { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            //seed book data to database
            SeedBook(builder);
        }

        private void SeedBook(ModelBuilder builder)
        {
            builder.Entity<Book>().HasData(
                 new Book
                 {
                     BookId = 1,
                     BookTitle = "Clean Code: A Handbook of Agile Software Craftsmanship",
                     BookPrice = 30,
                     BookQuantity = 15,
                     BookCover = "https://m.media-amazon.com/images/I/41jEbK-jG+L._SX258_BO1,204,203,200_.jpg"
                 },
                 new Book
                 {
                     BookId = 2,
                     BookTitle = "The Pragmatic Programmer: Your Journey To Mastery",
                     BookPrice = 35,
                     BookQuantity = 20,
                     BookCover = "https://m.media-amazon.com/images/I/41as+WafrFL._SX218_BO1,204,203,200_QL40_FMwebp_.jpg"
                 },
                 new Book
                 {
                     BookId = 3,
                     BookTitle = "You Don’t Know JS Yet: Scope & Closures",
                     BookPrice = 20,
                     BookQuantity = 10,
                     BookCover = "https://m.media-amazon.com/images/I/81kqrwS1nNL.jpg"
                 }
            );
        }
    }
}
