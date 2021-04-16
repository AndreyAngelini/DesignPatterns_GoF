using System;

namespace DependencyInjection
{
    public class Empresa: IObejtoEnderecoInjDependencia
    {
        public int Codigo { get; set; }
        public string RazaoSocial { get; set; }

        ////////////////////////////////////////
        // Injeção de dependencia pela interface herdada (IObejtoEnderecoInjDependencia)
        ////////////////////////////////////////
        public void SetEndereco(IObjetoEndereco obj)
        {
            this.endereco = obj;
        }

        ////////////////////////////////////////
        // Injeção de dependencia na propriedade ( Mais usada )
        ////////////////////////////////////////
        IObjetoEndereco endereco;
        private IObjetoEndereco Endereco 
        {
            get 
            { 
                return endereco;  
            }
            
            set 
            {
                endereco = value;
            } 
        }

        ////////////////////////////////////////
        // Injeção de dependencia no construtor
        ////////////////////////////////////////
        //public Empresa(IObjetoEndereco objeto) 
        //{
        //    this.Endereco = objeto;
        //}

        ////////////////////////////////////////
        // Injeção de dependencia por servico localizador
        ////////////////////////////////////////
        public Empresa() 
        {
            this.Endereco = Localizador.getEndereco();
        }
    }
}
