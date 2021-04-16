using System;
namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("---# Design Pattern Flyweight ");
            FabricaFlyweight fabrica = new FabricaFlyweight();
            string cor = string.Empty;
            Tartaruga tartaruga;

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Qual tartaruga enviar para a tela: ");

                cor = Console.ReadLine();
                tartaruga = fabrica.GetTartaruga(cor); // Verifica se existe usa, senão existir cria
                tartaruga.Mostrar(cor);

                Console.WriteLine();
                Console.WriteLine("------------------------------------------------- ");
            }



        }
    }
}
