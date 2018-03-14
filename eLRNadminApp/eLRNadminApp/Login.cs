using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;

namespace eLRNadminApp
{
    public partial class Login : Form
    {
        OdbcCommand com;
        OdbcDataReader dr;
        Conexion con = new Conexion();
        
        public Login()
        {
            InitializeComponent();         
        }

        private void Login_Load(object sender, EventArgs e)
        {
            if (con.comprobacionConexion())
            {
                //SI LA CONEXION ES CORRECTA NO HACE NADA, SIGUE CON LA EJECUCION
            }
            else
            {
                MessageBox.Show("Error en Conexion");
            }
        }

        private void btn_Entrar_Click(object sender, EventArgs e)
        {
            try
            {
                string id_usuario;
                int id = 0;
                com = new OdbcCommand("select id_usuario from usuario where usuario='" + txt_usuario.Text + "' and AES_DECRYPT(contrasena,'password')='" + txt_contraseña.Text + "' ", con.conexion());
                dr = com.ExecuteReader();
                Globales.nom_usuario = txt_usuario.Text.ToString();

                while (dr.Read())
                {
                    id_usuario = dr["id_usuario"].ToString();
                    id = Convert.ToInt32(id_usuario);
                    Globales.id_usuario = (int)dr["id_usuario"];
                }
                dr.Close();

                if (id != 0)
                {
                    Objeto.Common.signedIn = true;
                    this.Hide();
                    MessageBox.Show("Binvenido " + Globales.nom_usuario + " ID: " + Globales.id_usuario, "Login");
                }
                else
                {
                    txt_usuario.Text = "";
                    txt_contraseña.Text = "";
                    MessageBox.Show("Usuario y/o Contraseña incorrecta.");
                    Objeto.Common.signedIn = false;
                    Globales.id_usuario = 0;
                }
            }
            catch (Exception ex)
            {
                txt_usuario.Text = "";
                txt_contraseña.Text = "";
                MessageBox.Show("Usuario y/o Contraseña incorrecta."+ex.ToString());
                Objeto.Common.signedIn = false;
                Globales.id_usuario = 0;
            }
           // MessageBox.Show(Globales.nom_usuario);
        }

        private void Login_Load_1(object sender, EventArgs e)
        {

        }
    }
}
