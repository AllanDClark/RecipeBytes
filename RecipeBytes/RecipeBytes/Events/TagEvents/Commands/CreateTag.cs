using MediatR;

namespace RecipeBytes.Events.TagEvents.Commands
{
    public class CreateTag : IRequest
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
    }
}
