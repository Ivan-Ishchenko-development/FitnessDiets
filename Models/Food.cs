using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessDiets.Models
{
    public class Food
    {
        [Required]
        public Guid Id { get; set; }

        [Required]
        [Display(Name = "Название еды")]
        public string FoodName { get; set; }

        [Required]
        [Display(Name = "Количество съеденной пищи(г)")]
        public int Eatenfood { get; set; } = 0;

        [Required]
        [Display(Name = "Калории продукта")]
        public int Calories { get; set; }
    }
}
