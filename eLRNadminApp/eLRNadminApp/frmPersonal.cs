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
        private static string vnom1, vnom2, ape1, ape2, nit, dpi, fCre, tel, emerg, vemail, naca, dir, vedad, banco;

        private void cmb_dept_SelectedValueChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show(cmb_per.SelectedItem.ToString());
            try
            {
                foreach (Objeto.Departamentos dept in lDept)
                {
                    if (dept.NombreDepto.Equals(cmb_dept.SelectedItem.ToString()))
                    {
                        MessageBox.Show(dept.IdDepto + dept.NombreDepto);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmb_per_SelectedValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show(cmb_per.SelectedItem.ToString());
            try
            {
                foreach (Objeto.TipoPersonal tpersona in ltpPer)
                {
                    if (tpersona.NombrePersonal.Equals(cmb_per.SelectedItem.ToString()))
                    {
                        MessageBox.Show(tpersona.IdPesonal + tpersona.NombrePersonal);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        List<Objeto.PaisUser> lPais = new List<Objeto.PaisUser>();
        List<Objeto.Departamentos> lDept = new List<Objeto.Departamentos>();
        List<Objeto.TipoPersonal> ltpPer = new List<Objeto.TipoPersonal>();
        List<Objeto.NumTel> lNum = new List<Objeto.NumTel>();
        List<Objeto.Email> lEmail = new List<Objeto.Email>();
        Objeto.PaisUser paisObj = null;

        private void cmb_pais_SelectedValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show(cmb_pais.SelectedItem.ToString());
            try
            { 
                Objeto.PaisUser auxPais = new Objeto.PaisUser(0, cmb_pais.SelectedItem.ToString());
                foreach(Objeto.PaisUser pais in lPais)
                {
                    if (pais.PaisNombre.Equals(cmb_pais.SelectedItem.ToString()))
                    {
                        MessageBox.Show(pais.PaisNombre+pais.IdPais);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void navegador1_RecibidorInsertar(object sender, EventArgs e)
        {

        }

        private void getPersonalData()
        {
            try
            {
                // LLenar datagridview con el personal general existente
                String qString = @"select concat(p.id_reg, p.id_per) as ID, p.nom_per as Nombres, p.ape_per as Apellidos, p.fecha_creado as Creado, p.fecha_nac as Nacimiento, d.nom_dept as Departamento, ps.nom_p as Pais, p.dir_per as Domicilio, t.nom_tipo as Personal
                from personal_reg as p, dept as d, pais as ps, tipo_personal as t where p.id_dept = d.id_dept and p.id_pais = ps.id_pais and p.id_tipo = t.id_tipo";

                dataGridView1.DataSource = Objeto.dbAccess.selectQ(qString);

                qString = @"select id_pais, nom_p from pais";
                DataTable dt = Objeto.dbAccess.selectQ(qString);

                //Cargar datos a los objetvos comboBox para paises
                foreach (DataRow row in dt.Rows)
                {
                    paisObj = new Objeto.PaisUser((int)row[0], (string)row[1]);
                    lPais.Add(paisObj);
                }
                foreach (Objeto.PaisUser objtPais in lPais)
                {
                    cmb_pais.Items.Add(objtPais.PaisNombre);
                }

                //Combobox para ingresar tipo de personal
                qString = @"select id_tipo, nom_tipo from tipo_personal";
                dt = Objeto.dbAccess.selectQ(qString);
                foreach (DataRow row in dt.Rows)
                {
                    Objeto.TipoPersonal tpPer = new Objeto.TipoPersonal((int)row[0], (string)row[1]);
                    ltpPer.Add(tpPer);
                }
                foreach (Objeto.TipoPersonal objtTper in ltpPer)
                {
                    cmb_per.Items.Add(objtTper.NombrePersonal);
                }

                //ComboBox con datos de departamentos
                qString = @"select id_dept, nom_dept from dept";
                dt = Objeto.dbAccess.selectQ(qString);
                foreach (DataRow row in dt.Rows)
                {
                    Objeto.Departamentos dept = new Objeto.Departamentos((int)row[0], (string)row[1]);
                    lDept.Add(dept);
                }
                foreach (Objeto.Departamentos objDept in lDept)
                {
                    cmb_dept.Items.Add(objDept.NombreDepto);
                }

                //ComboBox con los numeros telefonicos del personal
                qString = @"select t.id_tel, t.area_code from telefono as t, personal_reg as p where concat(t.reg_id_reg, t.reg_id_per) = '"+lbl_perid.Text+"' ";
                dt = Objeto.dbAccess.selectQ(qString);
                foreach (DataRow row in dt.Rows)
                {
                    Objeto.NumTel telobj = new Objeto.NumTel((string)row[0], (string)row[1]);
                    lNum.Add(telobj);
                }
                foreach (Objeto.NumTel objNum in lNum)
                {
                    cmb_num.Items.Add(objNum.IdNumero);

                }

                //ComboBox con los correos del personal
                qString = @"SELECT m.id_email FROM email_reg as m where concat(m.reg_id_reg, m.reg_id_per) = '" + lbl_perid.Text + "' ";
                dt = Objeto.dbAccess.selectQ(qString);
                foreach (DataRow row in dt.Rows)
                {
                    Objeto.Email emailobj = new Objeto.Email((string)row[0]);
                    lEmail.Add(emailobj);
                }
                foreach (Objeto.Email objEmail in lEmail)
                {
                    cmb_email.Items.Add(objEmail.IdEmail);

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmEmpleados_MouseMove(object sender, MouseEventArgs e)
        {
            navegador1.sNombreTabla = "";
            try
            {
                //dpi = txtDpi.Text;
                //nit = txtNit.Text;
                //nom1 = txtnom1.Text;
                //nom2 = txtnombre2.Text;
                //ape1 = txtape1.Text;
                //ape2 = txtape2.Text;
                //tel = txttel.Text;
                //emerg = txtemerg.Text;
                //email = txtemail.Text;
                //edad = txtedad.Text;
                //lbl_id_emp.Text;
                //banco = txtIdbanco.Text;
                //cta = txtnocta.Text;
                //nivel = txtnivel.Text;
                //fechaC = txtfCre.Text;
                //dire = txtDire.Text;
               //query =  @"insert into empleado(dpi, nit, primerNombre, segundoNombre, apellidoPaterno, apellidoMaterno, edad, email, contactoEmergencia, telefono, direccionDomicilio, fechaCreacionEmpleado, nivelAcedemico, noCuenta, cuentabanco_idBanco)
            //values ('" + dpi + "', '" + nit + "', '" + nom1 + "', '" + nom2 + "', '" + ape1 + "', '" + ape2 + "', '" + edad + "', '" + email + "', '" + emerg + "', '" + tel + "', '" + dir + "', '" + fechaC + "', '" + nivel + "', '" + cta + "', '" + banco + "')";
            }
            catch (Exception ex) { navegador1.sNombreTabla = "";}
        }

        public static string nivel, fechaC, dire = null;

        private void navegador1_MouseHover(object sender, EventArgs e)
        {
            navegador1.sNombreTabla = "";
            try
            {
                //dpi = txtDpi.Text;
                //nit = txtNit.Text;
                //nom1 = txtnom1.Text;
                //nom2 = txtnombre2.Text;
                //ape1 = txtape1.Text;
                //ape2 = txtape2.Text;
                //tel = txttel.Text;
                //emerg = txtemerg.Text;
                //email = txtemail.Text;
                //edad = txtedad.Text;
                //lbl_id_emp.Text;
                //banco = txtIdbanco.Text;
                //cta = txtnocta.Text;
                //nivel = txtnivel.Text;
                //fechaC = txtfCre.Text;
                //dire = txtDire.Text;
               //query =  @"insert into empleado(dpi, nit, primerNombre, segundoNombre, apellidoPaterno, apellidoMaterno, edad, email, contactoEmergencia, telefono, direccionDomicilio, fechaCreacionEmpleado, nivelAcedemico, noCuenta, cuentabanco_idBanco)
            //values ('" + dpi + "', '" + nit + "', '" + nom1 + "', '" + nom2 + "', '" + ape1 + "', '" + ape2 + "', '" + edad + "', '" + email + "', '" + emerg + "', '" + tel + "', '" + dir + "', '" + fechaC + "', '" + nivel + "', '" + cta + "', '" + banco + "')";
            }
            catch (Exception ex) { /*Navegador.Navegador.nombreTabla = ""; */}
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.Rows[e.RowIndex] != null)
                {
                    lbl_perid.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                    txtnom1.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
                    txtnombre2.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
                    dtP_1.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
                    dtP_2.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[4].Value);
                    txtDire.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[7].Value);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message+ex.Source); }
        }

        //public static int edad, idB, idcta, idEmp= 0;
        public frmPersonal()
        {
            InitializeComponent();
            getPersonalData();
            blockTxt();
        }
        
        private void blockTxt()
        {
            txtDire.Enabled = false;
            txtnom1.Enabled = false;
            txtnombre2.Enabled = false;
            txt_area.Enabled = false;
            txt_num.Enabled = false;
        }
    }
}
