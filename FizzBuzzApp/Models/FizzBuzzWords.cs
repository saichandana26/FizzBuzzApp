namespace FizzBuzzApp.Models
{
	public class FizzBuzzWords
	{
		public string? ThreeDivisible { get; set; }
		public string? FiveDivisible { get; set; }
		public string? ThreeAndFiveDivisible { get; set; }
		public void SetWords()
		{
			string dayOfWeek = DateTime.Today.DayOfWeek.ToString();
			if (dayOfWeek == "Wednesday")
			{
				ThreeDivisible = "Wizz";
				FiveDivisible = "Wuzz";
				ThreeAndFiveDivisible = "WizzWuzz";
			}
			else
			{
				ThreeDivisible = "Fizz";
				FiveDivisible = "Buzz";
				ThreeAndFiveDivisible = "FizzBuzz";
			}
		}
	}
}
