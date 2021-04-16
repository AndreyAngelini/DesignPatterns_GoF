using System;

namespace State
{
    public class ConcreteStateB : State
    {
        public ConcreteStateB()
        {
        }

        public override void Handle(Contexto contexto)
        {
            contexto.State = new ConcreteStateA();
        }
    }
}
