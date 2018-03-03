namespace BookShop.Api.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Services.Interfaces;
    using System.Threading.Tasks;
    using Models.Books;

    public class BooksController : BaseController
    {
        private readonly IBookService Books;

        public BooksController(IBookService books)
        {
            this.Books = books;
        }

        public async Task<IActionResult> Post([FromBody] PostBookRequestModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);


            return null;
            //return Ok(await this.Books.Create());
        }
    }
}
