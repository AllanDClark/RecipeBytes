using MediatR;
using RecipeBytes.Domain.Entities;
using RecipeBytes.Events.InstructionStepEvents.Queries;
using RecipeBytes.Infrastructure.Repositories;

namespace RecipeBytes.Events.InstructionStepEvents.QueryHandlers
{
    public class GetInstructionStepsByRecipeIdHandler(InstructionStepRepository instructionStepRepository) : IRequestHandler<GetInstructionStepsByRecipeId, IEnumerable<InstructionStep>>
    {
        private readonly InstructionStepRepository _instructionStepRepository = instructionStepRepository;

        public async Task<IEnumerable<InstructionStep>> Handle(GetInstructionStepsByRecipeId request, CancellationToken cancellationToken)
        {
            return await _instructionStepRepository.GetInstructionStepsByRecipeId(request.RecipeId);
        }
    }
}
