using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FitnessDiets.Data;
using FitnessDiets.Models;

namespace FitnessDiets.Repository 
{
    public class ListFoodRepository
    {
        //класс-репозиторий напрямую обращается к контексту базы данных
        private readonly ApplicationDbContext context;
        public ListFoodRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public ListFood GetFoodByFood(string FoodOfName)
        {
            return context.ListFood.Single(x => x.FoodOfName == FoodOfName);
        }

    }
}
