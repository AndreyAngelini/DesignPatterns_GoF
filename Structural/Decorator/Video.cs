using System;

namespace Decorator
{
    public class Video : ItemBiblioteca
    {

        public string Diretor { get; set; }
        public string Titulo { get; set; }
        public int MinutosDuracao { get; set; }


        public Video(string diretor,
                     string titulo,
                     int minutosDuracao,
                     int numeroCopias)
        {
            this.Diretor = diretor;
            this.Titulo = titulo;
            this.MinutosDuracao = minutosDuracao;
            this.NumeroCopias = numeroCopias;
        }

        public override void Exibe()
        {
            Console.WriteLine("\nVideo: ----");
            Console.WriteLine("\nDiretor: {0}", this.Diretor);
            Console.WriteLine("\nTitulo: {0}", this.Titulo);
            Console.WriteLine("\nDuração em minutos: {0}", this.MinutosDuracao);
            Console.WriteLine("\nNúmero Cópias: {0}", this.NumeroCopias);
        }

    }
}
