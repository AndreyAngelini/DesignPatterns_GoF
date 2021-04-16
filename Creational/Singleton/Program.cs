using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton jogador1 = Singleton.GetInstancia;
            //BolaSemSingleton jogador1 = new BolaSemSingleton();
            jogador1.Menasgem("jogador 1: A bola está comigo.");

            Singleton jogador2 = Singleton.GetInstancia;
            //BolaSemSingleton jogador2 = new BolaSemSingleton();
            jogador2.Menasgem("jogador 2: recebeu a bola.");

            Singleton jogador3 = Singleton.GetInstancia;
            //BolaSemSingleton jogador3 = new BolaSemSingleton();
            jogador3.Menasgem("jogador 3: recebeu o lançamento na linha de fundo.");

            Console.ReadKey();
        }
    }
}
