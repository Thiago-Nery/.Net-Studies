using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OpenClosed
{
    public class CartaoCredito : IFormaPagamento
    {
        public void Pagar()
        {
            Console.WriteLine("Pago com Cartão de Crédito!");
        }
    }
}
