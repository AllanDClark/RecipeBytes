using MediatR;
using RecipeBytes.Domain.Entities;

namespace RecipeBytes.Events.IngredientEvents.Queries
{
    public class GetAllIngredients : IRequest<IEnumerable<Ingredient>>
    {
    }
}
