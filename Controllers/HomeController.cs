using FitnessDiets.Data;
using FitnessDiets.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;
using System.Collections.Generic;
using FitnessDiets.Repository;

namespace FitnessDiets.Controllers
{
    public class HomeController : Controller
    {
        private readonly FoodsRepository foodsRepository;
        private readonly ListFoodRepository listFoodRepository;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ListFoodRepository listFoodRepository, FoodsRepository foodsRepository, ILogger<HomeController> logger) 
        {
            this.listFoodRepository = listFoodRepository;
            this.foodsRepository = foodsRepository;
            _logger = logger;
        }

        //выбираем все записи из БД и передаем их в представление
        public IActionResult Index()
        {
            var model = foodsRepository.GetFoods();
            return View(model);
        }

        //либо создаем новую еду, либо выбираем существующую и передаем в качестве модели в представление
        public IActionResult FoodEdit(Guid id) 
        {
            Food model = id == default ? new Food() : foodsRepository.GetFoodById(id);
            return View(model);
        }

        [HttpPost] //в POST-версии метода сохраняем/обновляем запись в БД
        public IActionResult FoodsEdit(Food model)
        {
            model.Calories = GetCalories(model.Eatenfood, model.Calories);
            if (ModelState.IsValid)
            {
                foodsRepository.SaveFood(model);
                return RedirectToAction("Index");
            }
            return View(model);
        }


        [HttpPost] //т.к. удаление еды изменяет состояние приложения, нельзя использовать метод GET
        public IActionResult FoodsDelete(Guid id)
        {
            foodsRepository.DeleteFood(new Food() { Id = id });
            return RedirectToAction("Index");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public int GetCalories(int countFood, int calories)
        {
            int caloriesResult;
            if (calories == 0)
            {
                Random rnd = new Random();
                caloriesResult = rnd.Next(1, 15) * 10 * countFood;
            }
            else
                caloriesResult = calories;
            
            return caloriesResult;
        }
    }
}
