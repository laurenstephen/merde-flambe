using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeBook.Entities.Models
{
    public class UserAccount : IdentityUser
    {

        //You can set this to inherit from Asp

        //Or should I have an int as primary key?
        //UserName and Email must be unique - combined key
        [Key]
        public override string Id { get; set; }
        public override string UserName { get; set; }
        [EmailAddress]
        public override string Email { get; set; } // Should be a string?
        //public string Password { get; set; }  // Seems not right.

        //User accounts and recipes will be associated with pictures.
        //How to represent in DB code?


    }
}
