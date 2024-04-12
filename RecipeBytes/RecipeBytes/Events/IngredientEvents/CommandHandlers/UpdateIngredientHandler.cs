using MediatR;

namespace RecipeBytes.Events.IngredientEvents.CommandHandlers
{
    public class UpdateIngredientHandler : IRequest
    {
        public string? Name { get; set; }
        public string? Description { get; set; }

    }
}
