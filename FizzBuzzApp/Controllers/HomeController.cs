using FizzBuzzApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FizzBuzzApp.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            FizzBuzzNumber fizzBuzzNumber = new FizzBuzzNumber();
            fizzBuzzNumber.DayOfWeek = DateTime.Today.DayOfWeek.ToString();
            
            fizzBuzzNumber.DisplayNumbers = null;
            return View(fizzBuzzNumber);
        }
        [HttpPost]
        public IActionResult Index(FizzBuzzNumber fizzBuzzNumber)
        {
            if (fizzBuzzNumber.DayOfWeek == "wednesday")
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

        [HttpGet]
        public IActionResult Sai()
        {
            FizzBuzzNumber fizzBuzzNumber1 = new FizzBuzzNumber();
            fizzBuzzNumber1.Number = 100;
            return View(fizzBuzzNumber1);
        }

        [HttpPost]
        public IActionResult Sai(FizzBuzzNumber fizzBuzzNumber)
        {

            return View(fizzBuzzNumber);
        }


    }
}
 