using System;

namespace Adapter
{
    public class TanqueInimigo : IAtaqueInimigo
    {
        Random gerador = new Random();
        public void ArmaFogo()
        {
            int danoAtaque = this.gerador.Next(10) + 1;
            Console.WriteLine("Tanque inimigo fez {0} de dano!",  danoAtaque);
        }

        public void Movimenta()
        {
            int movimento = this.gerador.Next(5) + 1;
            Console.WriteLine("Tanque inimigo andou {0} passos!", movimento);
        }

        public void Pilotar(string piloto)
        {
            Console.WriteLine("{0} está no comando do tanque!", piloto);
        }
    }
}
