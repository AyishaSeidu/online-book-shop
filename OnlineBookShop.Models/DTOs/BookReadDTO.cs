using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookShop.Models.DTOs
{
    public class BookReadDTO
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public int AuthorID { get; set; }

        [Required]
        public int GenreID { get; set; }

        [Range(1, 100)]
        [Required]
        public double Price { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public int YearPublished { get; set; }

        [Required]
        public string ISBN { get; set; }

        [Required]
        public string ImageURL { get; set; }

        [Required]
        public string AuthorName { get; set; }

        [Required]
        public string GenreName { get; set; }
    }
}
