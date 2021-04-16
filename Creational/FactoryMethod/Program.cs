using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            FactoryMethod factoryMethod = new FactoryMethod();

            Console.WriteLine("Escolha o personagem:");
            Console.WriteLine("Liu Kang - Scorpion - Sub-Zero");
            string escolha = Console.ReadLine();
            IPersonagem personagem = factoryMethod.escolherPersonagem(escolha);

            Console.WriteLine("");
            Console.WriteLine("Você escolheu:");
            personagem.Escolhido();

            Console.ReadKey();
        }
    }
}
