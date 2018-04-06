using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;

namespace eLRNadminApp.Objeto
{
    class dbAccess
    {
        public static DataTable selectQ(string _query)
        {
            try
            {
                Conexion conn = new Conexion();
                OdbcConnection connn = conn.conexion(); 
                OdbcCommand cmd = new OdbcCommand(_query, connn);
                OdbcDataAdapter odbcAdapter = new OdbcDataAdapter();
                odbcAdapter.SelectCommand = cmd;
                DataTable myDataTable = new DataTable();
                odbcAdapter.Fill(myDataTable);
                connn.Close();
                connn.Dispose();
                return myDataTable;
            }
            catch (Exception ex) { System.Windows.Forms.MessageBox.Show("Error al obtener conjunto de datos.\n" + ex.Message); return null; }
        }

        public static void insertQ(string _query)
        {
            try
            {
                Conexion conn = new Conexion();
                OdbcConnection connn = conn.conexion();
                OdbcCommand cmd = new OdbcCommand(_query, connn);
                cmd.ExecuteNonQuery();
                connn.Close();
                connn.Dispose();
            }
            catch (Exception ex) { System.Windows.Forms.MessageBox.Show("Error al insertar datos!.\n" + ex.Message); }
        }

        public static List<AclUser> setDBUserProfile(int auxId) //Método que construye una lista con objetos que guardan los permisos que hay por cada registro de la tabla de detalle_aplicacion_derecho
        {
            string query = @"select p.id_aplicacion as ID, a.nombre_aplicacion, p.ingresar as Ingresar, p.modificar as Modificar, p.eliminar as Eliminar,
                p.imprimir as Imprimir, p.consultar as Consultar from usuario as u, aplicacion as a, detalle_aplicacion_derecho as p
                where u.id_usuario = '"+auxId+"' and u.id_usuario = p.id_usuario and p.id_aplicacion = a.id_aplicacion";

            DataTable dt = selectQ(query);
            try
            {
                List<AclUser> aclList = new List<AclUser>();
                AclUser acl = null;

                foreach (DataRow row in dt.Rows)
                {
                    acl = new AclUser((int)row[0], (string)row[1]);
                    acl.ModuloEscitura = Convert.ToInt16(row[2]);
                    acl.ModuloEdicion = Convert.ToInt16(row[3]);
                    acl.ModuloeEliminar = Convert.ToInt16(row[4]);
                    acl.ModuloeImprimir = Convert.ToInt16(row[5]);
                    acl.ModuloConsultar = Convert.ToInt16(row[6]);
                    aclList.Add(acl);
                    //System.Windows.Forms.MessageBox.Show(row[0].ToString()+row[1], "dbAccessClass");
                }
                Common.ListAcl=aclList;
                return aclList;
            }catch(Exception ex) { System.Windows.Forms.MessageBox.Show(ex.Message,"fromDbAcces"); ; return null; }   
        }
    }
}
