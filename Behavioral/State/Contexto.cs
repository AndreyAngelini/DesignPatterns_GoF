using System;
namespace State
{
    public class Contexto
    {
        private State _state;
        public State State 
        {
            get { return _state; }
            set {
                _state = value;
                Console.WriteLine("Estado: " + _state.GetType().Name);
            } 
        }
        public Contexto(State state)
        {
            this._state = state;
        }

        public void Request()
        {
            _state.Handle(this);
        }
    }
}