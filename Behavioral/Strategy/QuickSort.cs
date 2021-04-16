using System;
using System.Collections.Generic;


namespace Strategy
{
    public class QuickSort : SortStrategy
    {
        public QuickSort()
        {
        }

        public override void Sort(List<string> list)
        {
            list.Sort();
            Console.WriteLine("QuickSorted List!");
        }
    }
}
