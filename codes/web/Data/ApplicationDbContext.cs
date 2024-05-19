using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Drawing;
using web.Models;

namespace web.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<web.Models.Course> Course { get; set; } = default!;
        public DbSet<web.Models.Department> Department { get; set; } = default!;
        public DbSet<web.Models.Student> Student { get; set; } = default!;
        public DbSet<web.Models.Registration> Registration { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            SeedUser(builder);
            SeedRole(builder);
            SeedUserRole(builder);
            SeedDepartment(builder);
            SeedCourse(builder);
            SeedStudent(builder);
            SeedRegistration(builder);
        }

        private void SeedUser(ModelBuilder builder)
        {
            var admin = new IdentityUser
            {
                Id = "1",
                Email = "admin@gmail.com",
                UserName = "admin@gmail.com",
                NormalizedUserName = "admin@gmail.com"
            };
            var user = new IdentityUser
            {
                Id = "2",
                Email = "longndt@gmail.com",
                UserName = "longndt@gmail.com",
                NormalizedUserName = "longndt@gmail.com"
            };

            var hasher = new PasswordHasher<IdentityUser>();

            admin.PasswordHash = hasher.HashPassword(admin, "123456");
            user.PasswordHash = hasher.HashPassword(user, "123456");

            builder.Entity<IdentityUser>().HasData(admin, user);
        }

        private void SeedRole(ModelBuilder builder)
        {
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole { Id = "1", Name = "Admin", NormalizedName = "Admin" },
                new IdentityRole { Id = "2", Name = "User", NormalizedName = "User" }
            );
        }

        private void SeedUserRole(ModelBuilder builder)
        {
            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string> { UserId = "1", RoleId = "1" },
                new IdentityUserRole<string> { UserId = "2", RoleId = "2" }
            );
        }

        private void SeedDepartment(ModelBuilder builder)
        {
            builder.Entity<Department>().HasData(
            new Department { DepartmentId = 1, DepartmentName = "Information Technology" },
            new Department { DepartmentId = 2, DepartmentName = "Business" },
            new Department { DepartmentId = 3, DepartmentName = "Graphic Design" }
         );
        }

        private void SeedCourse(ModelBuilder builder)
        {
            builder.Entity<Course>().HasData(
            new Course { CourseId = 1, CourseName = "Web Design" },
            new Course { CourseId = 2, CourseName = "Programming" },
            new Course { CourseId = 3, CourseName = "Cloud Computing" },
            new Course { CourseId = 4, CourseName = "Application Development" },
            new Course { CourseId = 5, CourseName = "Computer Science" }
            );
        }

        private void SeedStudent(ModelBuilder builder)
        {
            builder.Entity<Student>().HasData(
              new Student
              {
                  StudentId = 1,
                  StudentName = "Phuong Linh",
                  StudentDoB = DateTime.Parse("2000-05-10"),
                  StudentGPA = 7.8,
                  StudentImage = "https://img.freepik.com/free-photo/happy-young-female-student-holding-notebooks-from-courses-smiling-camera-standing-spring-clothes-against-blue-background_1258-70161.jpg"
              },
               new Student
               {
                   StudentId = 2,
                   StudentName = "Anh Duy",
                   StudentDoB = DateTime.Parse("2000-10-05"),
                   StudentGPA = 8.9,
                   StudentImage = "https://i0.wp.com/rollercoasteryears.com/wp-content/uploads/Thrive-During-Finals-.jpg?fit=1000%2C667&ssl=1"
               },
               new Student
               {
                   StudentId = 3,
                   StudentName = "Hoang Viet",
                   StudentDoB = DateTime.Parse("2002-05-15"),
                   StudentGPA = 6.4,
                   StudentImage = "https://concept3d.com/wp-content/uploads/2023/08/Student-with-more-access-to-academic-resources-due-to-efforts-to-boost-student-retention-and-persistence.jpg"
               },
                new Student
                {
                    StudentId = 4,
                    StudentName = "Hai Minh",
                    StudentDoB = DateTime.Parse("2001-06-04"),
                    StudentGPA = 9.2,
                    StudentImage = "https://concept3d.com/wp-content/uploads/2023/11/Bored-and-disengaged-college-student-who-can-benefit-from-university-student-engagement-strategies.jpg"
                },
                new Student
                {
                    StudentId = 5,
                    StudentName = "Quynh Phuong",
                    StudentDoB = DateTime.Parse("2002-07-08"),
                    StudentGPA = 8.3,
                    StudentImage = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ0LWzKUytmI8aZaCLA2dXVonzxOP2kxdupRa8G7GLcXA&s"
                }
              );
        }

        private void SeedRegistration(ModelBuilder builder)
        {
            builder.Entity<Registration>().HasData(
                 new Registration { StudentId = 1, CourseId = 3},
                  new Registration { StudentId = 1, CourseId = 2 },
                   new Registration { StudentId = 2, CourseId = 1 },
                    new Registration { StudentId = 2, CourseId = 5 },
                     new Registration { StudentId = 3, CourseId = 2 },
                   new Registration { StudentId = 4, CourseId = 2 },
                   new Registration { StudentId = 5, CourseId = 2 }
                   );
        }
    }
}
