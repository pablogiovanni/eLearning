using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eLRNadminApp
{
    public partial class frmAgregarCarrera : Form
    {
        private static string nomApp = "carrera"; //Nombre de la aplicacion
        private static int idApp = 2;
        private static Int32 idCarrera = 0; //iIdNoticia ID autoincremento
        public frmAgregarCarrera()
        {
            InitializeComponent();
            navegador1.setSecProfile(nomApp); // se envía parametro de nombre de aplicacion a la barra de navegacion

            navegador1.sNombreBD = Objeto.Common.dbName;
            navegador1.sNombreTabla = "carrera";
            navegador1.sServidor = Objeto.Common.dbServerIP;
            navegador1.sPass = Objeto.Common.dbPass;
            navegador1.sUsuario = Objeto.Common.dbUser;
            llenarCarrera();
        }
        private void llenarCarrera()
        {
            // LLenar datagridview con las noticias existentes
            String qString = @"select id_carrera, nom_carrera from carrera where estado = 1 ";

            if (Controlador.EvalSec.consultar(nomApp, Objeto.Common.SEC_CONSULTAR) == 1)
            {
                dgv_carrera.DataSource = Objeto.dbAccess.selectQ(qString);
            }
        }
        private bool emptyFields()
        {
            if ((string.IsNullOrEmpty(textBox1.Text)))
            {
                return true;
            }
            return false;
        }

        private void frmAgregarCarrera_Load(object sender, EventArgs e)
        {

        }

        private void navegador1_RecibidorAnterior(object sender, EventArgs e)
        {
            try
            {
                string resultado = navegador1.sResult;
                string[] token = resultado.Split(',');

                comboBox1.Text = token[2];
                textBox1.Text = token[1];

            }
            catch (Exception ex) { }

        }

        private void navegador1_RecibidorInsertar(object sender, EventArgs e)
        {
            if (Controlador.EvalSec.consultar(nomApp, Objeto.Common.SEC_INGRESAR) == 1) // Evaluacion de permiso de escritura en base al nombre de aplicacion
            {                                                                           // 1 = permiso concedido | 0 = permiso denegado
                if (!emptyFields())
                {
                    try
                    {


                        ArrayList listaCampos = new ArrayList();

                        listaCampos.Add("nom_carrera");
                        listaCampos.Add("llave_foranea_descrip_fac");//guardar nombre del combobox pero "el id facultad" se debe guardar en base

                        //listaCampos contiene una lista con los campos de la tabla de la base de datos

                        ArrayList listaValores = new ArrayList();

                        listaValores.Add(textBox1.Text);
                        listaValores.Add(comboBox1.Text);
                        listaValores.Add(1);


                        Navegador.Utilidades.GeneradorSQL sqlGen = new Navegador.Utilidades.GeneradorSQL(Objeto.Common.dbServerIP, Objeto.Common.dbName, Objeto.Common.dbUser, Objeto.Common.dbPass, "facultad");
                        sqlGen.setCodigoInstDML(1);
                        sqlGen.setCampos(listaCampos);
                        sqlGen.setValores(listaValores);
                        sqlGen.ejecutar();
                        idCarrera = 0;
                        llenarCarrera();
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message, "E-Learning"); }
                }
                else { MessageBox.Show("Llenar los campos de texto!", "E-Learning"); }
            }

        }

        private void navegador1_RecibidorPrimero(object sender, EventArgs e)
        {
            try
            {
                string resultado = navegador1.sResult;
                string[] token = resultado.Split(',');

                comboBox1.Text = token[2];
                textBox1.Text = token[1];

            }
            catch (Exception ex) { }
        }

        private void navegador1_RecibidorSiguiente(object sender, EventArgs e)
        {
            try
            {
                string resultado = navegador1.sResult;
                string[] token = resultado.Split(',');

                comboBox1.Text = token[2];
                textBox1.Text = token[1];

            }
            catch (Exception ex) { }
        }

        private void navegador1_RecibidorUltimo(object sender, EventArgs e)
        {
            try
            {
                string resultado = navegador1.sResult;
                string[] token = resultado.Split(',');

                comboBox1.Text = token[2];
                textBox1.Text = token[1];

            }
            catch (Exception ex) { }
        }

        private void navegador1_RecibidorEliminar(object sender, EventArgs e)
        {
            try
            {
                int iEstado = 0;

                ArrayList listaCampos = new ArrayList();
                listaCampos.Add("estado");
                ArrayList listaValores = new ArrayList();
                listaValores.Add(iEstado);

                Navegador.Utilidades.GeneradorSQL sqlGen = new Navegador.Utilidades.GeneradorSQL(Objeto.Common.dbServerIP, Objeto.Common.dbName, Objeto.Common.dbUser, Objeto.Common.dbPass, "facultad");
                sqlGen.setCodigoInstDML(2);
                sqlGen.setComparacion("id_carrera", idCarrera.ToString());
                sqlGen.setCampos(listaCampos);
                sqlGen.setValores(listaValores);
                sqlGen.ejecutar();
                llenarCarrera();
            }
            catch (Exception ex) { MessageBox.Show("Error al intentar eliminar Carrera\n" + ex.Message, "E-Learning"); }

        }

        private void navegador1_RecibidorActualizar(object sender, EventArgs e)
        {
            try
            {
                if (!emptyFields())
                {

                    ArrayList listaCampos = new ArrayList();
                    listaCampos.Add("nom_carrera");
                    listaCampos.Add("llave_foranea_facultad");// aqui se debe guardar igual el nombre del "id" de la base de datos


                    ArrayList listaValores = new ArrayList();
                    listaValores.Add(comboBox1.Text);
                    listaValores.Add(textBox1.Text);

                    Navegador.Utilidades.GeneradorSQL sqlGen = new Navegador.Utilidades.GeneradorSQL(Objeto.Common.dbServerIP, Objeto.Common.dbName, Objeto.Common.dbUser, Objeto.Common.dbPass, "facultad");
                    sqlGen.setCodigoInstDML(2);
                    sqlGen.setComparacion("id_carrera", idCarrera.ToString());
                    sqlGen.setCampos(listaCampos);
                    sqlGen.setValores(listaValores);
                    sqlGen.ejecutar();
                    llenarCarrera();
                }
                else { MessageBox.Show("Llenar los campos de texto!", "E-Learning"); }
            }
            catch (Exception ex) { }
        }
    }
    
}
