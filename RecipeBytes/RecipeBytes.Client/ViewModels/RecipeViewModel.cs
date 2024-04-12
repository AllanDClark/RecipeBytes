namespace RecipeBytes.Client.ViewModels
{
    public record RecipeViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public List<TagViewModel>? Tags { get;}
        public List<string>? SelectedIngredients { get; set; }
        public List<Guid>? Ingredients { get; set; }
        public List<string> InstructionSteps { get; set; } = new();
    }
}
