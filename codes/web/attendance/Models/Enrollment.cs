using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Claims;

namespace web.Models
{
    public class Enrollment
    {
        public int EnrollmentId { get; set; }
        public DateTime EnrollmentDate { get; set; }

        [ForeignKey("StudentId")]
        public int StudentId { get; set; }
        [ForeignKey("ClassId")]
        public int ClassId { get; set; }

        public Student StudentEnrollment { get; set; }
        public Class ClassEnrollment { get; set; }
    }
}