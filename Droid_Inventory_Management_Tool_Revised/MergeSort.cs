using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Droid_Inventory_Management_Tool_Revised
{
    public static class MergeSort
    {
        public static void Sort(IComparable[] inArray)
        {
            // Linq extention that allows for counting the number of non-null elements in this implementation
            int newSize = inArray.Count(e => e != null);
            IComparable[] comparableArray = new IComparable[newSize];
            comparableArray = ClearNulls(inArray, newSize);
            IComparable[] auxArray = new IComparable[newSize];

            sort(comparableArray, auxArray, 0, newSize - 1);
            for (int x = 0; x < newSize; ++x)
            {
                inArray[x] = comparableArray[x];
            }
        }
        private static void sort(IComparable[] comparableArray, IComparable[] auxArray, int low, int high) 
        {
            if (high <= low)
                return;
            int mid = low + (high - low) / 2;
            sort(comparableArray, auxArray, low, mid);
            sort(comparableArray, auxArray, mid + 1, high);
            merge(comparableArray, auxArray, low, mid, high);
        }
        private static void merge(IComparable[] comparableArray, IComparable[] auxArray, int low, int mid, int high) 
        {
            for (int k = low; k <= high; k++)
            {
                auxArray[k] = comparableArray[k];
            }

            int i = low;
            int j = mid + 1;

            for (int k = low; k <= high; k++)
            {
                if (i > mid)
                    comparableArray[k] = auxArray[j++];
                else if (j > high)
                    comparableArray[k] = auxArray[i++];
                else if (auxArray[j].CompareTo(auxArray[i]) == -1)
                    comparableArray[k] = auxArray[j++];
                else
                    comparableArray[k] = auxArray[i++];
            }
        }
        private static IComparable[] ClearNulls(IComparable[] inArray, int newSize)
        {
            IComparable[] comparableArray = new IComparable[newSize];
            for (int x = 0; x <= newSize-1; ++x)
            {
                comparableArray[x] = inArray[x];
            }
            return comparableArray;
        }
    }
}
