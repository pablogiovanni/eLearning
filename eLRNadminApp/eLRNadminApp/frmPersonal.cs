using System;
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
    public partial class frmPersonal : Form
    {
        private static int idApp = 2;
        public static int appId { get; }
        private static string nom1, nom2, ape1, ape2, nit, dpi, fCre, tel, emerg, email, naca, dir, edad, banco, cta= null;

        private void navegador1_RecibidorInsertar(object sender, EventArgs e)
        {

        }

        private void getPersonalData()
        {
            String qString = @"select concat(p.id_per, p.id_reg) as ID, p.nom_per as Nombres, p.ape_per as Apellidos, p.fecha_creado as Creado, p.fecha_nac as Nacimiento, d.nom_dept as Departamento, ps.nom_p as Pais, p.dir_per as Domicilio, t.nom_tipo as Personal
                from personal_reg as p, dept as d, pais as ps, tipo_personal as t where p.id_dept = d.id_dept and p.id_pais = ps.id_pais and p.id_tipo = t.id_tipo";

            dataGridView1.DataSource = Objeto.dbAccess.selectQ(qString);

            qString = @"select id_pais, nom_p from pais";
            DataTable dt = Objeto.dbAccess.selectQ(qString);
            List<Objeto.PaisUser> lPais = new List<Objeto.PaisUser>();
            Objeto.PaisUser paisObj = null;

            foreach (DataRow row in dt.Rows)
            {
                //cmb_pais.Items.Add(row[1]);
                paisObj = new Objeto.PaisUser((int)row[0], (string)row[1]);
                lPais.Add(paisObj);
            }
        }

        public static string query = @"insert into empleado(dpi, nit, primerNombre, segundoNombre, apellidoPaterno, apellidoMaterno, edad, email, contactoEmergencia, telefono, direccionDomicilio, fechaCreacionEmpleado, nivelAcedemico, noCuenta, cuentabanco_idBanco)
            values ('"+dpi+ "', '"+nit+ "', '"+nom1+ "', '"+nom2+ "', '"+ape1+ "', '"+ape2+"', '"+edad+ "', '"+email+ "', '"+emerg+ "', '"+tel+ "', '"+dir+ "', '"+fechaC+ "', '"+nivel+ "', '"+cta+ "', '"+banco+"')";

        private void frmEmpleados_MouseMove(object sender, MouseEventArgs e)
        {
            navegador1.sNombreTabla = "";
            try
            {
                //dpi = txtDpi.Text;
                //nit = txtNit.Text;
                nom1 = txtnom1.Text;
                nom2 = txtnombre2.Text;
                //ape1 = txtape1.Text;
                //ape2 = txtape2.Text;
                //tel = txttel.Text;
                //emerg = txtemerg.Text;
                email = txtemail.Text;
                edad = txtedad.Text;
                //lbl_id_emp.Text;
                //banco = txtIdbanco.Text;
                //cta = txtnocta.Text;
                //nivel = txtnivel.Text;
                //fechaC = txtfCre.Text;
                dire = txtDire.Text;
               query =  @"insert into empleado(dpi, nit, primerNombre, segundoNombre, apellidoPaterno, apellidoMaterno, edad, email, contactoEmergencia, telefono, direccionDomicilio, fechaCreacionEmpleado, nivelAcedemico, noCuenta, cuentabanco_idBanco)
            values ('" + dpi + "', '" + nit + "', '" + nom1 + "', '" + nom2 + "', '" + ape1 + "', '" + ape2 + "', '" + edad + "', '" + email + "', '" + emerg + "', '" + tel + "', '" + dir + "', '" + fechaC + "', '" + nivel + "', '" + cta + "', '" + banco + "')";
            }
            catch (Exception ex) { navegador1.sNombreTabla = "";}
        }

        public static string nivel, fechaC, dire = null;
        //public static int edad, banco, cta = 0;

        private void navegador1_MouseHover(object sender, EventArgs e)
        {
            navegador1.sNombreTabla = "";
            try
            {
                //dpi = txtDpi.Text;
                //nit = txtNit.Text;
                nom1 = txtnom1.Text;
                nom2 = txtnombre2.Text;
                //ape1 = txtape1.Text;
                //ape2 = txtape2.Text;
                //tel = txttel.Text;
                //emerg = txtemerg.Text;
                email = txtemail.Text;
                edad = txtedad.Text;
                //lbl_id_emp.Text;
                //banco = txtIdbanco.Text;
                //cta = txtnocta.Text;
                //nivel = txtnivel.Text;
                //fechaC = txtfCre.Text;
                dire = txtDire.Text;
               query =  @"insert into empleado(dpi, nit, primerNombre, segundoNombre, apellidoPaterno, apellidoMaterno, edad, email, contactoEmergencia, telefono, direccionDomicilio, fechaCreacionEmpleado, nivelAcedemico, noCuenta, cuentabanco_idBanco)
            values ('" + dpi + "', '" + nit + "', '" + nom1 + "', '" + nom2 + "', '" + ape1 + "', '" + ape2 + "', '" + edad + "', '" + email + "', '" + emerg + "', '" + tel + "', '" + dir + "', '" + fechaC + "', '" + nivel + "', '" + cta + "', '" + banco + "')";
            }
            catch (Exception ex) { /*Navegador.Navegador.nombreTabla = ""; */}
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.Rows[e.RowIndex] != null)
                {
                    //txtDpi.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
                    //txtNit.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
                    txtnom1.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
                    txtnombre2.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[4].Value);
                    //txtape1.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[5].Value);
                    //txtape2.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[6].Value);
                    //txttel.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[10].Value);
                    //txtemerg.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[9].Value);
                    txtemail.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[8].Value);
                    txtedad.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[7].Value);
                    lbl_id_emp.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                    //txtIdbanco.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[15].Value);
                    //txtnocta.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[14].Value);
                    //txtnivel.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[13].Value);
                    //txtfCre.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[12].Value);
                    txtDire.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[11].Value);
                    //navegador1.nombreTabla = "empleado";

                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        //public static int edad, idB, idcta, idEmp= 0;
        public frmPersonal()
        {
            InitializeComponent();
            getPersonalData();
        }
    }
}
