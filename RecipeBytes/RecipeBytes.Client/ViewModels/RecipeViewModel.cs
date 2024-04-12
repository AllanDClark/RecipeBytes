using System.ComponentModel.DataAnnotations;

namespace RecipeBytes.Client.ViewModels
{
    public record RecipeViewModel
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Please enter a recipe name.")]
        public string Name { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
        [Required(ErrorMessage = "Please enter a description.")]
        public string Description { get; set; } = string.Empty;
        public List<TagViewModel>? Tags { get;}
        public List<string>? SelectedIngredients { get; set; }
        public List<Guid>? Ingredients { get; set; }
        public List<string> InstructionSteps { get; set; } = new();
    }
}
