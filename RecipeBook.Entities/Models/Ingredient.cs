using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeBook.Entities.Models
{

    // Note: Conceptually this is an ingredient in a recipe.
    // Each ingredient in each recipe is unique (no separate DB of ingredients)

    public class Ingredient
    {
        [Key]
        public int Id { get; set; } //should be public? When to use private?

        [Required]
        public string IngredientName { get; set; }

        public string IngredientAmount { get; set; }
        public string IngredientUnit { get; set; }
    }
}
