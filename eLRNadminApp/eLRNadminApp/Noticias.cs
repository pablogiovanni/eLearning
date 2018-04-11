using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace eLRNadminApp
{
    public partial class Noticias : Form
    {
        private static string nomApp = "Noticias"; //Nombre de la aplicacion
        private static int idApp = 2;
        public static int appId { get; }
        private static string sIdReg, sNomNot = ""; //sIdReg = Id de registro de personal EJ. empleado = emp; catedratico = cat
        private static Int32 iIdPer = 0; //iIdPer = Id(autoincremento de tabla personal_reg) de personal 
        private static Int32 iIdEmp = 0; //iIdEmp = Id(Autoincremento de table empleado) de empleado
        private static Int32 iIdNoticia = 0; //iIdNoticia ID autoincremento

        public Noticias()
        {
            InitializeComponent();
            sIdReg = Objeto.Common.regPLogin; // Se obtiene el id de registro de personal
            iIdPer = Objeto.Common.idPLogin; // Se obtiene el id de personal
            navegador1.setSecProfile(nomApp); // se envía parametro de nombre de aplicacion a la barra de navegacion
            getIdEmp(); //metodo que obtiene el ID de empleado en base al id personal y id registro personal
            getNoticias(); // Metodo que obtiene las noticias en las que el campo "estado" = 1

            navegador1.sNombreBD = Objeto.Common.dbName;
            navegador1.sNombreTabla = "noticia";
            navegador1.sServidor = Objeto.Common.dbServerIP;
            navegador1.sPass = Objeto.Common.dbPass;
            navegador1.sUsuario = Objeto.Common.dbUser;
        }

        private void getNoticias()
        {
            // LLenar datagridview con las noticias existentes
            String qString = @"select n.id_noticia as ID, n.nom_noticia as Nombre, n.fecha_creado as Creado, n.fecha_noticia as FechaNoticia from noticia n where n.estado = 1";

            if (Controlador.EvalSec.consultar(nomApp, Objeto.Common.SEC_CONSULTAR) == 1)
            {
                Dgv_noticias.DataSource = Objeto.dbAccess.selectQ(qString);
            }
        }

        private int getNewIdNoticia()
        {
            string qString = @"select count(id_noticia) from noticia";
            DataTable dt = Objeto.dbAccess.selectQ(qString);
            int aux = 0;
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    aux = int.Parse(row[0].ToString());
                }
                return aux + 1;
            }
            return -1;
        }

        private void getIdEmp() //metodo que obtiene el ID de empleado en base al id personal y id registro personal
        {
            try
            {
                sIdReg = Objeto.Common.regPLogin;
                iIdPer = Objeto.Common.idPLogin;

                string qString = @"select e.id_emp from empleado as e, personal_reg as p where p.id_per = '" + iIdPer + "' and e.personal_id_per = p.id_per";
                DataTable dt = Objeto.dbAccess.selectQ(qString);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        iIdEmp = (int)row[0]; //se halla el id empleado de la tabla de empleado en base al id personal y id de registro personal
                    }
                    lbl_id_per.Text = iIdEmp.ToString();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message,"E-Learning"); }
        }

        private void navegador1_RecibidorInsertar(object sender, EventArgs e)
        {
            if (Controlador.EvalSec.consultar(nomApp, Objeto.Common.SEC_INGRESAR) == 1) // Evaluacion de permiso de escritura en base al nombre de aplicacion
            {                                                                           // 1 = permiso concedido | 0 = permiso denegado
                if (!emptyFields())
                {
                    try
                    {
                        iIdNoticia = getNewIdNoticia();
                        string dt1 = DateTime.Parse(dtP_1.Text).ToString("yyyy/MM/dd"); //Convertir la fecha para mysql
                        string dt2 = DateTime.Parse(dtP_2.Text).ToString("yyyy/MM/dd"); //Convertir la fecha para mysql

                        ArrayList listaCampos = new ArrayList();

                        listaCampos.Add("id_noticia");
                        listaCampos.Add("id_emp");
                        listaCampos.Add("nom_noticia");         //listaCampos contiene una lista con los campos de la tabla de la base de datos
                        listaCampos.Add("fecha_creado");
                        listaCampos.Add("fecha_noticia");
                        listaCampos.Add("estado");

                        ArrayList listaValores = new ArrayList();

                        listaValores.Add(iIdNoticia);
                        listaValores.Add(iIdEmp);
                        listaValores.Add(txt_nom_not.Text);
                        listaValores.Add(dt1);
                        listaValores.Add(dt2);
                        listaValores.Add(1);

                        txt_nom_not.Clear();

                        Navegador.Utilidades.GeneradorSQL sqlGen = new Navegador.Utilidades.GeneradorSQL(Objeto.Common.dbServerIP, Objeto.Common.dbName, Objeto.Common.dbUser, Objeto.Common.dbPass, "noticia");
                        sqlGen.setCodigoInstDML(1);
                        sqlGen.setCampos(listaCampos);
                        sqlGen.setValores(listaValores);
                        sqlGen.ejecutar();
                        iIdNoticia = 0;
                        getNoticias();
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message, "E-Learning"); }
                }
                else { MessageBox.Show("Llenar los campos de texto!", "E-Learning"); }
            }
        }

        private void Noticias_Load(object sender, EventArgs e)
        {

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

                Navegador.Utilidades.GeneradorSQL sqlGen = new Navegador.Utilidades.GeneradorSQL(Objeto.Common.dbServerIP, Objeto.Common.dbName, Objeto.Common.dbUser, Objeto.Common.dbPass, "noticia");
                sqlGen.setCodigoInstDML(2);
                sqlGen.setComparacion("id_noticia",iIdNoticia.ToString());
                sqlGen.setCampos(listaCampos);
                sqlGen.setValores(listaValores);
                sqlGen.ejecutar();
                getNoticias();
            }
            catch (Exception ex) { MessageBox.Show("Error al intentar eliminar noticia\n"+ex.Message, "E-Learning"); }
        }

        private void Dgv_noticias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (Dgv_noticias.Rows[e.RowIndex] != null)
                {
                    lbl_id_not.Text = Dgv_noticias.Rows[e.RowIndex].Cells[0].Value.ToString();
                    iIdNoticia = int.Parse(Dgv_noticias.Rows[e.RowIndex].Cells[0].Value.ToString());
                    txt_nom_not.Text = Dgv_noticias.Rows[e.RowIndex].Cells[1].Value.ToString();
                    dtP_1.Text = Dgv_noticias.Rows[e.RowIndex].Cells[2].Value.ToString();
                    dtP_2.Text =  Dgv_noticias.Rows[e.RowIndex].Cells[3].Value.ToString();
                }
            }
            catch (Exception ex) { }
        }

        private void navegador1_RecibidorAnterior(object sender, EventArgs e)
        {
            try
            {
                string resultado = navegador1.sResult;
                string[] token = resultado.Split(',');

                lbl_id_not.Text = token[0];
                txt_nom_not.Text = token[2];
                dtP_1.Text = token[3];
                dtP_2.Text = token[4];
            }
            catch (Exception ex) { }
        }

        private void navegador1_RecibidorSiguiente(object sender, EventArgs e)
        {
            try
            {
                string resultado = navegador1.sResult;
                string[] token = resultado.Split(',');

                lbl_id_not.Text = token[0];
                txt_nom_not.Text = token[2];
                dtP_1.Text = token[3];
                dtP_2.Text = token[4];
            }
            catch (Exception ex) { }
        }

        private void navegador1_RecibidorPrimero(object sender, EventArgs e)
        {
            try
            {
                string resultado = navegador1.sResult;
                string[] token = resultado.Split(',');

                lbl_id_not.Text = token[0];
                txt_nom_not.Text = token[2];
                dtP_1.Text = token[3];
                dtP_2.Text = token[4];
            }
            catch (Exception ex) { }
        }

        private void navegador1_RecibidorUltimo(object sender, EventArgs e)
        {
            try
            {
                string resultado = navegador1.sResult;
                string[] token = resultado.Split(',');

                lbl_id_not.Text = token[0];
                txt_nom_not.Text = token[2];
                dtP_1.Text = token[3];
                dtP_2.Text = token[4];
            }
            catch (Exception ex) { }
        }

        private void navegador1_RecibidorActualizar(object sender, EventArgs e)
        {
            try
            {
                if (!emptyFields())
                {
                    sNomNot = txt_nom_not.Text; //sNomNot = valor del campo de texto que tiene el nuevo valor del nombre de la noticia
                    string dt1 = DateTime.Parse(dtP_1.Text).ToString("yyyy/MM/dd"); //Convertir la fecha para mysql
                    string dt2 = DateTime.Parse(dtP_2.Text).ToString("yyyy/MM/dd"); //Convertir la fecha para mysql


                    ArrayList listaCampos = new ArrayList();
                    listaCampos.Add("nom_noticia");
                    listaCampos.Add("fecha_creado");
                    listaCampos.Add("fecha_noticia");

                    ArrayList listaValores = new ArrayList();
                    listaValores.Add(sNomNot);
                    listaValores.Add(dt1);
                    listaValores.Add(dt2);

                    Navegador.Utilidades.GeneradorSQL sqlGen = new Navegador.Utilidades.GeneradorSQL(Objeto.Common.dbServerIP, Objeto.Common.dbName, Objeto.Common.dbUser, Objeto.Common.dbPass, "noticia");
                    sqlGen.setCodigoInstDML(2);
                    sqlGen.setComparacion("id_noticia", iIdNoticia.ToString());
                    sqlGen.setCampos(listaCampos);
                    sqlGen.setValores(listaValores);
                    sqlGen.ejecutar();
                    getNoticias();
                }
                else { MessageBox.Show("Llenar los campos de texto!", "E-Learning"); }
            }
            catch (Exception ex) { }
        }

        private bool emptyFields()
        {
            if ((string.IsNullOrEmpty(txt_nom_not.Text)) || (string.IsNullOrEmpty(dtP_1.Text)) || (string.IsNullOrEmpty(dtP_2.Text)))
            {
                return true;
            }
            return false;
        }
    }
}
