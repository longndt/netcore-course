using Microsoft.AspNetCore.Identity;

namespace lab2.Models
{
    public class User : IdentityUser 
    {
        public ICollection<Tasks> Tasks { get; set; }
    }
}
