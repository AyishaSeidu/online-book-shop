using System.ComponentModel.DataAnnotations;

namespace OnlineBookShop.Api.Models
{
    public class Genre
    {

        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
