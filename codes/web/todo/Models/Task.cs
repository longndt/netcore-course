namespace todo.Models
{
    public class Task
    {
        public int TaskId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsCompleted { get; set; }
        public int Priority { get; set; }
        public DateTime CreatedDate { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public int? CategoryId { get; set; }
        public Category Category { get; set; }

        public ICollection<TaskComment> TaskComments { get; set; }
    }
}
