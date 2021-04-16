using System;

namespace Bridge
{
    public class Culinaria : ICanal
    {
        public string Canal()
        {
            return "Sintonizado no Canal de Culinária";
        }

        public string Programa()
        {
            return "Você está assistindo os - Receita de Bolo de Laranja";
        }
    }
}
