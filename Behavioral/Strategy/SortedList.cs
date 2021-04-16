using System;
using System.Collections.Generic;
namespace Strategy
{
    public class SortedList
    {
        private List<string> _list = new List<string>();
        private SortStrategy _sortStrategy;
        public void SetSortStrategy(SortStrategy sortstrategy)
        {
            this._sortStrategy = sortstrategy;
        }


        public void Add(string nome)
        {
            _list.Add(nome);
        }
        public void Sort()
        {
            this._sortStrategy.Sort(_list);
            foreach (string name in _list)
            {
                Console.WriteLine(" " + name);
            }
            Console.WriteLine();
        }

    }
}
