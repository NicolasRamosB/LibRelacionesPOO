using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibRelacionesPOO.Caso1

{
    public class Usuario : Empresa
    {
        public string Pass { get; set; }
        public Cliente Cliente { get; set; }

    }
}
