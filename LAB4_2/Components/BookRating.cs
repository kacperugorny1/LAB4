namespace LAB4_2.Components
{
    public class BookRating
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public int Rate { get; set; }
        public string UserId { get; set; }
        public BookRating()
        {
            UserId = "";
        }
    }
}
