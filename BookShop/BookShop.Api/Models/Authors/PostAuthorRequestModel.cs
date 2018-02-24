namespace BookShop.Api.Models.Authors
{
    using System.ComponentModel.DataAnnotations;
    using BookShop.Common.Mapping;
    using Data.Models;

    public class PostAuthorRequestModel : IMapFrom<Author>
    {
        [Required]
        [MinLength(2)]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(50)]
        public string LastName { get; set; }
    }
}
