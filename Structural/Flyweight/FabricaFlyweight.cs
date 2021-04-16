using System;
using System.Collections.Generic;

namespace Flyweight
{
    public class FabricaFlyweight
    {
        private Dictionary<string, Tartaruga> listaTartarugas = new Dictionary<string, Tartaruga>();
        public Tartaruga GetTartaruga(string cor)
        {
            Tartaruga tartaruga = null;
            if (listaTartarugas.ContainsKey(cor))
            {
                Console.WriteLine("Tartaruga existente no dicionario");
                tartaruga = listaTartarugas[cor];
            }
            else
            {
                Console.WriteLine("Nova tartaruga será criada");
                switch (cor)
                {
                    case "azul": tartaruga = new Azul(); break;
                    case "verde": tartaruga = new Verde(); break;
                    case "vermelha": tartaruga = new Vermelha(); break;
                    case "laranja": tartaruga = new Laranja(); break;
                }
                listaTartarugas.Add(cor, tartaruga);
            }
            return tartaruga;
        }
    }
}
