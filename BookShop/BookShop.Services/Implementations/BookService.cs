namespace BookShop.Services.Implementations
{
    using Interfaces;
    using Data;
    using System;
    using System.Threading.Tasks;

    public class BooksService : IBookService
    {
        private readonly BookShopDbContext Db;

        public BooksService(BookShopDbContext db)
        {
            this.Db = db;
        }

        public Task<int> Create(string title, string description, decimal price, int copies, int authorId, int? edition, int? ageRestriction, DateTime releaseDate, string categoryNames)
        {
            throw new NotImplementedException();
        }
    }
}

