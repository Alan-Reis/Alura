using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class ContaCorrente
    {
        public Cliente Titular {  get; set; }
        public int Agencia { get; set; }
        public int Conta { get; set; }

        public static int TotalConta { get; private set; }

        private double _saldo = 100;    
        public double Saldo 
        {
            get 
            {
                return _saldo;
            } 
            
            set
            {
                if(value < 0)
                {
                    return;
                }
                _saldo = value;
            }
        }

        public ContaCorrente(int agencia, int conta)
        {
            Agencia = agencia;
            Conta = conta;

            TotalConta++;
        }

        public static int GetTotalConta()
        {
            return TotalConta;
        }
        public bool Sacar(double valor)
        {
            if(this._saldo < valor)
            {
                return false;
            }
            this._saldo -= valor;
            return true;
        }

        public void Depositar(double valor)
        {
            this._saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if(this._saldo < valor)
            {
                return false;
            }
                      
                this._saldo -= valor;
                contaDestino.Depositar(valor);
                return true;
            
            

        }
    }
}
