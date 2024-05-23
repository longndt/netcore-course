using System.Security.Claims;

namespace web.Models
{
    public class Attendance
    {
        public int AttendanceId { get; set; }
        public DateTime AttendanceDate { get; set; }
        public string Status { get; set; }
        public int StudentId { get; set; }
        public int ClassId { get; set; }

        public Student Student { get; set; }
        public Class Class { get; set; }
    }
}