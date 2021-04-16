using System;
namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {

            FuncionarioPermanente funcPermanente = new FuncionarioPermanente();
            funcPermanente.Nome = "João";
            funcPermanente.Idade = 30;
            funcPermanente.Tipo = "Permanente";

            FuncionarioPermanente cloneFuncPermanente = (FuncionarioPermanente)funcPermanente.Clone();
            cloneFuncPermanente.Nome = "Carlos";
            cloneFuncPermanente.Tipo = "Contrato de 30 dias";

            Console.WriteLine("Detalhe do Funcionário Permanente");
            Console.WriteLine("Nome: {0}; Idade: {1}; Tipo: {2}", funcPermanente.Nome, funcPermanente.Idade, funcPermanente.Tipo);
            Console.WriteLine("Detalhe do Funcionário Permanente Clonado");
            Console.WriteLine("Nome: {0}; Idade: {1}; Tipo: {2}", cloneFuncPermanente.Nome, cloneFuncPermanente.Idade, cloneFuncPermanente.Tipo);

            Console.ReadKey();
        }
    }
}
