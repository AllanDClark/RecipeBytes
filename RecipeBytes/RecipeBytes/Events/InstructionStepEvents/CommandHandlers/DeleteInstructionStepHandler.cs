using MediatR;
using RecipeBytes.Events.InstructionStepEvents.Commands;
using RecipeBytes.Infrastructure.Repositories;

namespace RecipeBytes.Events.InstructionStepEvents.CommandHandlers
{
    public class DeleteInstructionStepHandler(InstructionStepRepository instructionStepRepository) : IRequestHandler<DeleteInstructionStep>
    {
        private readonly InstructionStepRepository _instructionStepRepository = instructionStepRepository;

        public async Task Handle(DeleteInstructionStep request, CancellationToken cancellationToken)
        {
            var instructionStep = await _instructionStepRepository.GetByIdAsync(request.InstructionStepId);
            await _instructionStepRepository.RemoveAsync(instructionStep);
        }
    }
}
