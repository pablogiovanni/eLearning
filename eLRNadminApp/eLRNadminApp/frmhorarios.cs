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
    public partial class frmhorarios : Form
    {
        private static string nomApp = "Horario"; //Nombre de la aplicacion
        private static int idApp = 2;
        public static int appId { get; }
        private static string sIdReg, sNomNot = ""; //sIdReg = Id de registro de personal EJ. empleado = emp; catedratico = cat
        private static Int32 iIdPer = 0; //iIdPer = Id(autoincremento de tabla personal_reg) de personal 
        private static Int32 iIdEmp = 0; //iIdEmp = Id(Autoincremento de table empleado) de empleado
        private static Int32 cat_id_cat = 0;
        private static Int32 iIdHorario = 0; //ID autoincremento
        public frmhorarios()
        {
            InitializeComponent();
            sIdReg = Objeto.Common.regPLogin; // Se obtiene el id de registro de personal
            iIdPer = Objeto.Common.idPLogin; // Se obtiene el id de personal
            navegador1.setSecProfile(nomApp); // se envía parametro de nombre de aplicacion a la barra de navegacion
            getIdCat();
            getHorarios(); // Metodo que obtiene las noticias en las que el campo "estado" = 1

            navegador1.sNombreBD = Objeto.Common.dbName;
            navegador1.sNombreTabla = "horario";
            navegador1.sServidor = Objeto.Common.dbServerIP;
            navegador1.sPass = Objeto.Common.dbPass;
            navegador1.sUsuario = Objeto.Common.dbUser;
        }

        private void getIdCat() //metodo que obtiene el ID de catedrático en base al id personal y id registro personal
        {
            try
            {
                sIdReg = Objeto.Common.regPLogin;
                iIdPer = Objeto.Common.idPLogin;

                string qString = @"select e.id_cat from catedratico as e, personal_reg as p where p.id_per = '" + iIdPer + "' and e.personal_id_per = p.id_per";
                DataTable dt = Objeto.dbAccess.selectQ(qString);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        iIdEmp = (int)row[0]; //se halla el id empleado de la tabla de empleado en base al id personal y id de registro personal
                    }
                    cat_id_cat = iIdEmp;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "E-Learning"); }
        }

        private void getHorarios()
        {
            // LLenar datagridview con las noticias existentes
            String qString = @"select h.id_horario as ID, h.curso_id_curso as Curso, h.curso_id_carrera as Carrera, h.curso_id_fac as Facultad, h.cat_id_cat as Catedratico,h.salon_id_salon as Salon, h.salon_edificio_id_ed as Edificio, 
                                h.domingo as D, h.lunes as L, h.martes as M, h.miercoles as MI,h.jueves as J, h.viernes as V, h.sabado as S, h.seccion as Sec,h.hora_ini as Inicio,h.hora_fin as Fin,h.estado as Es from horario h where h.estado = 1";

            if (Controlador.EvalSec.consultar(nomApp, Objeto.Common.SEC_CONSULTAR) == 1)
            {
               dgvHorarios.DataSource = Objeto.dbAccess.selectQ(qString);
            }
        }

        private void dgvHorarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvHorarios.Rows[e.RowIndex] != null)
                {
                    tbID.Text = dgvHorarios.Rows[e.RowIndex].Cells[0].Value.ToString();
                   // iIdNoticia = int.Parse(Dgv_noticias.Rows[e.RowIndex].Cells[0].Value.ToString());
                    tbCurso.Text = dgvHorarios.Rows[e.RowIndex].Cells[1].Value.ToString();
                    tbCarrera.Text = dgvHorarios.Rows[e.RowIndex].Cells[2].Value.ToString();
                    tbCarrera.Text = dgvHorarios.Rows[e.RowIndex].Cells[3].Value.ToString();
                    tbFacultad.Text = dgvHorarios.Rows[e.RowIndex].Cells[4].Value.ToString();
                    tbCatedratico.Text = dgvHorarios.Rows[e.RowIndex].Cells[5].Value.ToString();
                    tbSalon.Text = dgvHorarios.Rows[e.RowIndex].Cells[6].Value.ToString();
                    tbEdificio.Text = dgvHorarios.Rows[e.RowIndex].Cells[7].Value.ToString();
                    tbDomingo.Text = dgvHorarios.Rows[e.RowIndex].Cells[8].Value.ToString();
                    tbLunes.Text = dgvHorarios.Rows[e.RowIndex].Cells[9].Value.ToString();
                    tbMartes.Text = dgvHorarios.Rows[e.RowIndex].Cells[10].Value.ToString();
                    tbMiercoles.Text = dgvHorarios.Rows[e.RowIndex].Cells[11].Value.ToString();
                    tbJueves.Text = dgvHorarios.Rows[e.RowIndex].Cells[12].Value.ToString();
                    tbViernes.Text = dgvHorarios.Rows[e.RowIndex].Cells[13].Value.ToString();
                    tbSabado.Text = dgvHorarios.Rows[e.RowIndex].Cells[14].Value.ToString();
                    tbSeccion.Text = dgvHorarios.Rows[e.RowIndex].Cells[15].Value.ToString();
                    dtI.Text = dgvHorarios.Rows[e.RowIndex].Cells[16].Value.ToString();
                    dtF.Text = dgvHorarios.Rows[e.RowIndex].Cells[17].Value.ToString();

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

                tbID.Text = token[0];
                tbCurso.Text = token[1];
                tbCarrera.Text = token[2];
                tbFacultad.Text = token[3];
                tbCatedratico.Text = token[4];
                tbSalon.Text = token[5];
                tbEdificio.Text = token[6];
                tbDomingo.Text = token[7];
                tbLunes.Text = token[8];
                tbMartes.Text = token[9];
                tbMiercoles.Text = token[10];
                tbJueves.Text = token[11];
                tbViernes.Text = token[12];
                tbSabado.Text = token[13];
                tbSeccion.Text = token[14];
                dtI.Text = token[15];
                dtF.Text = token[16];

            }
            catch (Exception ex) { }
        }

        private void navegador1_RecibidorSiguiente(object sender, EventArgs e)
        {
            try
            {
                string resultado = navegador1.sResult;
                string[] token = resultado.Split(',');

                tbID.Text = token[0];
                tbCurso.Text = token[1];
                tbCarrera.Text = token[2];
                tbFacultad.Text = token[3];
                tbCatedratico.Text = token[4];
                tbSalon.Text = token[5];
                tbEdificio.Text = token[6];
                tbDomingo.Text = token[7];
                tbLunes.Text = token[8];
                tbMartes.Text = token[9];
                tbMiercoles.Text = token[10];
                tbJueves.Text = token[11];
                tbViernes.Text = token[12];
                tbSabado.Text = token[13];
                tbSeccion.Text = token[14];
                dtI.Text = token[15];
                dtF.Text = token[16];
            }
            catch (Exception ex) { }
        }

        private void navegador1_RecibidorPrimero(object sender, EventArgs e)
        {
            try
            {
                string resultado = navegador1.sResult;
                string[] token = resultado.Split(',');

                tbID.Text = token[0];
                tbCurso.Text = token[1];
                tbCarrera.Text = token[2];
                tbFacultad.Text = token[3];
                tbCatedratico.Text = token[4];
                tbSalon.Text = token[5];
                tbEdificio.Text = token[6];
                tbDomingo.Text = token[7];
                tbLunes.Text = token[8];
                tbMartes.Text = token[9];
                tbMiercoles.Text = token[10];
                tbJueves.Text = token[11];
                tbViernes.Text = token[12];
                tbSabado.Text = token[13];
                tbSeccion.Text = token[14];
                dtI.Text = token[15];
                dtF.Text = token[16];
            }
            catch (Exception ex) { }
        }

        private void navegador1_RecibidorUltimo(object sender, EventArgs e)
        {
            try
            {
                string resultado = navegador1.sResult;
                string[] token = resultado.Split(',');

                tbID.Text = token[0];
                tbCurso.Text = token[1];
                tbCarrera.Text = token[2];
                tbFacultad.Text = token[3];
                tbCatedratico.Text = token[4];
                tbSalon.Text = token[5];
                tbEdificio.Text = token[6];
                tbDomingo.Text = token[7];
                tbLunes.Text = token[8];
                tbMartes.Text = token[9];
                tbMiercoles.Text = token[10];
                tbJueves.Text = token[11];
                tbViernes.Text = token[12];
                tbSabado.Text = token[13];
                tbSeccion.Text = token[14];
                dtI.Text = token[15];
                dtF.Text = token[16];
            }
            catch (Exception ex) { }
        }
        private bool emptyFields()
        {
            if ((string.IsNullOrEmpty(tbID.Text)) || (string.IsNullOrEmpty(tbCurso.Text)) || (string.IsNullOrEmpty(tbCarrera.Text)) || (string.IsNullOrEmpty(tbFacultad.Text)) || (string.IsNullOrEmpty(tbCatedratico.Text)) || (string.IsNullOrEmpty(tbSalon.Text)) || (string.IsNullOrEmpty(tbEdificio.Text)) || (string.IsNullOrEmpty(tbDomingo.Text)) || (string.IsNullOrEmpty(tbLunes.Text)) || (string.IsNullOrEmpty(tbMartes.Text)) || (string.IsNullOrEmpty(tbMiercoles.Text)) || (string.IsNullOrEmpty(tbJueves.Text)) || (string.IsNullOrEmpty(tbViernes.Text)) || (string.IsNullOrEmpty(tbSabado.Text)) || (string.IsNullOrEmpty(tbSeccion.Text)) || (string.IsNullOrEmpty(dtI.Text)) || (string.IsNullOrEmpty(dtF.Text)))
            {
                return true;
            }
            return false;
        }
        private void navegador1_RecibidorActualizar(object sender, EventArgs e)
        {
            try
            {
                if (!emptyFields())
                {
                    //sNomNot = txt_nom_not.Text; //sNomNot = valor del campo de texto que tiene el nuevo valor del nombre de la noticia
                    string dt1 = DateTime.Parse(dtI.Text).ToString("Hh"); //Convertir la fecha para mysql
                    string dt2 = DateTime.Parse(dtF.Text).ToString("Hh"); //Convertir la fecha para mysql


                    ArrayList listaCampos = new ArrayList();
                    listaCampos.Add("nom_noticia");
                    listaCampos.Add("fecha_creado");
                    listaCampos.Add("fecha_noticia");

                    ArrayList listaValores = new ArrayList();
                    listaValores.Add(sNomNot);
                    listaValores.Add(dt1);
                    listaValores.Add(dt2);

                    Navegador.Utilidades.GeneradorSQL sqlGen = new Navegador.Utilidades.GeneradorSQL(Objeto.Common.dbServerIP, Objeto.Common.dbName, Objeto.Common.dbUser, Objeto.Common.dbPass, "horario");
                    sqlGen.setCodigoInstDML(2);
                    //sqlGen.setComparacion("id_noticia", iIdNoticia.ToString());
                    sqlGen.setCampos(listaCampos);
                    sqlGen.setValores(listaValores);
                    sqlGen.ejecutar();
                    getHorarios();
                }
                else { MessageBox.Show("Llenar los campos de texto!", "E-Learning"); }
            }
            catch (Exception ex) { }
        }

        private void frmhorarios_Load(object sender, EventArgs e)
        {

        }
    }
}
