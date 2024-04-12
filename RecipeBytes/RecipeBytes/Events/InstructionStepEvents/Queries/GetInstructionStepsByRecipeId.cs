using MediatR;
using RecipeBytes.Domain.Entities;

namespace RecipeBytes.Events.InstructionStepEvents.Queries
{
    public class GetInstructionStepsByRecipeId : IRequest<IEnumerable<InstructionStep>>
    {
        public Guid RecipeId { get; set; }
    }
}
