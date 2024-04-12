using MediatR;
using RecipeBytes.Domain.Entities;

namespace RecipeBytes.Events.TagEvents.Queries
{
    public class GetAllTags : IRequest<IEnumerable<Tag>>
    {
    }
}
