using System;

namespace AbstractFactory
{
    public class ExecuteAbstractFactory
    {
        public static Carro montarCarro(string tipo)
        {
            CarroAbstractFactory carroAbstractFactory = null;
            switch(tipo)
            {
                case "Popular": 
                    carroAbstractFactory = new CarroPopularFactory();
                    break;
                case "Luxo": 
                    carroAbstractFactory = new CarroLuxoFactory();
                    break;
                default:
                    break;
            }

            Carro carro = new Carro();
            carro.roda = carroAbstractFactory.montarRoda();
            carro.som = carroAbstractFactory.montarSom();
            return carro;
        }
    }
}