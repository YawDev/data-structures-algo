using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataStructures
{
    public class Fibonacci
    {
        public  int n { get; set; }
        public long[] fibArray;

        public long CalculateFib(int n)
        {
            if(n == 1)
                return 1;
            if(n == 0 )
                return 0;
            if(fibArray[n] != 0)
                return fibArray[n];

            var fibValue =  (CalculateFib(n-1))+(CalculateFib(n-2));

            fibArray[n] = fibValue;

            return fibValue;
        }
    }
}