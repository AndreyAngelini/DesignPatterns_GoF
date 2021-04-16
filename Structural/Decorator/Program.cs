using System;
namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Livro livro = new Livro("João","Design Patterns",10);
            livro.Exibe();

            Video video = new Video("Rodrigo", "Video aulas", 120, 3);
            video.Exibe();

            // Vou emprestar um video e mostrar na tela
            Console.WriteLine("\nEmprestando vídeo:");
            Emprestado emprestado = new Emprestado(video);
            emprestado.EmprestarItem("Carlos");
            emprestado.EmprestarItem("Maria");
            emprestado.Exibe();

            Console.WriteLine("\nDevolvendo vídeo:");
            emprestado.DevolverItem("Carlos");
            emprestado.Exibe();
            Console.ReadKey();



        }
    }
}
