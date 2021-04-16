using System;

namespace Observer
{
    public class ObservadorConcreto : Observador
    {
        public string Nome { get; set; }
        public string EstadoObservador { get; set; }
        public AssuntoConcreto Assunto { get; set; }

        public ObservadorConcreto(AssuntoConcreto assunto, string nome)
        {
            this.Assunto = assunto;
            this.Nome = nome;
        }

        public override void Update()
        {
            this.EstadoObservador = this.Assunto.EstadoAssunto;
            Console.WriteLine("Observador {0}´s seu novo estado é: {1} ", this.Nome, this.EstadoObservador);
        }
        
    }
}
