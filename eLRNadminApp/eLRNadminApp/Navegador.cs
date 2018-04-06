using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Navegador.Utilidades;
using eLRNadminApp.Controlador;

namespace Navegador
{
    public partial class Navegador : UserControl
    {

        /**
         * Parametros user control necesarios para una conexion a base de datos MYSQL
         * 
         * **/
        public String sApp { set; get; }
        [Description("Direccion servidor")]
        [Category("ParametrosBD")]
        public String sServidor{ get; set; }
        [Description("BaseDatos")]
        [Category("ParametrosBD")]
        public String sNombreBD { get; set; }
        [Description("NombreTabla")]
        [Category("ParametrosBD")]
        public String sNombreTabla { get; set; }
        [Description("Usuario")]
        [Category("ParametrosBD")]
        public String sUsuario { get; set; }
        [Description("Contraseña")]
        [Category("ParametrosBD")]
        public String sPass { get; set; }
        private Conector con;
        public int iPosicion = 0,iFilastotal,iColumnasTotal;
        public String sResult { get; set; }


        /**
         * 
         * Eventos que reciben los metodos o funciones para ser aplicados a cada boton
         * 
         * **/
        public event EventHandler RecibidorInsertar;
        public event EventHandler RecibidorActualizar;
        public event EventHandler RecibidorEliminar;
        public event EventHandler RecibidorSiguiente;
        public event EventHandler RecibidorAnterior;
        public event EventHandler RecibidorPrimero;
        public event EventHandler RecibidorUltimo;
        


        public Navegador()
        {
            InitializeComponent();
            initBlock();
        }

        public void setSecProfile(string app)
        {
            sApp = app;
            if (eLRNadminApp.Controlador.EvalSec.consultar(sApp, eLRNadminApp.Objeto.Common.SEC_EDITAR) == 1)
            {
                btn_actualizar.Enabled = true;
            }
            if (eLRNadminApp.Controlador.EvalSec.consultar(sApp, eLRNadminApp.Objeto.Common.SEC_CONSULTAR) == 1)
            {
                btn_primero.Enabled = true;
                btn_ultimo.Enabled = true;
                btn_adelante.Enabled = true;
                btn_atras.Enabled = true;
            }
            if (eLRNadminApp.Controlador.EvalSec.consultar(sApp, eLRNadminApp.Objeto.Common.SEC_INGRESAR) == 1)
            {
                btn_insertar.Enabled = true;
            }
            if (eLRNadminApp.Controlador.EvalSec.consultar(sApp, eLRNadminApp.Objeto.Common.SEC_ELIMINAR) == 1)
            {
                btn_eliminar.Enabled = true;
            }
            if (eLRNadminApp.Controlador.EvalSec.consultar(sApp, eLRNadminApp.Objeto.Common.SEC_IMPRIMIR) == 1)
            {
                btn_imprimir.Enabled = true;
            }
        }

        private void initBlock()
        {
            btn_eliminar.Enabled = false;
            btn_actualizar.Enabled = false;
            btn_guardar.Enabled = false;
            btn_adelante.Enabled = false;
            btn_primero.Enabled = false;
            btn_atras.Enabled = false;
            btn_ultimo.Enabled = false;
            btn_imprimir.Enabled = false;
            btn_modificar.Enabled = false;
            btn_insertar.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.RecibidorInsertar != null)
                this.RecibidorInsertar(this, e);
            //btn_actualizar.Enabled = true;
            //btn_eliminar.Enabled = true;
            //btn_modificar.Enabled = true;
            //btn_guardar.Enabled = true;
            
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.RecibidorInsertar != null)
                this.RecibidorInsertar(this, e);

        }

        private void Navegador_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.RecibidorActualizar != null)
                this.RecibidorActualizar(this, e);
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.RecibidorEliminar != null)
                this.RecibidorEliminar(this, e);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (iPosicion == 0)
            {
                iPosicion = 0;
            }
            else if (iPosicion > 0)
            {
                iPosicion--;
            }
            getDatoManipulable(iPosicion);
            if (this.RecibidorAnterior != null)
                this.RecibidorAnterior(this, e);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            iPosicion = iFilastotal - 1;
            getDatoManipulable(iPosicion);
            if (this.RecibidorUltimo != null)
                this.RecibidorUltimo(this, e);
        }

        public void getDatoManipulable(int posicion) {
            String resultado = "";
            con = new Conector(sServidor,sNombreBD,sUsuario,sPass);
            con.OpenConnection();
            DataTable res = con.informacion("Select * FROM " + sNombreTabla);
            DataSet data = new DataSet("NAV");
            data.Tables.Add(res);
            iFilastotal = data.Tables[0].Rows.Count;
            iColumnasTotal = data.Tables[0].Columns.Count;
            for (int i = 0; i < iColumnasTotal; i++)
            {
                resultado += data.Tables[0].Rows[iPosicion][i].ToString();
            }
            MessageBox.Show("Dato : " + resultado);
            this.sResult = resultado;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            iPosicion++;
            getDatoManipulable(iPosicion);
            if (this.RecibidorSiguiente != null)
                this.RecibidorSiguiente(this, e);

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (this.RecibidorInsertar != null)
                this.RecibidorInsertar(this, e);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //btn_adelante.Enabled = true;
            //btn_primero.Enabled = true;
            //btn_atras.Enabled = true;
            //btn_ultimo.Enabled = true;
            //btn_imprimir.Enabled = true;
            //btn_modificar.Enabled = true;
        }

        private void btn_primero_Click(object sender, EventArgs e)
        {
            iPosicion = iFilastotal - 1;
            getDatoManipulable(iPosicion);
            if (this.RecibidorPrimero != null)
                this.RecibidorPrimero(this, e);
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            if (this.RecibidorActualizar != null)
                this.RecibidorActualizar(this, e);
        }
    }
}
