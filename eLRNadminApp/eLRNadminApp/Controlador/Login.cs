using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eLRNadminApp.Objeto;

namespace eLRNadminApp.Controlador
{
    class Login
    {
        System.Data.DataTable dt = new System.Data.DataTable();

        public string dbuser { set; get;}
        public string dbpass { set; get; }
        public string dbsrvip { set; get; }
        public string dbname { set; get; }

        protected static MySql.Data.MySqlClient.MySqlConnection mysqlconn;
        protected MySql.Data.MySqlClient.MySqlCommand mysqlcmd;
        protected MySql.Data.MySqlClient.MySqlDataReader reader;
        protected static int userequal = 1;

        public void getAcls(string usr, string pass)
        {
            try
            {
                string s_conString = obtenerParametrosDB();
                string auxPass = "";

                mysqlconn = new MySql.Data.MySqlClient.MySqlConnection();
                mysqlcmd = new MySql.Data.MySqlClient.MySqlCommand();
                mysqlconn.ConnectionString = s_conString;
                mysqlconn.Open();

                mysqlcmd.Connection = mysqlconn;

                mysqlcmd.CommandText = "select password(@passwd);";
                mysqlcmd.Parameters.AddWithValue("@passwd",pass);
                mysqlcmd.Prepare();
                reader = mysqlcmd.ExecuteReader();

                if (reader.Read())
                {
                    auxPass = reader[0].ToString();
                    System.Windows.Forms.MessageBox.Show(auxPass);
                }
                else { System.Windows.Forms.MessageBox.Show("Error on query or connection!"); }

                reader.Close();
                mysqlconn.Close();

                mysqlcmd.CommandText = @"select u.id_usr, u.id_per, u.id_reg, u.pass, p.nom_per, p.ape_per from usuario as u, personal_reg as p 
                                        where u.id_usr = @user and u.pass = @pass and u.reg_id_per = p.id_per and u.reg_id_reg = p.id_reg";
                mysqlcmd.Prepare();

                mysqlcmd.Parameters.AddWithValue("@user", usr);
                mysqlcmd.Parameters.AddWithValue("@pass", pass);
                reader = mysqlcmd.ExecuteReader();
                //MessageBox.Show(usr);

                if (reader.Read())
                {
                    //Common.usrLogin = (String)reader[0];
                    if (reader[0].ToString().Equals(usr))
                    {
                        userequal = 0;
                        Common.usrLogin = (string)reader[0];
                        Common.idPLogin = (int)reader[1];
                        Common.regPLogin = (string)reader[2];
                    } // Evaluación de usuario ingresado el Textbox contra la tabla de usuario

                }
                reader.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex) { System.Windows.Forms.MessageBox.Show(ex.Message); }
        }

        public string obtenerParametrosDB()
        { //Método alterno para obtener parámetros de base de datos
            return "server=" + this.dbsrvip + ";user=" + this.dbuser + ";database=" + this.dbname + ";password=" + this.dbpass;
        }

        public void establecerParametrosDB(string dbServer, string dbUser, string dbName, string dbPass)
        {   //Método alterno para establecer parámetros de base de datos
            this.dbuser = dbUser;
            this.dbpass = dbPass;
            this.dbsrvip = dbServer;
            this.dbname = dbName;
        }
    }
}
