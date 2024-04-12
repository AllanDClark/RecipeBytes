using MediatR;
using RecipeBytes.Domain.Entities;
using RecipeBytes.Events.RecipeEvents.Commands;
using RecipeBytes.Infrastructure.Repositories;

namespace RecipeBytes.Events.RecipeEvents.CommandHandlers
{
    public class CreateRecipeHandler(RecipeRepository recipeRepository, IngredientRepository ingredientRepository) : IRequestHandler<CreateRecipe>
    {
        private readonly RecipeRepository _recipeRepository = recipeRepository;
        private readonly IngredientRepository _ingredientRepository = ingredientRepository;

        public async Task Handle(CreateRecipe request, CancellationToken cancellationToken)
        {
            var ingredients = await _ingredientRepository.GetAllAsync();
            var recipe = new Recipe
            {
                Name = request.Name,
                Description = request.Description,
                ImageUrl = request.ImageUrl,
                Ingredients = ingredients.Where(x => request.Ingredients!.Contains(x.Id)).ToList(),
                InstructionSteps = request.InstructionSteps?.Select(x => new InstructionStep { Description = x}).ToList(),
                Tags = request.Tags
            };
            await _recipeRepository.AddAsync(recipe);
        }
    }
}
