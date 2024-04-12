using MediatR;
using RecipeBytes.Domain.Entities;
using RecipeBytes.Events.RecipeEvents.Queries;
using RecipeBytes.Infrastructure.Repositories;

namespace RecipeBytes.Events.RecipeEvents.QueryHandlers
{
    public class GetRecipeByIdHandler(RecipeRepository recipeRepository) : IRequestHandler<GetRecipeById, Recipe>
    {
        private readonly RecipeRepository _recipeRepository = recipeRepository;

        public async Task<Recipe> Handle(GetRecipeById request, CancellationToken cancellationToken)
        {
            return await _recipeRepository.GetByIdAsync(request.RecipeId);
        }
    }
}
