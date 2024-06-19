using System.ComponentModel.DataAnnotations;

namespace web.Models
{
    public class Book
    {
        public int BookId { get; set; }

        [StringLength(30, ErrorMessage = "Title must be 5 to 30 characters", MinimumLength = 5)]
        public string BookTitle { get; set; }

        [Range(5, 500, ErrorMessage = "Price must be 5$ to 500$")]
        public double BookPrice { get; set; }

        [Url]
        public string BookCover { get; set; }

        public int GenreId { get; set; }
        public Genre Genre { get; set; }
    }
}
