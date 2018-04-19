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
    public partial class actividadesnota : Form
    {
        private static string nomApp = "ElementosDeNotas"; //Nombre de la aplicacion
        private static int idApp = 2;
        public static int appId { get; }
        private static Int32 iIdAct, iIdTotal = 0; //iIdAct ID autoincremento

        public actividadesnota()
        {
            InitializeComponent();
            navegador1.setSecProfile(nomApp);
            setNavDBInfo();
            getNoticias();
        }

        private void setNavDBInfo()
        {

            navegador1.sNombreBD = Objeto.Common.dbName;
            navegador1.sNombreTabla = "elemento_nota";
            navegador1.sServidor = Objeto.Common.dbServerIP;
            navegador1.sPass = Objeto.Common.dbPass;
            navegador1.sUsuario = Objeto.Common.dbUser;
        }

        private void getNoticias()
        {
            // LLenar datagridview con las noticias existentes
            String qString = @"select id_el, nom_el, nota_total_el from elemento_nota n where estado = 1";

            if (Controlador.EvalSec.consultar(nomApp, Objeto.Common.SEC_CONSULTAR) == 1)
            {
                Dgv_act.DataSource = Objeto.dbAccess.selectQ(qString);
            }
        }

        private bool emptyFields()
        {
            if ((string.IsNullOrEmpty(txt_nota_total.Text)) || (string.IsNullOrEmpty(txt_nom_act.Text)) )
            {
                return true;
            }
            return false;
        }

        private void clearTxt()
        {
            txt_nom_act.Text = "";
            txt_nota_total.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void navegador1_RecibidorInsertar(object sender, EventArgs e)
        {
            try
            {
                if (!emptyFields())
                {
                    ArrayList listaCampos = new ArrayList();
                    listaCampos.Add("nom_el");
                    listaCampos.Add("nota_total_el");
                    listaCampos.Add("estado");

                    ArrayList lValores = new ArrayList();
                    lValores.Add(txt_nom_act.Text);
                    lValores.Add(txt_nota_total.Text);
                    lValores.Add(1);

                    Navegador.Utilidades.GeneradorSQL sqlGen = new Navegador.Utilidades.GeneradorSQL(Objeto.Common.dbServerIP, Objeto.Common.dbName, Objeto.Common.dbUser, Objeto.Common.dbPass, "elemento_nota");
                    sqlGen.setCodigoInstDML(1);
                    sqlGen.setCampos(listaCampos);
                    sqlGen.setValores(lValores);
                    sqlGen.ejecutar();
                    iIdAct = 0;
                    clearTxt();
                }
                else { MessageBox.Show("LLenar los campos antes de insertar!", "E-Learning"); }
            }
            catch (Exception ex ) { MessageBox.Show(ex.Message, "E-Learning"); }
        }

        private void navegador1_RecibidorActualizar(object sender, EventArgs e)
        {
            try
            {
                if (!emptyFields())
                {
                    ArrayList listaCampos = new ArrayList();
                    listaCampos.Add("nom_el");
                    listaCampos.Add("nota_total_el");

                    ArrayList lValores = new ArrayList();
                    lValores.Add(txt_nom_act.Text);
                    lValores.Add(txt_nota_total.Text);

                    Navegador.Utilidades.GeneradorSQL sqlGen = new Navegador.Utilidades.GeneradorSQL(Objeto.Common.dbServerIP, Objeto.Common.dbName, Objeto.Common.dbUser, Objeto.Common.dbPass, "elemento_nota");
                    sqlGen.setCodigoInstDML(2);
                    sqlGen.setCampos(listaCampos);
                    sqlGen.setValores(lValores);
                    sqlGen.setComparacion("id_el", iIdAct.ToString());
                    sqlGen.ejecutar();
                    iIdAct = 0;
                    clearTxt();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "E-Learning"); }
        }

        private void Dgv_act_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (Dgv_act.Rows[e.RowIndex] != null)
                {
                    lbl_id_act.Text = Dgv_act.Rows[e.RowIndex].Cells[0].Value.ToString();
                    iIdAct = int.Parse(Dgv_act.Rows[e.RowIndex].Cells[0].Value.ToString());
                    txt_nom_act.Text = Dgv_act.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txt_nota_total.Text = Dgv_act.Rows[e.RowIndex].Cells[2].Value.ToString();
                    iIdTotal = int.Parse(Dgv_act.Rows[e.RowIndex].Cells[2].Value.ToString() );
                }
            }
            catch (Exception ex) { }
        }
    }
}
