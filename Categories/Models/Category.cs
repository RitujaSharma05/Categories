﻿using System.ComponentModel.DataAnnotations;

namespace Categories.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = String.Empty;
        [Required]
        public string Description { get; set; } = String.Empty;
    }
}
