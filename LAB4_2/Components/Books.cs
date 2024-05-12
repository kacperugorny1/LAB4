using System.ComponentModel.DataAnnotations;

namespace LAB4_2.Components
{
    public class Book
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        [DataType(DataType.Date)]
        public DateTime? ReleaseData { get; set; }
        public float? Rate { get; set; }
        public int? RateCount { get; set; }
        public string? Url { get; set; }
    }
}
