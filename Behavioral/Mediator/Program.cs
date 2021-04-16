using System;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            MediadorConcreto mc = new MediadorConcreto();

            ColegaConcreto1 cc1 = new ColegaConcreto1(mc);
            ColegaConcreto2 cc2 = new ColegaConcreto2(mc);

            mc.Colega1 = cc1;
            mc.Colega2 = cc2;

            cc1.Enviar("Como vc está?");
            cc2.Enviar("Bem, obrigado!");

            Console.ReadKey();

        }
    }
}
