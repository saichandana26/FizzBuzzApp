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
            FizzBuzzWords fizzBuzzWords=new FizzBuzzWords();
            fizzBuzzWords.SetWords();
            fizzBuzzNumber.DisplayNumbers = new List<string>();
            for (int i = 1; i <= fizzBuzzNumber.Number; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    fizzBuzzNumber.DisplayNumbers.Add(fizzBuzzWords.ThreeAndFiveDivisible);
                }
                else if (i % 3 == 0)
                {
                    fizzBuzzNumber.DisplayNumbers.Add(fizzBuzzWords.ThreeDivisible);
                }
                else if (i % 5 == 0)
                {
                    fizzBuzzNumber.DisplayNumbers.Add(fizzBuzzWords.FiveDivisible);
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
 