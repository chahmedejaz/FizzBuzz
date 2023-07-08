using FizzBuzz.Console.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Console.Types.Rules
{
    public class FizzRule : IFizzBuzzRule
    {
        public int Number { get; set; }

        public FizzRule(int number)
        {
            Number = number;
        }

        public bool IsMatch()
        {
            return Number % Constants.FizzDivisor == 0;
        }

        public string GetOutput()
        {
            return "Fizz";
        }
        
    }
}
