using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;
using todo.Models;

namespace todo.Data
{
    public class ToDoAppContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Models.Task> Tasks { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<TaskComment> TaskComments { get; set; }

        public ToDoAppContext(DbContextOptions<ToDoAppContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>()
          .HasMany(u => u.Tasks)
          .WithOne(t => t.User)
          .HasForeignKey(t => t.UserId)
          .OnDelete(DeleteBehavior.Restrict); // Adjust delete behavior

            modelBuilder.Entity<User>()
                .HasMany(u => u.Categories)
                .WithOne(c => c.User)
                .HasForeignKey(c => c.UserId)
                .OnDelete(DeleteBehavior.Restrict); // Adjust delete behavior

            modelBuilder.Entity<Category>()
                .HasMany(c => c.Tasks)
                .WithOne(t => t.Category)
                .HasForeignKey(t => t.CategoryId)
                .OnDelete(DeleteBehavior.Restrict); // Adjust delete behavior

            modelBuilder.Entity<Models.Task>()
                .HasMany(t => t.TaskComments)
                .WithOne(tc => tc.Task)
                .HasForeignKey(tc => tc.TaskId)
                .OnDelete(DeleteBehavior.Cascade); // Adjust delete behavior

            modelBuilder.Entity<TaskComment>()
                .HasOne(tc => tc.User)
                .WithMany(u => u.TaskComments)
                .HasForeignKey(tc => tc.UserId)
                .OnDelete(DeleteBehavior.Restrict); // Adjust delete behavior
        }
    }

}
