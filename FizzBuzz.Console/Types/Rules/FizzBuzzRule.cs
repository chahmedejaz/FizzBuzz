using FizzBuzz.Console.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Console.Types.Rules
{
    public class FizzBuzzRule : IFizzBuzzRule
    {
        public int Number { get; set; }

        public FizzBuzzRule(int number)
        {
            Number = number;
        }

        public bool IsMatch()
        {
            return Number % Constants.FizzDivisor == 0 && Number % Constants.BuzzDivisor == 0;
        }

        public string GetOutput()
        {
            return "FizzBuzz";
        }

    }
}
