using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eLRNadminApp.Objeto
{
    class Email
    {
        public string IdEmail { get; set; }
        public int IdPer { get; set; }
        public string IdPerReg { get; set; }

        public Email(string idtel)
        {
            this.IdEmail = idtel;
        }
    }
}
