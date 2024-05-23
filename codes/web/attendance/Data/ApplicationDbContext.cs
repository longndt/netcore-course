using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using web.Models;

namespace web.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<web.Models.Class> Class { get; set; } = default!;
        public DbSet<web.Models.Subject> Subject { get; set; } = default!;
        public DbSet<web.Models.Teacher> Teacher { get; set; } = default!;
        public DbSet<web.Models.Student> Student { get; set; } = default!;
        public DbSet<web.Models.Enrollment> Enrollment { get; set; } = default!;
        public DbSet<web.Models.Attendance> Attendance { get; set; } = default!;
    
    }
}
