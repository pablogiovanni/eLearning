using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eLRNadminApp.Objeto
{
    class NumTel
    {
        public string IdNumero { get; set; }
        public string IdArea { get; set; }
        public int IdPer { get; set; }
        public int IdPerReg { get; set; }

        public NumTel(string idtel, string idarea)
        {
            this.IdNumero = idtel;
            this.IdArea = idarea;
        }
    }
}
