using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibRelacionesPOO.Caso1
{
    public class Cliente : Empresa
    {
        
        public string Apellido { get; set; }

        public Usuario Usuario { get; set; }

    }
}
