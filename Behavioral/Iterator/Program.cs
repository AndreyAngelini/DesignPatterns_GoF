using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteAggregate concreteAggregate_A = new ConcreteAggregate();
            concreteAggregate_A[0] = "Item A";
            concreteAggregate_A[1] = "Item B";
            concreteAggregate_A[2] = "Item C";
            concreteAggregate_A[3] = "Item D";

            Iterator iterator_A = concreteAggregate_A.CreateIterator();
            Console.WriteLine("Iteragindo com a coleção: ");

            object objItem = iterator_A.First();
            int x = 0;

            while(objItem != null)
            {
                Console.WriteLine(objItem);
                if (x == 2)
                {
                    objItem = iterator_A.CurrentItem();
                }

                objItem = iterator_A.Next();
                x++;
            }

            Console.ReadKey();

        }
    }
}
