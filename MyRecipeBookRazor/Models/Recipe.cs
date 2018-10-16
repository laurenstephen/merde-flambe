using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyRecipeBookRazor.Models
{
    public class Recipe
    {
        // NB: these are from example: https://docs.microsoft.com/en-us/aspnet/core/tutorials/razor-pages/model?view=aspnetcore-2.1
        // Need to be adapted for my project, scaffolded.
        // How to change after initial scaffold?
        // Updated 11:19pm Oct 15 - repository syncing right?
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
    }
}
