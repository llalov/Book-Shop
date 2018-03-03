namespace BookShop.Services.Interfaces
{
    using System.Threading.Tasks;
    using System;

    public interface IBookService
    {
        Task<int> Create(string title, string description, decimal price, int copies, int authorId, int? edition, int? ageRestriction, DateTime releaseDate, string categoryNames);
    }
}
