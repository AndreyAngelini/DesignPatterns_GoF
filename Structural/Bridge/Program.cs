using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            SmartTV minhaTV = new SmartTV();
            Console.WriteLine("SELECIONE UM CANAL.");
            Console.WriteLine("1 - Filmes");
            Console.WriteLine("2 - Documentários");
            Console.WriteLine("3 - Culinária");

            ConsoleKeyInfo opcao = Console.ReadKey();

            switch (opcao.KeyChar)
            {
                case '1':
                    minhaTV.canalAtual = new Filme();
                    break;
                case '2':
                    minhaTV.canalAtual = new Documentario();
                    break;
                case '3':
                    minhaTV.canalAtual = new Culinaria();
                    break;

            }

            Console.WriteLine();
            minhaTV.ExibeCanalSintonizado();
            minhaTV.PlayTV();

            Console.ReadKey();

        }
    }
}
