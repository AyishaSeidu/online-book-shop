using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookShop.Models.DTOs
{
    public class CartItemCreateDTO
    {
        [Required]
        public int BookID { get; set; }

        [Required]
        public int CartID { get; set; }

        [Required]
        public int Quantity { get; set; }
    }
}
