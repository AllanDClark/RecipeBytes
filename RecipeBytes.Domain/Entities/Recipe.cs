using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBytes.Domain.Entities
{
    public class Recipe : BaseEntity
    {
        public string? ImageUrl { get; set; }
        public List<Tag>? Tags { get; set; }
        public List<Ingredient> Ingredients { get; set; } = [];
        public List<InstructionStep> InstructionSteps { get; set; } = [];
    }
}
