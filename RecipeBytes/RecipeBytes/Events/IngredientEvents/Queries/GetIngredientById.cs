using MediatR;
using RecipeBytes.Domain.Entities;

namespace RecipeBytes.Events.IngredientEvents.Queries
{
    public class GetIngredientById : IRequest<Ingredient>
    {
        public Guid Id { get; set; }
    }
}
