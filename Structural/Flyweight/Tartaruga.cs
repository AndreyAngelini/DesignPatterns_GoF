using System;

namespace Flyweight
{
    public abstract class Tartaruga
    {
        // Intrinsecas
        protected string condicao;
        protected string acao;
        
        // Extrinsecas
        public string Cor { get; set; }

        public abstract void Mostrar(string cor);

    }
}
