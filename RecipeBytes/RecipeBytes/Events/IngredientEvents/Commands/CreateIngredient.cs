using MediatR;

namespace RecipeBytes.Events.IngredientEvents.Commands
{
    public class CreateIngredient : IRequest
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
    }
}
