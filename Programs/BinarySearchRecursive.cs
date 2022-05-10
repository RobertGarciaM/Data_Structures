using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure.Programs
{
    public static class BinarySearchRecursive
    {
        public static int binarySearchRecursive(int[] A, int key, int l, int r)
        {
            if (l > r)
                return -1;
            else
            {
                int mid = (l + r) / 2;
                if (key == A[mid])
                    return mid;
                else if (key < A[mid])
                    return binarySearchRecursive(A, key, l, mid - 1);
                else if (key > A[mid])
                    return binarySearchRecursive(A, key, mid + 1, r);
            }
            return -1;
        }
    }
}
