using FizzBuzz.Console.Interfaces;
using FizzBuzz.Console.Types;
using FizzBuzz.Console.Types.Rules;
using System.Collections.Generic;

namespace FizzBuzz.Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("***FizzBuzz Game***");
            System.Console.Write("Enter the range start number: ");
            var rangeStartNumber = int.Parse(System.Console.ReadLine());
            System.Console.Write("Enter the range end number: ");
            var rangeEndNumber = int.Parse(System.Console.ReadLine());

            IFizzBuzzRule[] fizzBuzzRules = new IFizzBuzzRule[] {
                new FizzBuzzRule(),
                new FizzRule(),
                new BuzzRule(),
                new DefaultRule()
            };

            FizzBuzzGame fizzBuzzGame = new FizzBuzzGame(
                rangeStartNumber,
                rangeEndNumber,
                fizzBuzzRules
            );
            var fizzBuzzGameOutputs = fizzBuzzGame.GetRangeOutput();

            PrintFizzBuzzGameOutputs(fizzBuzzGameOutputs);

        }

        private static void PrintFizzBuzzGameOutputs(List<string> fizzBuzzGameOutputs)
        {
            System.Console.WriteLine("Game Output:");
            for (int i = 0; i < fizzBuzzGameOutputs.Count; i++)
            {
                if(i != 0 && i % 5 == 0) System.Console.WriteLine();

                System.Console.Write(fizzBuzzGameOutputs[i] + " ");
            }

            System.Console.WriteLine();
        }
    }
}
