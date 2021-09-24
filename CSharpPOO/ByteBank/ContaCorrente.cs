using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class ContaCorrente
    {
        public string Titular { get; set; }
        public int Agencia { get; set; }
        public int Conta { get; set; }
        public double Saldo { get; set; }

        public bool Sacar(double valor)
        {
            if(this.Saldo < valor)
            {
                return false;
            }
            this.Saldo -= valor;
            return true;
        }

        public void Depositar(double valor)
        {
            this.Saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if(this.Saldo < valor)
            {
                return false;
            }
                      
                this.Saldo -= valor;
                contaDestino.Depositar(valor);
                return true;
            
            

        }
    }
}
