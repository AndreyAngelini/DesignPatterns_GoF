using System;

namespace Bridge
{
    public class Documentario : ICanal
    {
        const String canal = "Canal de filmes";
        public string Canal()
        {
            return "Sintonizado no Canal de Documentários";
        }

        public string Programa()
        {
            return "Você está assistindo os - A Origem de Tudo";
        }
    }
}
