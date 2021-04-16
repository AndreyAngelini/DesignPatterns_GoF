using System;
using System.Collections.Generic;

namespace Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            String romano = "MCMXXVIII";
            Contexto contexto = new Contexto(romano);

            List<Expressao> listaExpressao = new List<Expressao>();
            listaExpressao.Add(new MilharesExpressao());
            listaExpressao.Add(new CentenasExpressao());
            listaExpressao.Add(new DezenasExpressao());
            listaExpressao.Add(new UnidadeExpressao());

            foreach (Expressao expressao in listaExpressao)
            {
                expressao.Interpretador(contexto);
            }

            Console.WriteLine("{0} = {1}", romano, contexto.Output);
            Console.ReadKey();



        }
    }
}
