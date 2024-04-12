using MediatR;
using RecipeBytes.Domain.Entities;

namespace RecipeBytes.Events.InstructionStepEvents.Commands
{
    public class CreateInstructionStep : IRequest<InstructionStep>
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public Guid RecipeId { get; set; }
    }
}
