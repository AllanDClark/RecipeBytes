using Microsoft.EntityFrameworkCore;
using RecipeBytes.Domain.Entities;
using RecipeBytes.Infrastructure.Data;

namespace RecipeBytes.Infrastructure.Repositories
{
    public class InstructionStepRepository(RecipeBytesDbContext dbContext) : RepositoryBase<InstructionStep>(dbContext)
    {
        public async Task<IEnumerable<InstructionStep>> GetInstructionStepsByRecipeId(Guid recipeId)
        {
            return await _dbContext.InstructionSteps.Where(x => x.RecipeId == recipeId).ToListAsync();
        }
    }
}
