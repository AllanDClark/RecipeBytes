using MediatR;

namespace RecipeBytes.Events.TagEvents.Commands
{
    public class DeleteTag : IRequest
    {
        public Guid TagId { get; set; }
    }
}
