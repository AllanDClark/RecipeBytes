using MediatR;
using RecipeBytes.Domain.Entities;

namespace RecipeBytes.Events.RecipeEvents.Commands
{
    public class CreateRecipe : IRequest
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
        public List<Tag>? Tags { get; set; }
        public List<Guid>? Ingredients { get; set;}
        public List<string>? InstructionSteps { get; set; }

    }
}
