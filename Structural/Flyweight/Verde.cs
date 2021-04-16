using System;

namespace Flyweight
{
    public class Verde : Tartaruga
    {

        public Verde()
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
