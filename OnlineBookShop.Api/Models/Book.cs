using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineBookShop.Api.Models
{
    public class Book
    {
        [Required]
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [ForeignKey("AuthorID")]
        public Author Author { get; set; }

        [Required]
        public int AuthorID { get; set; }

        [Required]
        [Range(1, 100)]
        public double Price { get; set; }

        [Required]
        public int YearPublished { get; set; }

        [Required]
        public string ISBN { get; set; }

        [ForeignKey("GenreID")]
        public Genre Genre { get; set; }

        [Required]
        public int GenreID { get; set; }

        [Required]
        public string ImageURL { get; set; }

        [Required]
        public int Quantity { get; set; }
    }
}
