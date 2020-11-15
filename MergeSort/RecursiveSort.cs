using System;
using System.Collections.Generic;
using System.Text;

namespace MergeSort
{
   


    class RecursiveSort<T> where T:IComparable
    {
        public List<T> MergeSort(List<T> list)
        {
            if (list.Count < 2)
            {
                return list;
            }
            int midpoint = list.Count / 2;
            List<T> leftList = new List<T>();
            List<T> rightList = new List<T>();

            for (int i = 0; i < midpoint; i++)
            {
                leftList.Add(list[i]);
            }

            for (int i = midpoint; i < list.Count; i++)
            {
                rightList.Add(list[i]);
            }
        
            return Merge(MergeSort(leftList), MergeSort(rightList));
        }

         List<T> Merge(List<T> leftList, List<T> rightList)
        {
            List<T> list = new List<T>();
            int l = 0;
            int r = 0;
            while (r < rightList.Count && l < leftList.Count)
            {
                if (leftList[l].CompareTo(rightList[r]) < 0)
                {
                    list.Add(leftList[l]);
                    l++;
                }

                else
                {
                    list.Add(rightList[r]);
                    r++;
                }
            }
            for (int i = l; i < leftList.Count; i++)
            {
                list.Add(leftList[i]);
            }

            for (int i = r; i < rightList.Count; i++)
            {
                list.Add(rightList[i]);
            }

            return list;
        }

    }
}
