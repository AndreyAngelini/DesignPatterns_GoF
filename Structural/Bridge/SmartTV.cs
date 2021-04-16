using System;

namespace Bridge
{
    public class SmartTV
    {
        // Nesse ponto temos a ponte (Bridge).
        // No Program.cs chama essa interface e passamos para ela o objeto.
        public ICanal canalAtual { get; set; }
        public void ExibeCanalSintonizado()
        {
            if (canalAtual != null)
            {
                Console.WriteLine(canalAtual.Canal());
            }
            else
            {
                Console.WriteLine("Por favor, selecione um canal!");
            }
        }

        public void PlayTV()
        {
            if (canalAtual != null)
            {
                Console.WriteLine(canalAtual.Programa());
            }
            else
            {
                Console.WriteLine("Por favor, selecione um canal para assistir um programa!");
            }
        }
    }
}
