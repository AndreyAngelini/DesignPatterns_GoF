using System;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            EnderecoA endA = new EnderecoA();
            endA.Rua = "Rua XXX";
            endA.Numero = 120;

            EnderecoB endB = new EnderecoB();
            endB.UF = "SP";
            endB.Cidade = "São Paulo";

            ////////////////////////////////////////
            // Injeção de dependencia no construtor
            ////////////////////////////////////////
            //Empresa empA = new Empresa(endA);
            //empA.Codigo = 123;
            //empA.RazaoSocial = "Empresa de Teste - EndA";
            //
            //Empresa empB = new Empresa(endB);
            //empB.Codigo = 123;
            //empB.RazaoSocial = "Empresa de Teste - EndB";

            Console.ReadKey();

        }
    }
}
