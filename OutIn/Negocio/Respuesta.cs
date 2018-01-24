using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Respuesta
    {
        private string codigo;
        private string rta;

        public string Codigo { get => codigo; set => codigo = value; }
        public string Rta { get => rta; set => rta = value; }
    }
}
