using Microsoft.EntityFrameworkCore;
using RecipeBytes.Domain.Entities;
using RecipeBytes.Infrastructure.Data;

namespace RecipeBytes.Infrastructure.Repositories
{
    public class RecipeRepository(RecipeBytesDbContext dbContext) : RepositoryBase<Recipe>(dbContext)
    {
        public override async Task<Recipe> GetByIdAsync(Guid id)
        {
            return await _dbContext.Recipes
                .Include(x => x.Ingredients)
                .Include(x => x.InstructionSteps)
                .FirstAsync(x => x.Id == id);
        }
    }
}
