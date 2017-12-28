using System;
using ProjectEuler.Problems;

namespace ProjectEuler
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            EvenFibonacciNumbers efn = new EvenFibonacciNumbers();
            Console.WriteLine(efn.sumOfEvenValuedTerms());
        }
    }
}
