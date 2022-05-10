using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure.Programs
{
    public static class InsertionSort
    {
        public static void insertionSort(int[] A, int n)
        {
            for (int i = 1; i < n; i++)
            {
                int temp = A[i];
                int position = i;
                while (position > 0 && A[position - 1] > temp)
                {
                    A[position] = A[position - 1];
                    position = position - 1;
                }
                A[position] = temp;
            }
        }

        public static void display(int[] A, int n)
        {
            for (int i = 0; i < n; i++)
                Console.Write(A[i] + " ");
            Console.WriteLine();
        }
    }
}
