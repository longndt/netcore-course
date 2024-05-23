using NuGet.DependencyResolver;
using System.ComponentModel.DataAnnotations.Schema;

namespace web.Models
{
    public class Class
    {
        public int ClassId { get; set; }
        public string ClassName { get; set; }
        public string ClassDescription { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        [ForeignKey("TeacherId")]
        public int TeacherId { get; set; }

        public Teacher Teacher { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
        public virtual ICollection<Attendance> Attendances { get; set; }
    }
}
