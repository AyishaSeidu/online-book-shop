using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookShop.Models.DTOs
{
    public class CartItemReadDTO
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public int BookID { get; set; }

        [Required]
        public int CartID { get; set; }

        [Required]
        public string BookTitle { get; set; }

        [Required]
        public string ImageURL { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public string AuthorName { get; set; }

        public double TotalPrice { get; set; }


    }
}
