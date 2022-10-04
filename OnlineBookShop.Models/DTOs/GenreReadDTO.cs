using System.ComponentModel.DataAnnotations;

namespace OnlineBookShop.Models.DTOs
{
    internal class GenreReadDTO
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
