using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure.Programs
{
    public static class SumofNumbers
    {
        public static int sumn(int n)
        {
            return n * (n + 1) / 2;
        }

        public static int sumniteration(int n)
        {
            int total = 0;
            int i = 1;
            while (i <= n)
            {
                total = total + i;
                i = i + 1;
            }
            return total;
        }

        public static int sumnrecursion(int n)
        {
            if (n == 0)
                return 0;
            return sumnrecursion(n - 1) + n;
        }       
    }
}
