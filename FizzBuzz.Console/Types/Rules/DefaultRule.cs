﻿using FizzBuzz.Console.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Console.Types.Rules
{
    public class DefaultRule : IFizzBuzzRule
    {

        public bool IsMatch(int number)
        {
            return !(number % Constants.FizzDivisor == 0 || number % Constants.BuzzDivisor == 0);
        }

        public string GetOutput()
        {
            return "";
        }
        
    }
}
