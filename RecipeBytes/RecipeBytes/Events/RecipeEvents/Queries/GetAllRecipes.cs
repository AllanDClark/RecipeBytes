using MediatR;
using RecipeBytes.Domain.Entities;

namespace RecipeBytes.Events.RecipeEvents.Queries
{
    public class GetAllRecipes : IRequest<IEnumerable<Recipe>>
    {
    }
}
