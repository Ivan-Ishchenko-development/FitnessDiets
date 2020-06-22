using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessDiets.Data
{
    public class FoodsRepository
    {
        //класс-репозиторий напрямую обращается к контексту базы данных
        private readonly ApplicationDbContext context;
        public FoodsRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        //выбрать все записи из таблицы Foods
        public IQueryable<Food> GetFoods()
        {

            return context.Foods.OrderBy(x => x.FoodName);
        }

        //найти определенную запись по id
        public Food GetFoodById(Guid id)
        {
            return context.Foods.Single(x => x.Id == id);
        }

        //сохранить новую либо обновить существующую запись в БД
        public Guid SaveFood(Food entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();

            return entity.Id;
        }

        //удалить существующую запись
        public void DeleteFood(Food entity)
        {
            context.Foods.Remove(entity);
            context.SaveChanges();
        }
    }
}
