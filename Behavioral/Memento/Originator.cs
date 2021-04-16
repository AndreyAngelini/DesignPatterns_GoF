using System;
namespace Memento
{
    public class Originator
    {
        private string state;
        public string State { 
            get { 
                return state;  
            }
            
            set { 
                state = value; 
                Console.WriteLine("State = " + state); 
            } 
        }

        public Memento CreateMemento()
        {
            return (new Memento(State));
        }
        public void SetMemento(Memento memento)
        {
            Console.WriteLine("Restaurando o estado.....");
            State = memento.State;
        }
    }
}
