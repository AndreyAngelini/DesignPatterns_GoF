using System;
namespace Mediator
{
    public abstract class Colega
    {
        protected Mediador mediador;
        public Colega(Mediador med)
        {
            this.mediador = med;
        }
    }
}