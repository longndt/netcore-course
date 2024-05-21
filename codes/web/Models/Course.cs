namespace web.Models
{
    public class Course
    {
        public int CourseId { get; set; }   
        public string CourseName { get; set; }

        public virtual ICollection<Registration> Registrations { get; set; }
    }
}
