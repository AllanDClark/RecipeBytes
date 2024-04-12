using MediatR;

namespace RecipeBytes.Events.IngredientEvents.Commands
{
    public class DeleteIngredient : IRequest
    {
        public Guid Id { get; set; }
    }
}
