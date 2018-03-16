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

        public static bool setPermission()
        {
            String sQuery = @"select p.id_aplicacion as ID, a.nombre_aplicacion, u.usuario as Usuario, p.ingresar as Ingresar, p.modificar as Modificar, p.eliminar as Eliminar,
                p.imprimir as Imprimir, p.consultar as Consultar from usuario as u, aplicacion as a, detalle_aplicacion_derecho as p
                where p.id_usuario = '"+Globales.id_usuario+"'and p.id_aplicacion = a.id_aplicacion";
            DataTable dt = dbAccess.selectQ("");

            if(dt.Rows.Count != 0)
            {

            }
            return true;
        }
    }
}
