using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OpenClosed
{
    public static class Compra
    {
        public static void RealizarCompra(IFormaPagamento formaPgto) {
            formaPgto.Pagar();
        } 
    }
}
