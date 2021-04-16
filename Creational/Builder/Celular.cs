using System;

namespace Builder
{
    public class Celular
    {
        string nomeCelular = "";
        public Celular(string nome) 
        {
            this.nomeCelular = nome;
        }
        public string Nome { 
            get
            { 
                return this.nomeCelular; 
            }
            set 
            {
                this.nomeCelular = value;
            } 
        }

        public string tela { get; set; }
        public string bateria { get; set; }
        public string sistema { get; set; }
        public string camera { get; set; }
    }
}
