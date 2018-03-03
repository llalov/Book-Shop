namespace BookShop.Api.Models.Books
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using AutoMapper;
    using Data.Models;
    using Common.Mapping;

    public class PostBookRequestModel : IMapFrom<Book>
    {
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

        public int AuthorId { get; set; }

        public int? Edition { get; set; }

        public int? AgeRestriction { get; set; }

        public DateTime ReleaseDate { get; set; }

        public string Categories { get; set; }
    }
}

