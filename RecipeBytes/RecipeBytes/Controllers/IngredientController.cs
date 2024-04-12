using MediatR;
using Microsoft.AspNetCore.Mvc;
using RecipeBytes.Client.ViewModels;
using RecipeBytes.Events.IngredientEvents.Queries;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RecipeBytes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IngredientController(IMediator mediator) : ControllerBase
    {
        private readonly IMediator _mediator = mediator;

        // GET: api/<IngredientController>
        [HttpGet]
        public async Task<IEnumerable<IngredientViewModel>> Get()
        {
            var allIngredients = await _mediator.Send(new GetAllIngredients());
            return allIngredients.Select(x => new IngredientViewModel
            {
                Id = x.Id,
                Name = x.Name!,
                Description = x.Description!,
                ImageUrl = x.ImageUrl!
            });
        }

        // GET api/<IngredientController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<IngredientController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<IngredientController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<IngredientController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
