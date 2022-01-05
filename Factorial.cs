using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataStructures
{
    public class Factorial
    {
        public int Fact(int n)
        {
            if(n==1) return 1;

            return n*Fact(n-1);
        }

        public int FactLoop(int n)
        {
            var factorial = 1;
            for (int i = n; i > 0; i--)
            {
                factorial = factorial * i;
            }
            return factorial;
        }
    }
}