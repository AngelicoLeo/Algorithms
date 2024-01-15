using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritms
{
    public static class Fibonacci
    {
        public static int Climbing(int n)
        {
            // in Fibonacci we have 0 1 1 2 3 5 .. So less than 3 stairs we have it won number of ways

            if (n < 3) return n;

            
            int a = 1;
            int b = 1;
            int c = 0;

            while (n>1)
            {
                c = a + b;
                a = b;
                b = c;
                n--;
            }
            return c;

        }
    }
}
