using System;

namespace Visitor
{
    public class ConcreteVisitor1 : Visitor
    {
        public override void VisitConcreteElementA(ConcreteElementA concreteElementA)
        {
            Console.WriteLine("ConcreteVisitor1: {0} visitado por: {1}", concreteElementA.GetType().Name, this.GetType().Name);
        }

        public override void VisitConcreteElementB(ConcreteElementB concreteElementB)
        {
            Console.WriteLine("ConcreteVisitor1: {0} visitado por: {1}", concreteElementB.GetType().Name, this.GetType().Name);
        }
    }
}
