namespace api.Server.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public required string BookTitle { get; set; } //required: compulsory field
        public double BookPrice { get; set; }
        public int BookQuantity { get; set; } 
        public string? BookCover { get; set; } //? : nullable field
    }
}
