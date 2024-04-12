using MediatR;
using Microsoft.AspNetCore.Mvc;
using RecipeBytes.Client.ViewModels;
using RecipeBytes.Domain.Entities;
using RecipeBytes.Events.RecipeEvents.Commands;
using RecipeBytes.Events.RecipeEvents.Queries;
using RecipeBytes.Infrastructure.Data;
using System.Reflection.Metadata.Ecma335;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RecipeBytes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipeController(IMediator mediator) : ControllerBase
    {
        private readonly IMediator _mediator = mediator;

        // GET: api/<RecipeController>
        [HttpGet]
        public async Task<List<RecipeViewModel>> GetAsync()
        {
            var response = await _mediator.Send(new GetAllRecipes());
            return response.Select(x => new RecipeViewModel
            {
                Id = x.Id,
                Name = x.Name!,
                Description = x.Description!,
                ImageUrl = x.ImageUrl!,
                Ingredients = x.Ingredients.Select(x => x.Id).ToList(),
                InstructionSteps = x.InstructionSteps.Select(x => x.Description).ToList()!
            }).ToList();
        }

        // GET api/<RecipeController>/5
        [HttpGet("{id}")]
        public async Task<RecipeViewModel> Get(Guid id)
        {
            var response = await _mediator.Send(new GetRecipeById { RecipeId = id });
            var test = response.Ingredients.Select(x => x.Id).ToList();
            var test2 = response.InstructionSteps.Select(x => x.Description).ToList();
            return new RecipeViewModel
            {
                Id = response.Id,
                Name = response.Name!,
                Description = response.Description!,
                ImageUrl = response.ImageUrl!,
                Ingredients = response.Ingredients.Select(x => x.Id).ToList(),
                InstructionSteps = response.InstructionSteps.Select(x => x.Description).ToList()!
            };
        }

        // POST api/<RecipeController>
        [HttpPost]
        public async Task PostAsync([FromBody] RecipeViewModel value)
        {
            await _mediator.Send(new CreateRecipe 
            { 
                Name = value.Name,
                Description = value.Description,
                ImageUrl = value.ImageUrl,
                Ingredients = value.Ingredients,
                InstructionSteps = value.InstructionSteps,
            });
        }

        // PUT api/<RecipeController>/5
        [HttpPut("{id}")]
        public async Task Put([FromBody] RecipeViewModel value)
        {
            await _mediator.Send(new UpdateRecipe
            {
                RecipeId = value.Id,
                Name = value.Name,
                Description = value.Description,
                ImageUrl = value.ImageUrl,
                InstructionSteps = value.InstructionSteps,
                Ingredients = value.Ingredients

            });

        }

        // DELETE api/<RecipeController>/5
        [HttpDelete("{id}")]
        public async Task Delete(Guid id)
        {
            await _mediator.Send(new DeleteRecipe { RecipeId = id });
        }
    }
}
