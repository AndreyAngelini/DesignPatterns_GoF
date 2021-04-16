using System;
namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractClass abstrataA = new ConcreteClassA();
            abstrataA.TemplateMethod();

            AbstractClass abstrataB = new ConcreteClassB();
            abstrataB.TemplateMethod();

            Console.ReadKey();
        }
    }
}
