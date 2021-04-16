using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro1 = ExecuteAbstractFactory.montarCarro("Luxo");
            Carro carro2 = ExecuteAbstractFactory.montarCarro("Popular");

            Console.ReadKey();
        }
    }
}
