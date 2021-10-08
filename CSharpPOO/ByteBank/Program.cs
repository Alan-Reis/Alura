using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Cliente cliente = new Cliente();
           
            Console.Write("Digite o nome do titular: ");
            cliente.Nome = Console.ReadLine();
            Console.Write("Digite o CPF do titular: ");
            cliente.CPF = Console.ReadLine();
            Console.Write("Digite a profissão do titular: ");
            cliente.Profissao = Console.ReadLine();

            ContaCorrente conta = new ContaCorrente();

            conta.Titular = cliente;

            Console.Write("Digite a agência: ");
            conta.Agencia = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ditege a conta: ");
            conta.Conta = Convert.ToInt32(Console.ReadLine());

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
            ContaCorrente c2 = new ContaCorrente();
            
            Console.Write("Digite o valor da tranferência: ");
            conta.Transferir(Convert.ToDouble(Console.ReadLine()), c2);

            Console.WriteLine("Novo saldo: " + conta.Saldo);
            Console.ReadLine();

        }
    }
}
