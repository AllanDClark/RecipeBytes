using MediatR;
using RecipeBytes.Domain.Entities;
using RecipeBytes.Events.IngredientEvents.Queries;
using RecipeBytes.Infrastructure.Repositories;

namespace RecipeBytes.Events.IngredientEvents.QueryHandlers
{
    public class GetAllIngredientsHandler(IngredientRepository ingredientRepository) : IRequestHandler<GetAllIngredients, IEnumerable<Ingredient>>
    {
        private readonly IngredientRepository _ingredientRepository = ingredientRepository;

        public async Task<IEnumerable<Ingredient>> Handle(GetAllIngredients request, CancellationToken cancellationToken)
        {
            return await _ingredientRepository.GetAllAsync();
        }
    }
}
