using RecipeBytes.Domain.Entities;
using RecipeBytes.Infrastructure.Data;

namespace RecipeBytes.Infrastructure.Repositories
{
    public class TagRepository(RecipeBytesDbContext dbContext) : RepositoryBase<Tag>(dbContext)
    {
        public async Task<IEnumerable<Tag>> GetTagsByRecipeIdAsync(Guid recipeId)
        {
            return (await _dbContext.Recipes.FindAsync(recipeId)).Tags;
        }
    }
}
