using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            TanqueInimigo RX2018 = new TanqueInimigo();
            RoboInimigo R2D2 = new RoboInimigo();

            // Processo de adaptação 
            IAtaqueInimigo roboAdapter = new RoboInimigoAdaptador(R2D2);

            Console.WriteLine(" === ROBO === ");
            R2D2.ReagirContraHumano("Rodrigo");
            R2D2.AndarFrente();
            R2D2.EsmagarComMaos();
            
            Console.WriteLine(" === TANQUE === ");
            RX2018.Pilotar("João");
            RX2018.Movimenta();
            RX2018.ArmaFogo();

            // O Robo adaptado tem os mesmos metodos do tanque, porem os resultados são iguais os do Robo 
            Console.WriteLine(" === ROBO ADAPTADO === ");
            roboAdapter.Pilotar("José");
            roboAdapter.Movimenta();
            roboAdapter.ArmaFogo();

            Console.ReadKey();

        }
    }
}
