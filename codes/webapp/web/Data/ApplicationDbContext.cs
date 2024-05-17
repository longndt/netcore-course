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
        public DbSet<web.Models.Course> Course { get; set; }
        public DbSet<web.Models.Department> Department { get; set; }
        public DbSet<web.Models.Student> Student { get; set; }
        public DbSet<web.Models.Registration> Registration { get; set; }
    }
}
