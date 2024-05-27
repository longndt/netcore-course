using System.ComponentModel.DataAnnotations;

namespace lab2.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public ICollection<Tasks> Tasks { get; set; }    
    }
}