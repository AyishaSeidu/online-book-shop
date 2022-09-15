﻿using System.ComponentModel.DataAnnotations;

namespace OnlineBookShop.Api.Models
{
    public class User
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string UserName { get; set; }
    }
}
