using Microsoft.EntityFrameworkCore;
using RecipeBytes.Domain.Entities;

namespace RecipeBytes.Infrastructure.Data
{

    public class RecipeBytesDbContext(DbContextOptions<RecipeBytesDbContext> options) : DbContext(options)
    {
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<InstructionStep> InstructionSteps { get; set; }
        public DbSet<Tag> Tags { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            new DbInitializer(modelBuilder).Seed();
        }
    }
}
