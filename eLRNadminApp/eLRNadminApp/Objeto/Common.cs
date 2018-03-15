using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eLRNadminApp.Objeto
{
    static class Common
    {
        public static string usrLogin { set; get; }
        public static string passLogin { set; get; }
        public static int idPLogin { set; get; } //Id de persona en tabla persona_reg
        public static string regPLogin { set; get; } //Tipo registro en tabla de persona_reg
        public static bool signedIn { set; get; }

    }
}
