using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure.Programs
{
    public static class Recursion
    {
        public static void calculateIterative(int n)
        {
            while (n > 0)
            {
                int k = n * n;
                Console.WriteLine(k);
                n = n - 1;
            }
        }

        public static void calculateRecursive(int n)
        {
            if (n > 0)
            {
                int k = n * n;
                Console.WriteLine(k);
                calculateRecursive(n - 1);
            }
        }

        public static void tailRecursion(int n)
        {
            if (n > 0)
            {
                int k = n * n;
                Console.WriteLine("TR" + k);
                tailRecursion(n - 1);
            }
        }

        public static void headRecursion(int n)
        {
            if (n > 0)
            {
                headRecursion(n - 1);
                int k = n * n;
                Console.WriteLine("HR" + k);
            }
        }

        public static void treeRecursion(int n)
        {
            if (n > 0)
            {
                treeRecursion(n - 1);
                int k = n * n;
                Console.WriteLine("Tree" + k);
                treeRecursion(n - 1);
            }
        }

    }
}
