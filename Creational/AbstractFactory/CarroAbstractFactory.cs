using System;

namespace AbstractFactory
{
    public abstract class CarroAbstractFactory
    {
        public abstract Roda montarRoda();
        public abstract Som montarSom();
    }
}
