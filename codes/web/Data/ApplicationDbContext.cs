using Microsoft.EntityFrameworkCore;
using web.Models;

namespace web.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Registration> Registrations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Registration>()
                .HasKey(r => new { r.RegistrationId });

            modelBuilder.Entity<Student>()
                .HasOne(s => s.Department)
                .WithMany(d => d.Students)
                .HasForeignKey(s => s.DepartmentId);

            modelBuilder.Entity<Registration>()
                .HasOne(r => r.Student)
                .WithMany(s => s.Registrations)
                .HasForeignKey(r => r.StudentId);

            modelBuilder.Entity<Registration>()
                .HasOne(r => r.Course)
                .WithMany(c => c.Registrations)
                .HasForeignKey(r => r.CourseId);
        }
    }
}
