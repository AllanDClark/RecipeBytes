using MediatR;
using RecipeBytes.Domain.Entities;
using RecipeBytes.Events.InstructionStepEvents.Commands;
using RecipeBytes.Infrastructure.Repositories;

namespace RecipeBytes.Events.InstructionStepEvents.CommandHandlers
{
    public class CreateInstructionStepHandler(InstructionStepRepository instructionStepRepository) : IRequestHandler<CreateInstructionStep, InstructionStep>
    {
        private readonly InstructionStepRepository _instructionStepRepository = instructionStepRepository;

        public async Task<InstructionStep> Handle(CreateInstructionStep request, CancellationToken cancellationToken)
        {
            var instructionStep = new InstructionStep
            {
                Name = request.Name,
                Description = request.Description,
                RecipeId = request.RecipeId,
            };
            await _instructionStepRepository.AddAsync(instructionStep);
            return instructionStep;
        }
    }
}
