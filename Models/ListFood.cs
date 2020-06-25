using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FitnessDiets.Models
{
    public class ListFood
    {
        [Required]
        public Guid Id { get; set; }

        [Required]
        [Display(Name = "Название еды")]
        public string FoodOfName { get; set; }

        [Required]
        [Display(Name = "Калории за 100г продукта")]
        public int Calories { get; set; }
    }
}
