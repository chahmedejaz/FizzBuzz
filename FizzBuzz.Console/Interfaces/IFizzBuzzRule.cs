using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Console.Interfaces
{
    public interface IFizzBuzzRule
    {
        int Number { get; set; }
        bool IsMatch();
        string GetOutput();
    }
}
