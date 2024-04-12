using MediatR;
using RecipeBytes.Domain.Entities;

namespace RecipeBytes.Events.TagEvents.Queries
{
    public class GetTagsByRecipeId : IRequest<IEnumerable<Tag>>
    {
        public Guid RecipeId { get; set; }
    }
}
