using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OpenClosed
{
    public class Pix : IFormaPagamento
    {
        public void Pagar()
        {
            Console.WriteLine("Pago com Pix! e desconto de 5%");
        }
    }
}
