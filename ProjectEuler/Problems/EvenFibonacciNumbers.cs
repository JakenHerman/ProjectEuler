using System;
using System.Collections.Generic;

namespace ProjectEuler.Problems
{
    public class EvenFibonacciNumbers
    {
        public int sumOfEvenValuedTerms()
        {
            List<int> fibList = new List<int>();
            int i = 0;
            int sum = 0;
            while(fibonacci(i) < 4000000)
            {
                fibList.Add(fibonacci(i));
                i++;
            }
            foreach(int x in fibList)
            {
                if(x % 2 == 0)
                {
                    sum += x;   
                }
            }
            return sum;
        }

        public int fibonacci(int n){
            if(n <= 1)
            {
                return n;
            }
            return fibonacci(n - 2) + fibonacci(n - 1);
        }
    }
}
