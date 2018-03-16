using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eLRNadminApp.Objeto
{
    class TipoPersonal
    {
        public int IdPesonal { get; set; }
        public string NombrePersonal { get; set; }

        public TipoPersonal(int id, string nombretipo)
        {
            this.IdPesonal = id;
            this.NombrePersonal = nombretipo;
        }
    }
}
