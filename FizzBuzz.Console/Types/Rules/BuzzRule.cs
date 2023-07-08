using FizzBuzz.Console.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Console.Types.Rules
{
    public class BuzzRule : IFizzBuzzRule
    {
        public int Number { get; set; }

        public BuzzRule(int number)
        {
            Number = number;
        }

        public bool IsMatch()
        {
            return Number % Constants.BuzzDivisor == 0;
        }

        public string GetOutput()
        {
            return "Buzz";
        }
        
    }
}
