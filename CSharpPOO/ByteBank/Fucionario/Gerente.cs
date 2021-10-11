using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Fucionario
{
    class Gerente : Funcionario
    {
        public Gerente(string cpf) : base (4000, cpf)
        {

        }
        public override void AumentarSalario()
        {
            Salario *= 1.5;
        }
        public override double GetBonificacao()
        {
            return Salario * 0.25;
        }
    }
}
