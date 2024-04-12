using MediatR;
using RecipeBytes.Domain.Entities;
using RecipeBytes.Events.RecipeEvents.Queries;
using RecipeBytes.Infrastructure.Repositories;

namespace RecipeBytes.Events.RecipeEvents.QueryHandlers
{
    public class GetAllRecipesHandler(RecipeRepository recipeRepository) : IRequestHandler<GetAllRecipes, IEnumerable<Recipe>>
    {
        private readonly RecipeRepository _recipeRepository = recipeRepository;

        public async Task<IEnumerable<Recipe>> Handle(GetAllRecipes request, CancellationToken cancellationToken)
        {
            return await _recipeRepository.GetAllAsync();
        }
    }
}
