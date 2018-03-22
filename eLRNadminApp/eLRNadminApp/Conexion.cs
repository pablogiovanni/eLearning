using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;


namespace eLRNadminApp
{
    class Conexion
    {
       public OdbcConnection conexion()
        {
            OdbcConnection con = new OdbcConnection();
            con = new OdbcConnection("Driver ={ MySQL ODBC 3.51 Driver }; Dsn=adm_dsn;");
            con.Open();
            return con;        
        }

        public bool comprobacionConexion()
        {
            try
            {
                conexion();
                return true;
            }
            catch (OdbcException ex)
            {
                return false;
            }
        }

        public OdbcConnection profileConnection(string tipoAux)
        {
            try
            {
                OdbcConnection con = null;
                if (!(string.IsNullOrEmpty(tipoAux)))
                {
                    switch (tipoAux)
                    {
                        case "Administrativo":
                            con = new OdbcConnection("Driver={MySQL ODBC 3.51 Driver}; SERVER=127.0.0.1; DATABASE=elearningdb; UID=elearn; PASSWORD=$ele@rn$;");
                            con.Open();
                            break;
                        case "Operativo":
                            con = new OdbcConnection("Driver={MySQL ODBC 3.51 Driver}; SERVER=127.0.0.1; DATABASE=elearningdb; UID=opert; PASSWORD=$0pert$;");
                            break;
                        case "Catedratico":
                            con = new OdbcConnection("Driver={MySQL ODBC 3.51 Driver}; SERVER=127.0.0.1; DATABASE=elearningdb; UID=cat; PASSWORD=$c@t$");
                            break;
                        case "Alumno":
                            con = new OdbcConnection("Driver={MySQL ODBC 3.51 Driver}; SERVER=127.0.0.1; DATABASE=elearningdb; UID=almn; PASSWORD=$@lmn$");
                            break;
                        default:
                            break;
                    }
                }
                else { return null; }

                return con;
            }
            catch (Exception ex) { System.Windows.Forms.MessageBox.Show(ex.Message); return null; }
        }

    }
}
