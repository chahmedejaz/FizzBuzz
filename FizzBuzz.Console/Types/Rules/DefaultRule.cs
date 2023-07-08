using FizzBuzz.Console.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Console.Types.Rules
{
    internal class DefaultRule : IFizzBuzzRule
    {
        public int Number { get; set; }

        public DefaultRule(int number)
        {
            Number = number;
        }

        public bool IsMatch()
        {
            return true;
        }

        public string GetOutput()
        {
            return Number.ToString();
        }
        
    }
}
