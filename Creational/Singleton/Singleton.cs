using System;

namespace Singleton
{
    public sealed class Singleton
    {
        private static Singleton instancia = null;
        public static Singleton GetInstancia 
        { 
            get 
            {
                // Garante apenas uma instância
                if (instancia == null)
                {
                    instancia = new Singleton();
                    Console.WriteLine("Bola em jogo!");
                }

                return instancia;
            }  
        }

        public void Menasgem(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
