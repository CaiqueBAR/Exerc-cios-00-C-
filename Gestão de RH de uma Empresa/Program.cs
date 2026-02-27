using System;

class Program
{
    
    class Funcionario
    {
       
        private int matricula;
        private string nome;
        private string cargoAtual;
        private float salarioAtual;

       

        public void Cadastrar()
        {
            Console.WriteLine("Método cadastrar() executado.");
        }

        public void Consultar()
        {
            Console.WriteLine("Método consultar() executado.");
        }

        public void AtualizarSalario(float novoSalario)
        {
            Console.WriteLine($"Método atualizarSalario() executado. Novo salário: {novoSalario}");
        }

        public void ListarDependentes()
        {
            Console.WriteLine("Método listarDependentes() executado.");
        }
    }

    static void Main()
    {
        Funcionario f = new Funcionario();

        f.Cadastrar();
        f.Consultar();
        f.AtualizarSalario(4200.75f);
        f.ListarDependentes();

        Console.ReadKey();
    }
}