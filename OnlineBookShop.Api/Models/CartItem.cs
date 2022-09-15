using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineBookShop.Api.Models
{
    public class CartItem
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [ForeignKey("BookID")]
        public Book Book { get; set; }

        [Required]
        public int BookID { get; set; }

        [ForeignKey("CartID")]
        public Cart Cart { get; set; }

        [Required]
        public int CartID { get; set; }

        [Required]
        public int Quantity { get; set; }
    
}
}
