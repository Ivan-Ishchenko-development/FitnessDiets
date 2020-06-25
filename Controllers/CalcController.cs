using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FitnessDiets.Models;

namespace FitnessDiets.Controllers
{
    public class CalcController : Controller
    {
        public IActionResult Calc()
        {
            ViewBag.Kilocalorie = new List<double> { 0, 0, 0 };
            ViewBag.WeightWeek = new List<double> { 0, 0, 0 };
            ViewBag.WeightMonth = new List<double> { 0, 0, 0 };
            return View();
        }

        [HttpPost]
        public IActionResult Calc(int height, int weight, int age, string sex, string activity)
        {
            double activitys = 0;

            switch (activity)
            {
                case "1.2":
                    activitys = 1.2;
                    break;
                case "1.375":
                    activitys = 1.375;
                    break;
                case "1.4625":
                    activitys = 1.2;
                    break;
                case "1.55":
                    activitys = 1.375;
                    break;
                case "1.6375":
                    activitys = 1.2;
                    break;
                case "1.725":
                    activitys = 1.375;
                    break;
                case "1.9":
                    activitys = 1.375;
                    break;
                default:
                    break;
            }

            double norma = 0;
            double[] weightWeek = new double[3];
            double[] weightMonth = new double[3];
            double[] kilocalories = new double[3];

            if (sex == "man")
            {
                norma = activitys * ((10 * weight) + (6.25 * height) - (5 * age) + 5);
            }
            else
            {
                norma = activitys * ((10 * weight) + (6.25 * height) - (5 * age) - 161);
            }

            var def_safe = norma * 0.15;
            kilocalories[0] = Math.Round(norma - def_safe);
            weightWeek[0] = Math.Round((def_safe * 7) / 77) / 100;
            weightMonth[0] = Math.Round((def_safe * 30) / 77) / 100;

            var def_quick = norma * 0.25;
            kilocalories[1] = Math.Round(norma - def_quick);
            weightWeek[1] = Math.Round((def_quick * 7) / 77) / 100;
            weightMonth[1] = Math.Round((def_quick * 30) / 77) / 100;

            var def_urgently = norma * 0.4;
            kilocalories[2] = Math.Round(norma - def_urgently);
            weightWeek[2] = Math.Round((def_urgently * 7) / 77) / 100;
            weightMonth[2] = Math.Round((def_urgently * 30) / 77) / 100;

            ViewBag.Kilocalorie = new List<double> { kilocalories[0], kilocalories[1], kilocalories[2] };
            ViewBag.WeightWeek = new List<double> { weightWeek[0], weightWeek[1], weightWeek[2] };
            ViewBag.WeightMonth = new List<double> { weightMonth[0], weightMonth[1], weightMonth[2] };

            Calc c = new Calc(height, weight, age, sex, activitys, weightWeek, weightMonth, kilocalories);

            return View();
        }
    }
}