﻿using System;
using System.ComponentModel.DataAnnotations;

namespace FizzBuzzApp.Models
{
    public class FizzBuzzNumber
    {
        [Required(ErrorMessage = "Value is required!")]
        [Range(1, 1000, ErrorMessage = "Please enter value between 1 and 1000")]
        public int Number { get; set; }
        public List<string>? DisplayNumbers { get; set; }

        public string? DayOfWeek { get; set; }

        public string? ThreeDivisible { get; set; }
        public string? FiveDivisible { get; set; }

        public string? ThreeAndFiveDivisible { get; set; }

    }
}
