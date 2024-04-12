using MediatR;
using RecipeBytes.Domain.Entities;
using RecipeBytes.Events.IngredientEvents.Queries;
using RecipeBytes.Infrastructure.Repositories;
namespace RecipeBytes.Events.IngredientEvents.QueryHandlers
{
    public class GetIngredientByIdHandler(IngredientRepository ingredientRepository) : IRequestHandler<GetIngredientById, Ingredient>
    {
        public readonly IngredientRepository _ingredientRepository = ingredientRepository;

        public async Task<Ingredient> Handle(GetIngredientById request, CancellationToken cancellationToken)
        {
            return await _ingredientRepository.GetByIdAsync(request.Id);
        }
    }
}
