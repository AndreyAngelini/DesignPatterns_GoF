using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            AssuntoConcreto assuntoConcreto = new AssuntoConcreto();
            assuntoConcreto.Anexar(new ObservadorConcreto(assuntoConcreto, "assuntoX"));
            assuntoConcreto.Anexar(new ObservadorConcreto(assuntoConcreto, "assuntoY"));
            assuntoConcreto.Anexar(new ObservadorConcreto(assuntoConcreto, "assuntoZ"));

            assuntoConcreto.EstadoAssunto = "ABC";
            assuntoConcreto.Notificar();
            Console.ReadKey();
        }
    }
}
