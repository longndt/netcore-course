namespace web.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public DateTime StudentDoB { get; set; }
        public double StudentGPA { get; set; }
        public string StudentImage { get; set; }

        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }

        public virtual ICollection<Registration> Registrations { get; set; }
    }
}