using MediatR;

namespace RecipeBytes.Events.IngredientEvents.Commands
{
    public class UpdateIngredient : IRequest
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
    }
}
