using System;

namespace Memento
{
    public class Memento
    {
        private string _state;
        public Memento(string state)
        {
            this._state = state;
        }
        public string State
        {
            get
            {
                return _state;
            }

            set
            {
                _state = value;
                Console.WriteLine("State = " + _state);
            }
        }

        
    }
}
