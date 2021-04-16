using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class BolaSemSingleton
    {
        public BolaSemSingleton()
        {
            Console.WriteLine("BolaSemSingleton: Bola em jogo!");
        }

        public void Menasgem(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
