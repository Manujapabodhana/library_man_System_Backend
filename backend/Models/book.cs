using System.ComponentModel.DataAnnotations;

namespace backend.Models
{
    /// <summary>
    /// Book entity representing a book in the library
    /// </summary>
    public class Book
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Title is required")]
        [StringLength(100, ErrorMessage = "Title cannot exceed 100 characters")]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "Author is required")]
        [StringLength(100, ErrorMessage = "Author cannot exceed 100 characters")]
        public string Author { get; set; } = string.Empty;

        [StringLength(500, ErrorMessage = "Description cannot exceed 500 characters")]
        public string? Description { get; set; }

        [StringLength(20, ErrorMessage = "ISBN cannot exceed 20 characters")]
        public string? ISBN { get; set; }

        public DateTime? PublishedDate { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "AvailableCopies must be 0 or greater")]
        public int? AvailableCopies { get; set; }
    }
}
