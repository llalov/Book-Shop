namespace BookShop.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Book
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        [MaxLength(int.MaxValue)]
        public decimal Price { get; set; }

        [Required]
        [MaxLength(int.MaxValue)]
        public int Copies { get; set; }

        public Author Author { get; set; }

        public int AuthorId { get; set; }

        public int? Edition { get; set; }

        public int? AgeRestriction { get; set; }

        public DateTime ReleaseDate { get; set; }

        public List<CategoryBooks> Categories { get; set; } = new List<CategoryBooks>();
    }
}
