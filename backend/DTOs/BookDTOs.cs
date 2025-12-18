using System.ComponentModel.DataAnnotations;

namespace backend.DTOs
{
    /// <summary>
    /// DTO for creating a new book
    /// </summary>
    public class CreateBookDto
    {
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

    /// <summary>
    /// DTO for updating an existing book
    /// </summary>
    public class UpdateBookDto
    {
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

    /// <summary>
    /// DTO for book response (what we send to the client)
    /// </summary>
    public class BookResponseDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public string? Description { get; set; }
        public string? ISBN { get; set; }
        public DateTime? PublishedDate { get; set; }
        public int? AvailableCopies { get; set; }
    }
}

