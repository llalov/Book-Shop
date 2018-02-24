namespace BookShop.Services.Implementations
{
    using Interfaces;
    using Data;
    using BookShop.Services.Models;
    using System.Threading.Tasks;
    using System.Linq;
    using AutoMapper.QueryableExtensions;
    using Microsoft.EntityFrameworkCore;
    using Data.Models;

    public class AuthorService : IAuthorService
    {
        private readonly BookShopDbContext Db;

        public AuthorService(BookShopDbContext db)
        {
            this.Db = db;
        }

        public async Task<int> Create(string firstName, string lastName)
        {
            Author author = new Author
            {
                FirstName = firstName,
                LastName = lastName
            };

            this.Db.Add(author);
            await this.Db.SaveChangesAsync();

            return author.Id;
        }

        public async Task<AuthorDetailsServiceModel> Details(int id)
            => await this.Db
                .Authors
                .Where(a => a.Id == id)
                .ProjectTo<AuthorDetailsServiceModel>()
                .FirstOrDefaultAsync();
    }
}
