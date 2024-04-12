namespace RecipeBytes.Domain.Entities
{
    public class Ingredient : BaseEntity
    {
        public double? Quantity { get; set; }
        public string? ImageUrl { get; set; }
        public List<Recipe> Recipes { get; set; } = [];
    }
}
