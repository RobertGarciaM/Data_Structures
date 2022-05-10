using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure.Programs
{
    public static class LinearSearch
    {
        public static int linearSearch(int[] A, int n, int key)
        {
            int index = 0;
            while (index < n)
            {
                if (A[index] == key)
                    return index;
                index = index + 1;
            }
            return -1;
        }
    }
}
