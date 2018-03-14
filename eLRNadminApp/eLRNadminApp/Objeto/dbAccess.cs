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
                OdbcCommand cmd = new OdbcCommand(_query, conn.conexion());
                OdbcDataAdapter odbcAdapter = new OdbcDataAdapter();
                odbcAdapter.SelectCommand = cmd;
                DataTable myDataTable = new DataTable();
                odbcAdapter.Fill(myDataTable);
                return myDataTable;
            }
            catch (Exception ex) { System.Windows.Forms.MessageBox.Show("Error al obtener conjunto de datos.\n" + ex.Message); return null; }
        }
    }
}
