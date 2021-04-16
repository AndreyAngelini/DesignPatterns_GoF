using System;
namespace DependencyInjection
{
    public class EnderecoA: IObjetoEndereco
    {
        public string Rua { get; set; }
        public int Numero { get; set; }
    }
}