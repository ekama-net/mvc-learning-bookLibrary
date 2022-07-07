using System.ComponentModel.DataAnnotations;

namespace mvcBookLibrary.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Введите название произведения")]
        [MaxLength(100)]
        public string? Title { get; set; }

        [Required(ErrorMessage = "Введите жанр")]
        [MaxLength(20)]
        public string? Genre { get; set; }

        public string? Author { get; set; }
    }
}
