using System;

namespace AbstractFactory
{
    public class CarroLuxoFactory : CarroAbstractFactory
    {
        public override Roda montarRoda()
        {
            return new RodaLigaLeve();
        }

        public override Som montarSom()
        {
            return new BluetoothPlayer();
        }
    }
}
