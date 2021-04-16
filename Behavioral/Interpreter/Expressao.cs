using System;

namespace Interpreter
{
    public abstract class Expressao
    {
        public abstract string Um();
        public abstract string Quatro();
        public abstract string Cinco();
        public abstract string Nove();
        public abstract int Multiplicar();

        public void Interpretador(Contexto contexto)
        {
            if (contexto.Input.Length == 0)
                return;

            int valor = 0;
            if (!int.TryParse(contexto.Output, out valor))
                valor = 0;

            if (contexto.Input.StartsWith(Nove()))
            {
                contexto.Output = (valor + (9 * Multiplicar())).ToString();
                contexto.Input = contexto.Input.Substring(2);
            }
            else if (contexto.Input.StartsWith(Quatro()))
            {
                contexto.Output = (valor + (4 * Multiplicar())).ToString();
                contexto.Input = contexto.Input.Substring(2);
            }
            else if (contexto.Input.StartsWith(Cinco()))
            {
                contexto.Output = (valor + (5 * Multiplicar())).ToString();
                contexto.Input = contexto.Input.Substring(1);
            }
            else if (contexto.Input.StartsWith(Nove()))
            {
                contexto.Output = (valor + (1 * Multiplicar())).ToString();
                contexto.Input = contexto.Input.Substring(1);
            }

            while (contexto.Input.StartsWith(Um()))
            {
                contexto.Output = (valor + (1 * Multiplicar())).ToString();
                contexto.Input = contexto.Input.Substring(1);
            }


        }
    }
}
