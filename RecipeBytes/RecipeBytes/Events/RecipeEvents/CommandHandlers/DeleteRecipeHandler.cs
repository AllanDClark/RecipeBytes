using MediatR;
using RecipeBytes.Infrastructure.Repositories;
using RecipeBytes.Events.RecipeEvents.Commands;

namespace RecipeBytes.Events.RecipeEvents.CommandHandlers
{
    public class DeleteRecipeHandler(RecipeRepository recipeRepository) : IRequestHandler<DeleteRecipe>
    {
        private readonly RecipeRepository _recipeRepository = recipeRepository;

        public async Task Handle(DeleteRecipe request, CancellationToken cancellationToken)
        {
            await _recipeRepository.RemoveAsync(request.RecipeId);
        }
    }
}
