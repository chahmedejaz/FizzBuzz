﻿using FizzBuzz.Console.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Console.Types
{
    internal class FizzBuzzGame : IFizzBuzzGame
    {
        public int RangeStartNumber { get; set; }
        public int RangeEndNumber { get; set; }
        public IFizzBuzzRule[] Rules { get; set; }

        public FizzBuzzGame(int rangeStartNumber, int rangeEndNumber, IFizzBuzzRule[] rules)
        {
            RangeStartNumber = rangeStartNumber;
            RangeEndNumber = rangeEndNumber;
            Rules = rules;
        }

        public List<string> GetRangeOutput()
        {
            List<string> rangeOutput = new List<string>();
            for(int number = RangeStartNumber; number <= RangeEndNumber; number++) 
            {
                rangeOutput.Add(OutputByRule(number));
            }

            return rangeOutput;
        }

        private string OutputByRule(int number)
        {
            foreach (var rule in Rules)
            {
                if (rule.IsMatch(number))
                {
                    string output = rule.GetOutput();
                    return output == "" ? number.ToString() : output;
                }
            }
            return "";
        }
    }
}
