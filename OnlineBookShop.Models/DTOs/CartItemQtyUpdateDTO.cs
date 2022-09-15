using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookShop.Models.DTOs
{
    public class CartItemQtyUpdateDTO
    {
        [Required]
        public int CartItemId { get; set; }

        [Required]
        public int Quantity { get; set; }
    }
}
