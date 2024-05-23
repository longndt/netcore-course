namespace todo.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string Email { get; set; }
        public DateTime CreatedDate { get; set; }

        public ICollection<Task> Tasks { get; set; }
        public ICollection<TaskComment> TaskComments { get; set; }
        public ICollection<Category> Categories { get; set; }
    }

}
