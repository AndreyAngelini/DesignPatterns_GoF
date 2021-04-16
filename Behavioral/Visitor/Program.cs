using System;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            ObjectStructure o = new ObjectStructure();
            o.Anexar(new ConcreteElementA());
            o.Anexar(new ConcreteElementB());

            ConcreteVisitor1 v1 = new ConcreteVisitor1();
            ConcreteVisitor2 v2 = new ConcreteVisitor2();
            o.Accept(v1);
            o.Accept(v2);

            Console.ReadKey();

        }
    }
}
