using MediatR;
using RecipeBytes.Domain.Entities;
using RecipeBytes.Infrastructure.Repositories;
using RecipeBytes.Events.IngredientEvents.Commands;

namespace RecipeBytes.Events.IngredientEvents.CommandHandlers
{
    public class CreateIngredientHandler(IngredientRepository ingredientRepository) : IRequestHandler<CreateIngredient>
    {
        private readonly IngredientRepository _ingredientRepository = ingredientRepository;

        public async Task Handle(CreateIngredient request, CancellationToken cancellationToken)
        {
            var ingredient = new Ingredient
            {
                Name = request.Name,
                Description = request.Description
            };
            await _ingredientRepository.AddAsync(ingredient);
        }
    }
}
