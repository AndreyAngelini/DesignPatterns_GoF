using System;

namespace Bridge
{
    public class Filme : ICanal
    {
        const String canal = "Canal de filmes";
        public string Canal()
        {
            return "Sintonizado no Canal de Filmes";
        }

        public string Programa()
        {
            return "Você está assistindo - Os Vingadores";
        }
    }
}
