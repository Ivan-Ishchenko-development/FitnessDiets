using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace FitnessDiets.Controllers
{
    public class InfoDietController : Controller
    {
        public IActionResult InfoDiet()
        {
            return View();
        }
    }
}