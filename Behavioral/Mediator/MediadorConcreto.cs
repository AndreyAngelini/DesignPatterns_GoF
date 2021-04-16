using System;

namespace Mediator
{
    public class MediadorConcreto : Mediador
    {
        private ColegaConcreto1 colegaConcreto1;
        private ColegaConcreto2 colegaConcreto2;
        public ColegaConcreto1 Colega1 { set { colegaConcreto1 = value; } }
        public ColegaConcreto2 Colega2 { set { colegaConcreto2 = value; } }

        public override void Enviar(string mensagem, Colega colega)
        {
            if (colega == colegaConcreto1)
                colegaConcreto2.Notificar(mensagem);
            else
                colegaConcreto1.Notificar(mensagem);

        }
    }
}
