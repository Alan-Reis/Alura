using ByteBank.Fucionario;
using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionarios();

            /*
            Cliente cliente = new Cliente();
           
            Console.Write("Digite o nome do titular: ");
            cliente.Nome = Console.ReadLine();
            Console.Write("Digite o CPF do titular: ");
            cliente.CPF = Console.ReadLine();
            Console.Write("Digite a profissão do titular: ");
            cliente.Profissao = Console.ReadLine();

            Console.Write("Digite a agência: ");
            int ag = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ditege a conta: ");
            int cc = Convert.ToInt32(Console.ReadLine());

            ContaCorrente conta = new ContaCorrente(ag, cc);

            conta.Titular = cliente;

            

            conta.Saldo = 100.00; //Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(conta.Titular.Nome);
            Console.WriteLine(conta.Titular.CPF);
            Console.WriteLine(conta.Titular.Profissao);
            Console.WriteLine(conta.Agencia);
            Console.WriteLine(conta.Conta);
            Console.WriteLine(conta.Saldo);

            Console.Write("Digite o valor do saque: ");
            conta.Sacar(Convert.ToDouble(Console.ReadLine()));
            
            Console.WriteLine("Novo saldo: " + conta.Saldo);

            Console.Write("Digite o valor do depósito: ");
            conta.Depositar(Convert.ToDouble(Console.ReadLine()));

            Console.WriteLine("Novo saldo: " + conta.Saldo);

            //Criar conta somente para realizar o metodo transferir
            ContaCorrente c2 = new ContaCorrente(ag, cc);
            
            Console.Write("Digite o valor da tranferência: ");
            conta.Transferir(Convert.ToDouble(Console.ReadLine()), c2);

            Console.WriteLine("Novo saldo: " + conta.Saldo);

            Console.Write("Total de clientes: ");
            Console.WriteLine(ContaCorrente.GetTotalConta());
            Console.ReadLine();
            */

        }

        public static void Funcionarios()
        {
            Funcionario funcionario = new Funcionario();


            Console.Write("Digite o nome do funcionário: ");
            funcionario.Nome = Console.ReadLine();

            Console.Write("Digite o CPF: ");
            funcionario.CPF = Console.ReadLine();

            Console.Write("Digite o salário: ");
            funcionario.Salario = Convert.ToDouble(Console.ReadLine());

            GerenciadorBonificacao bonus = new GerenciadorBonificacao();

            bonus.Registrar(funcionario);

            Console.Write("Bonificação do funcionário é de: " + bonus.GetTotalBonificacao());
            Console.ReadLine();
        }
    }
}
