namespace todo.Models
{
    public class TaskComment
    {
        public int TaskCommentId { get; set; }
        public string CommentText { get; set; }
        public DateTime CreatedDate { get; set; }

        public int TaskId { get; set; }
        public Task Task { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }

}
