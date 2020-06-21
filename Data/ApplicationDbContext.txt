using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FitnessDiets.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Food> Foods { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
           
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            _ = builder.Entity<Food>().HasData(new Food { 
            Id = new Guid("AA051370-D1FF-4C53-BC05-DB0C92710C69"),
                FoodName = "Борщ",
                Eatenfood = 400
            });;
        }
    }
}
