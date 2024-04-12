namespace RecipeBytes.Domain.Entities
{
    public class InstructionStep : BaseEntity
    {
        public TimeSpan? Duration { get; set; }
        public Guid RecipeId { get; set; }
        public Recipe? Recipe { get; set; }
    }
}
