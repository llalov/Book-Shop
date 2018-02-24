namespace BookShop.Services.Interfaces
{
    using System.Threading.Tasks;
    using Models;

    public interface IAuthorService
    {
        Task<AuthorDetailsServiceModel> Details(int id);

        Task<int> Create(string firstName, string lastName);
    }
}
