using MediatR;
using RecipeBytes.Domain.Entities;

namespace RecipeBytes.Events.RecipeEvents.Queries
{
    public class GetRecipeById : IRequest<Recipe>
    {
        public Guid RecipeId { get; set; }
    }
}
