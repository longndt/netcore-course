namespace web.Models
{
    public class Registration
    {
        public int RegistrationId { get; set; }

        public int StudentId { get; set; }  
        public Student? Student { get; set; }

        public int CourseId { get; set; }
        public Course? Course { get; set; }
    }
}
