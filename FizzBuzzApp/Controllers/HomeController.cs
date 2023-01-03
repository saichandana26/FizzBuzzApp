using FizzBuzzApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FizzBuzzApp.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(FizzBuzzNumber fizzBuzzNumber)
        {
            fizzBuzzNumber.DayOfWeek = DateTime.Today.DayOfWeek.ToString();
            if (fizzBuzzNumber.DayOfWeek == "Wednesday")
            {
                fizzBuzzNumber.ThreeDivisible = "Wizz";
                fizzBuzzNumber.FiveDivisible = "Wuzz";
                fizzBuzzNumber.ThreeAndFiveDivisible = "WizzWuzz";
            }
            else
            {
                fizzBuzzNumber.ThreeDivisible = "Fizz";
                fizzBuzzNumber.FiveDivisible = "Buzz";
                fizzBuzzNumber.ThreeAndFiveDivisible = "FizzBuzz";
            }

            fizzBuzzNumber.DisplayNumbers = new List<string>(fizzBuzzNumber.Number);
            for (int i = 1; i <= fizzBuzzNumber.Number; i++)
            {
                if (i % 3 == 0 & i % 5 == 0)
                {
                    fizzBuzzNumber.DisplayNumbers.Add(fizzBuzzNumber.ThreeAndFiveDivisible);
                }
                else if (i % 3 == 0)
                {
                    fizzBuzzNumber.DisplayNumbers.Add(fizzBuzzNumber.ThreeDivisible);
                }
                else if (i % 5 == 0)
                {
                    fizzBuzzNumber.DisplayNumbers.Add(fizzBuzzNumber.FiveDivisible);

                }
                else
                {
                    fizzBuzzNumber.DisplayNumbers.Add(i.ToString());
                }
            }
            return View(fizzBuzzNumber);
        }

    }
}
 