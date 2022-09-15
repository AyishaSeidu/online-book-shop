using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineBookShop.Api.Models
{
    public class Cart
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [ForeignKey("UserID")]
        public User User { get; set; }

        [Required]
        public int UserID { get; set; }
    }
}
