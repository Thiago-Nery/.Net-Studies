using SOLID.OpenClosed;

namespace SOLID
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IFormaPagamento pagamento = new Pix();      

            Compra.RealizarCompra(pagamento); 
        }
    }
}