using System;

namespace web.Models
{
    public class ActivityLog
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Path { get; set; }
        public DateTime AccessedAt { get; set; }
        public double DurationMs { get; set; }
    }
}
