using System;
using System.Collections.Generic;

namespace Observer
{
    public abstract class Assunto
    {
        private List<Observador> observadores = new List<Observador>();
        public void Anexar(Observador observador)
        {
            this.observadores.Add(observador);
        }
        public void Desanexar(Observador observador)
        {
            this.observadores.Remove(observador);
        }

        public void Notificar()
        {
            foreach (Observador item in this.observadores)
            {
                item.Update();
            }
        
        }

    }
}
