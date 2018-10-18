using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeBook.Entities.Models
{
    public class Recipe
    {
        [Key]
        public int Id { get; set; } //should be public? When to use private?

        [Required]
        public string Title { get; set; }

        [Required]
        public Boolean isPublic { get; set; }

        public virtual ICollection<Ingredient> Ingredients { get; set; }

        [MaxLength(2000)]
        public string Directions { get; set; }

        //Collection of health tags here
        // Is this the best way to represent a boolean?

        [Range(0, 1)] //Default should be 0, or NULL defaults to 'not'
        public int isVegan { get; set; }


    }
}
