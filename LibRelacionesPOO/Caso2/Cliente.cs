using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibRelacionesPOO.Caso2
{
    public class Cliente
    {
        public string Nombre { get; set; }
        public string CUIT { get; set; }

       List<Pedido> Pedidos { get; set; }
    }
}
