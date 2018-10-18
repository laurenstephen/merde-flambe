using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RecipeBook.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeBook.Entities
{
    public class RecipesDbContext : IdentityDbContext<UserAccount>
    {
        public Ingredient Ingredients { get; set; }
        public Recipe Recipes { get; set; }
        public UserAccount UserAccounts { get; set; }

        public RecipesDbContext (DbContextOptions<RecipesDbContext> Options )
        {
        
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=aspnet-MyRecipeBookRazor-53bc9b9d-9d6a-45d4-8429-2a2761773502;Trusted_Connection=True;MultipleActiveResultSets=true"); //Figure out how to add confriguration

            // Configuration string / Appsettings.josn
        }



    }
}
