using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using FitnessDiets.Models;

namespace FitnessDiets.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Food> Foods { get; set; }
        public DbSet<ListFood> ListFood { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

             builder.Entity<Food>().HasData(new Food
            {
                Id = new Guid("6DA261FF-D98A-4132-A33E-509858C0CE31"),
                FoodName = "Борщ",
                Eatenfood = 200,
                Calories = 200
            });

            builder.Entity<ListFood>().HasData(new ListFood
            {
                Id = new Guid("6DA221FF-D98A-4132-A33E-509858C0CE31"),
                FoodOfName = "Борщ",
                Calories = 600
            });
        }
    }
}





    

