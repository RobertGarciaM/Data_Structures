using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure.Programs
{
    public static class Factorial
    {
        public static int factorialiterative(int n)
        {
            int fact = 1;
            for (int i = 1; i <= n; i++)
                fact = fact * i;
            return fact;
        }

        public static int factorialrecursive(int n)
        {
            if (n == 0)
                return 1;
            return factorialrecursive(n - 1) * n;
        }
    }
}
