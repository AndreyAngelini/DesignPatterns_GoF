using System;

namespace Interpreter
{
    public class Contexto
    {
        public string Input { get; set; }
        public string Output { get; set; }

        public Contexto(string input)
        {
            this.Input = input;
        }

    }
}
