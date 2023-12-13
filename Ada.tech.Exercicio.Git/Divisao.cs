using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ada.tech.Exercicio.Git
{
    internal class Divisao
    {
        public decimal efetuarDivisao(Decimal x, Decimal y)
        {           
            if (y==0)
            {
                throw new DivideByZeroException("Divisão por zero não é permitida.");
            }
            else
            {
                return x / y;
            }
        }
    }
}
