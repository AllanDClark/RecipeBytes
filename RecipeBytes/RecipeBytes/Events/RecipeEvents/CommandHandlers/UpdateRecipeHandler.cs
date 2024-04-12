using MediatR;
using RecipeBytes.Infrastructure.Repositories;
using RecipeBytes.Events.RecipeEvents.Commands;
using RecipeBytes.Domain.Entities;

namespace RecipeBytes.Events.RecipeEvents.CommandHandlers
{
    public class UpdateRecipeHandler(RecipeRepository recipeRepository, InstructionStepRepository instructionStepRepository, IngredientRepository ingredientRepository) : IRequestHandler<UpdateRecipe>
    {
        private readonly RecipeRepository _recipeRepository = recipeRepository;
        private readonly InstructionStepRepository _instructionStepRepository = instructionStepRepository;
        private readonly IngredientRepository _ingredientRepository = ingredientRepository;

        public async Task Handle(UpdateRecipe request, CancellationToken cancellationToken)
        {
            var steps = await _instructionStepRepository.GetInstructionStepsByRecipeId(request.RecipeId);
            await _instructionStepRepository.RemoveRangeAsync(steps);

            var ingredients = (await _ingredientRepository.GetAllAsync()).Where(x => request.Ingredients!.Contains(x.Id)).ToList();

            var recipe = await _recipeRepository.GetByIdAsync(request.RecipeId);
            recipe.Name = request.Name;
            recipe.Description = request.Description;
            recipe.ImageUrl = request.ImageUrl;
            recipe.Ingredients = ingredients;
            var newSteps = request.InstructionSteps?.Select(x => new InstructionStep
            {
                Description = x
            }).ToList();
            recipe.InstructionSteps = newSteps;
            recipe.Tags = request.Tags;
            await _recipeRepository.SaveChangesAsync();
        }
    }
}
