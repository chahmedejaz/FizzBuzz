using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Tests
{
    internal interface IFizzBuzzRuleTest
    {
        bool ShouldMatch(int number);
        bool ShouldMatchDivisor(int divisor);
    }
}
