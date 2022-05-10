using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure.Programs
{
    public static  class QuickSort
    {
        public static void quickSort(int[] A, int low, int high)
        {
            if (low < high)
            {
                int pi = partition(A, low, high);
                quickSort(A, low, pi - 1);
                quickSort(A, pi + 1, high);
            }
        }

        public static int partition(int[] A, int low, int high)
        {
            int pivot = A[low];
            int i = low + 1;
            int j = high;
            do
            {
                while (i <= j && A[i] <= pivot)
                    i = i + 1;
                while (i <= j && A[j] > pivot)
                    j = j - 1;
                if (i <= j)
                    swap(A, i, j);

            } while (i < j);
            swap(A, low, j);
            return j;
        }

        public static void swap(int[] A, int i, int j)
        {
            int temp = A[i];
            A[i] = A[j];
            A[j] = temp;
        }

        public static void display(int[] A, int n)
        {
            for (int i = 0; i < n; i++)
                Console.Write(A[i] + " ");
            Console.WriteLine();
        }

    }
}
