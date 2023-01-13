using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibRelacionesPOO.Caso2
{
    internal class Pedido
    {
        public string NumeroDePedido { get; set; }
        public int Cantidad { get; set; }
        
        public Cliente Cliente { get; set; }
    }
}
