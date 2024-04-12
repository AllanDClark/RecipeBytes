
namespace RecipeBytes.Domain.Entities
{
    public class Tag : BaseEntity
    {
        public List<Recipe>? Recipes { get; set; }
    }
}
