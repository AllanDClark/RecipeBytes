using MediatR;

namespace RecipeBytes.Events.RecipeEvents.Commands
{
    public class DeleteRecipe : IRequest
    {
        public Guid RecipeId { get; set; }
    }
}
