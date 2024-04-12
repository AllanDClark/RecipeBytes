using RecipeBytes.Domain.Entities;
using RecipeBytes.Infrastructure.Data;

namespace RecipeBytes.Infrastructure.Repositories
{
    public class IngredientRepository(RecipeBytesDbContext dbContext) : RepositoryBase<Ingredient>(dbContext)
    {
    }
}
