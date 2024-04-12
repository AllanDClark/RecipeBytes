using MediatR;
using RecipeBytes.Infrastructure.Repositories;
using RecipeBytes.Events.IngredientEvents.Commands;

namespace RecipeBytes.Events.IngredientEvents.CommandHandlers
{
    public class DeleteIngredientHandler(IngredientRepository ingredientRepository) : IRequestHandler<DeleteIngredient>
    {
        public readonly IngredientRepository _ingredientRepository = ingredientRepository;

        public async Task Handle(DeleteIngredient request, CancellationToken cancellationToken)
        {
            await _ingredientRepository.RemoveAsync(request.Id);
        }
    }
}
