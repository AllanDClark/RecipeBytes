using MediatR;

namespace RecipeBytes.Events.InstructionStepEvents.Commands
{
    public class DeleteInstructionStep : IRequest
    {
        public Guid InstructionStepId { get; set; }
    }
}
