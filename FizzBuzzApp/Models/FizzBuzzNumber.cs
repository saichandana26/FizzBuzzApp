namespace FizzBuzzApp.Models
{
    public class FizzBuzzNumber
    {
        public int Number { get; set; }
        public List<string>? DisplayNumbers { get; set; }

        public string? DayOfWeek { get; set; }

        public string? ThreeDivisible { get; set; }
        public string? FiveDivisible { get; set; }

        public string? ThreeAndFiveDivisible { get; set; }

    }
}
