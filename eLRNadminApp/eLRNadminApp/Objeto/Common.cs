using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace eLRNadminApp.Objeto
{
    static class Common
    {
        public static string usrLogin { set; get; }
        public static string passLogin { set; get; }
        public static int idPLogin { set; get; } //Id de persona en tabla persona_reg
        public static string regPLogin { set; get; } //Tipo registro en tabla de persona_reg
        public static bool signedIn { set; get; }
        public static string tipoPersonal { set; get; }
        private static List<Objeto.AclUser> acList = new List<AclUser>();
        public static List<Objeto.AclUser> ListAcl { set; get; }
        public const int SEC_INGRESAR = 1;
        public const int SEC_CONSULTAR = 2;
        public const int SEC_EDITAR = 3;
        public const int SEC_ELIMINAR = 4;
        public const int SEC_IMPRIMIR = 5;

        public static string dbTableName { set; get; }
        public static string dbName { set; get; }
        public static string dbUser { set; get; }
        public static string dbPass { set; get; }
        public static string dbServerIP { set; get; }

        //private static List<Objeto.AclUser> acList;

        public static void setAclList()
        {
            if (ListAcl != null)
            {
                ListAcl.Clear();

            }
        }

        public static List<Objeto.AclUser> getAclList()
        {
            if (Objeto.Common.signedIn)
            {
                return acList;
            }
            return null;
        }

        public static DataTable forUsersInfo(string query)
        {
            return null;
        }
    }
}
