using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao_EF
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string Sobrenome { get; set; }
        public List<Pedido> Pedidos { get; set; } = new List<Pedido>(); 
    }
}
