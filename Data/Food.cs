using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace FitnessDiets.Data
{
    public class Food
    {

        [Required]
        public Guid Id { get; set; }

        [Required]
        [Display(Name = "Название еды")]
        public string FoodName { get; set; }

        [Required]
        [Display(Name = "Количество сьеденной пищи(г)")]
        public int Eatenfood { get; set; }

    }
}
