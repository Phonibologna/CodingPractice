using System;
using System.Collections.Generic;
using System.Linq;

namespace Sorting_Things
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] unsorted = { 35, 625, 1, 2, 57, 9, 40, 57 };
            List<int> unsortedList = new List<int>();
            unsortedList.Add(35);
            unsortedList.Add(625);
            unsortedList.Add(1);
            unsortedList.Add(2);
            unsortedList.Add(57);
            unsortedList.Add(9);
            unsortedList.Add(40);
            unsortedList.Add(57);

            int[] sorted = BSort(unsorted);
            List<int> sortedList = MergeSort(unsortedList);

            foreach(int i in sorted)
            {
                Console.WriteLine(i);
            }
            foreach(int j in sortedList)
            {
                Console.WriteLine(j);
            }
            Console.ReadKey();
        }
        public static int[] BSort(int[] toSort)
        {
            int temp;
            bool has_swapped = false;
            do
            {
                has_swapped = false;
                for (int i = 0; i < toSort.Length - 1; i++)
                {
                    if (toSort[i] > toSort[i + 1])
                    {
                        temp = toSort[i + 1];
                        toSort[i + 1] = toSort[i];
                        toSort[i] = temp;
                        has_swapped = true;
                    }
                }
            } while (has_swapped == true);
            return toSort;
        }

        public static List<int> MergeSort(List<int> toSort)
        {
            if (toSort.Count == 1) { return toSort; }

            int mid = toSort.Count / 2;

            List<int> left = new List<int>();
            List<int> right = new List<int>();

            for(int i = 0; i < mid; i++)
            {
                left.Add(toSort[i]);
            }
            for(int j = mid; j < toSort.Count; j++)
            {
                right.Add(toSort[j]);
            }
            left = MergeSort(left);
            right = MergeSort(right);
            return Merge(left, right);
        }

        public static List<int> Merge(List<int> left, List<int> right)
        {
            List<int> merged = new List<int>();

            while(left.Count > 0 || right.Count > 0)
            {
                if(left.Count > 0 && right.Count > 0)
                {
                    if(left.First() <= right.First())
                    {
                        merged.Add(left.First());
                        left.Remove(left.First());
                    }
                    else
                    {
                        merged.Add(right.First());
                        right.Remove(right.First());
                    }
                }
                else if (left.Count > 0)
                {
                    merged.Add(left.First());
                    left.Remove(left.First());
                }
                else if (right.Count > 0)
                {
                    merged.Add(right.First());

                    right.Remove(right.First());
                }
            }
            return merged;
        }
        
    }

   

    
    
}
