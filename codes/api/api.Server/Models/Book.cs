namespace api.Server.Models
{
    public class Book
    {
        public int BookId { get; set; } //primary key
        public string BookTitle { get; set; }
        public double BookPrice { get; set; }   
        public int BookQuantity { get; set; }
        public string BookCover { get; set; }
    }
}
