using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criar fabricante 
            Fabricante fabricante = new Fabricante();

            // Permite que a classe Builder esteja pronta
            ICelular celularBuilder = null;

            // Criar telefone Android
            celularBuilder = new iPhoneBuilder();
            fabricante.Construtor(celularBuilder);
            Console.WriteLine("Um novo celular foi criado: {0}", celularBuilder.Celular.Nome);
            Console.WriteLine("Camera: {0}", celularBuilder.Celular.camera);
            Console.WriteLine("Bateria: {0}", celularBuilder.Celular.bateria);
            Console.WriteLine("Sistema: {0}", celularBuilder.Celular.sistema);
            Console.WriteLine("Tela: {0}", celularBuilder.Celular.tela);

            Console.ReadKey();
        }
    }
}
