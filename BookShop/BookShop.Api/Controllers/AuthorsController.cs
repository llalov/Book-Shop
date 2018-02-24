namespace BookShop.Api.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;
    using Services.Interfaces;
    using Models.Authors;

    public class AuthorsController : BaseController
    {
        private readonly IAuthorService Authors;

        public AuthorsController(IAuthorService authors)
        {
            this.Authors = authors;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            if (!ModelState.IsValid)
                return NotFound();


            return Ok(await Authors.Details(id));
        } 

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] PostAuthorRequestModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(await Authors.Create(
                model.FirstName, 
                model.LastName ));
        }
    }
}
