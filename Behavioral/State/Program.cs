using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            Contexto contexto = new Contexto(new ConcreteStateA());
            contexto.Request();
            contexto.Request();
            contexto.Request();
            contexto.Request();
            Console.ReadKey();
        }
    }
}
