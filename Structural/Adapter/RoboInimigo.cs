using System;

namespace Adapter
{
    // Classe Adaptee = Classe que será adaptada
    public class RoboInimigo
    {
        Random gerador = new Random();

        public void EsmagarComMaos()
        {
            int danoAtaque = this.gerador.Next(10) + 1;
            Console.WriteLine("O Robô inimigo causou {0} de dano com o ataque Esmagar com as mãos!", danoAtaque);
        }

        public void AndarFrente()
        {
            int movimento = this.gerador.Next(5) + 1;
            Console.WriteLine("O Robô inimigo andou {0} passos para frente!", movimento);
        }

        public void ReagirContraHumano(string piloto)
        {
            Console.WriteLine("O Robô inimigo vai contra {0}!", piloto);
        }
    }
}
