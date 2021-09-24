﻿using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();

            Console.Write("Digite o nome do titular: ");
            conta.Titular = Console.ReadLine();

            Console.Write("Digite a agência: ");
            conta.Agencia = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ditege a conta: ");
            conta.Conta = Convert.ToInt32(Console.ReadLine());

            conta.Saldo = 100.00; //Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(conta.Titular);
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
