using ByteBank.Fucionario;
using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            CalcularBonificacao();
        }
        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Designer designer = new Designer("111.111.111.11");
            designer.Nome = "Alan";

            Diretor diretor = new Diretor("222.222.222.22");
            diretor.Nome = "Gerson";

            Auxiliar auxiliar = new Auxiliar("333.333.333.22");
            auxiliar.Nome = "Paulo";

            Gerente gerente = new Gerente("444.444.444.44");
            gerente.Nome = "Deise";

            gerenciadorBonificacao.Registrar(designer);
            gerenciadorBonificacao.Registrar(diretor);
            gerenciadorBonificacao.Registrar(auxiliar);
            gerenciadorBonificacao.Registrar(gerente);

            Console.WriteLine("Total de bonificação do mês: " + gerenciadorBonificacao.GetTotalBonificacao());
        }
        public static void Funcionarios()
        {
            /*
            Funcionario funcionario = new Funcionario();

            Console.Write("Digite o nome do funcionário: ");
            funcionario.Nome = Console.ReadLine();

            Console.Write("Digite o CPF: ");
            //funcionario.CPF = Console.ReadLine();

            Console.Write("Digite o salário: ");
            funcionario.Salario = Convert.ToDouble(Console.ReadLine());

            GerenciadorBonificacao bonus = new GerenciadorBonificacao();

            bonus.Registrar(funcionario);

            Console.Write("Bonificação do funcionário é de: " + bonus.GetTotalBonificacao());
            Console.ReadLine();
            */
        }
       
        public static void Cliente()
        {
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

        }
               
       
    }
}
