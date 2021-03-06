using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Fucionario
{
    public abstract class Funcionario
    {
        public static int TotalFuncionario { get; private set; }
        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }
        public Funcionario(double salario, string cpf)
        {
            CPF = cpf;
            Salario = salario;
            TotalFuncionario++;
        }

        public virtual void AumentarSalario()
        {
            Salario *= 1.1;
        }

        public virtual double GetBonificacao() 
        {
            return Salario * 0.10;
        }

    }
}
