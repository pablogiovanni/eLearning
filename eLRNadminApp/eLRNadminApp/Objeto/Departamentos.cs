using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eLRNadminApp.Objeto
{
    class Departamentos
    {
        public int IdDepto { get; set; }
        public string NombreDepto { get; set; }

        public Departamentos(int id, string nombretipo)
        {
            this.IdDepto = id;
            this.NombreDepto = nombretipo;
        }
    }
}
