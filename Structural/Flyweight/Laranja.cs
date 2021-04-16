using System;

namespace Flyweight
{
    public class Laranja : Tartaruga
    {

        public Laranja()
        {
            this.condicao = "tartaruga dentro do casco, ";
            this.acao = "rodando no chão - ";
        }

        public override void Mostrar(string qualcor)
        {
            this.Cor = qualcor;
            Console.WriteLine(condicao + acao + Cor.ToUpper());
        }
    }
}
