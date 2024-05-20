namespace web.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
