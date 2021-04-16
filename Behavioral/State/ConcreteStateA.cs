using System;

namespace State
{
    public class ConcreteStateA : State
    {
        public ConcreteStateA()
        { 
        }
        public override void Handle(Contexto contexto)
        {
            contexto.State = new ConcreteStateB();

        }
    }
}
