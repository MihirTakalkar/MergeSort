using System;
using System.Collections.Generic;

namespace MergeSort
{
    class Program
    {
      
        static void Main(string[] args)
        {
            List<int> nums = new List<int>{ 38, 27, 43, 3, 9, 82, 10 };
            RecursiveSort<int> sort = new RecursiveSort<int>();

            nums = sort.MergeSort(nums);
        }
    }
}
