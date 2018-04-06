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
    public partial class frmPersonal : Form
    {
        private static string nomApp = "Personal";
        private static int idApp = 2;
        public static int appId { get; }
        private static string sIdReg, sNon, sApe, sDir, sTel, sArea, sEmail, sRegId = "";
        private int sPais = -1;
        private int sPers = -1;
        private int sDept = -1;
        private Int32 iIdPer = 0;
        private Int16 iRbtn = 0;

        private void cmb_dept_SelectedValueChanged(object sender, EventArgs e)
        {
            //System.Windows.Forms.MessageBox.Show(cmb_per.SelectedItem.ToString());
            try
            {
                foreach (Objeto.Departamentos dept in lDept)
                {
                    if (dept.NombreDepto.Equals(cmb_dept.SelectedItem.ToString()))
                    {
                        MessageBox.Show(dept.IdDepto + dept.NombreDepto);
                        sDept = dept.IdDepto;
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
            //MessageBox.Show(cmb_per.SelectedItem.ToString());
            try
            {
                foreach (Objeto.TipoPersonal tpersona in ltpPer)
                {
                    if (tpersona.NombrePersonal.Equals(cmb_per.SelectedItem.ToString()))
                    {
                        MessageBox.Show(tpersona.IdPesonal + tpersona.NombrePersonal);
                        sPers = tpersona.IdPesonal;
                        if (tpersona.NombrePersonal.Equals("Administrativo")) { sIdReg = "emp"; }
                        if (tpersona.NombrePersonal.Equals("Operativo")) { sIdReg = "emp"; }
                        if (tpersona.NombrePersonal.Equals("Alumno")) { sIdReg = "alu"; }
                        if (tpersona.NombrePersonal.Equals("Catedratico")) { sIdReg = "cat"; }
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

        private void navegador1_RecibidorActualizar(object sender, EventArgs e)
        {
            if (Controlador.EvalSec.consultar("Personal", Objeto.Common.SEC_EDITAR) == 1)
            {
                try
                {
                    if ((selectedCombo()) && (!emptyFields()))
                        {
                            //MessageBox.Show("Seleccionar elemento en ComboBox", "Registro de Personal");
                            sNon = txtnom1.Text;
                            sApe = txtnombre2.Text;
                            sDir = txtDire.Text;
                            string aux1 = dtP_1.Text;
                            string dt1 = DateTime.Parse(aux1).ToString("yyyy/MM/dd");
                            string aux2 = dtP_2.Text;
                            string dt2 = DateTime.Parse(aux2).ToString("yyyy/MM/dd");

                            ArrayList listacampos = new ArrayList();
                            //listacampos.Add("id_reg");
                            listacampos.Add("nom_per");
                            listacampos.Add("ape_per");
                            listacampos.Add("dir_per");
                            listacampos.Add("fecha_creado");
                            listacampos.Add("fecha_nac");
                            listacampos.Add("id_dept");
                            listacampos.Add("id_pais");
                            listacampos.Add("id_tipo");

                            ArrayList listavalores = new ArrayList();
                            //listavalores.Add(sIdReg);
                            listavalores.Add(sNon);
                            listavalores.Add(sApe);
                            listavalores.Add(sDir);
                            listavalores.Add(dt1);
                            listavalores.Add(dt2);
                            listavalores.Add(sDept);
                            listavalores.Add(sPais);
                            listavalores.Add(sPers);

                            Navegador.Utilidades.GeneradorSQL sqlGen = new Navegador.Utilidades.GeneradorSQL(Objeto.Common.dbServerIP, Objeto.Common.dbName, Objeto.Common.dbUser, Objeto.Common.dbPass, "personal_reg");
                            sqlGen.setCodigoInstDML(2);
                            sqlGen.setComparacion("id_per", iIdPer.ToString());
                            sqlGen.setCampos(listacampos);
                            sqlGen.setValores(listavalores);
                            sqlGen.ejecutar();
                        }else { MessageBox.Show("LLenar los campos y selecciones de datos para ingresar!", "E-Learning"); }
                }
                catch(Exception ex) { MessageBox.Show(ex.Message, "E-Learning"); }    
            }
        }

        private void btn_tel_Click(object sender, EventArgs e)
        {
            txt_area.Enabled = true;
            txt_area.Text = "";
            txt_num.Enabled = true;
            txt_num.Text = "";
        }

        private void btn_email_Click(object sender, EventArgs e)
        {
            txt_email.Enabled = true;
            txt_email.Text = "";
        }

        List<Objeto.NumTel> lNum = new List<Objeto.NumTel>();
        List<Objeto.Email> lEmail = new List<Objeto.Email>();
        Objeto.PaisUser paisObj = null;

        private void cmb_pais_SelectedValueChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(cmb_pais.SelectedItem.ToString());
            try
            { 
                Objeto.PaisUser auxPais = new Objeto.PaisUser(0, cmb_pais.SelectedItem.ToString());
                foreach(Objeto.PaisUser pais in lPais)
                {
                    if (pais.PaisNombre.Equals(cmb_pais.SelectedItem.ToString()))
                    {
                        MessageBox.Show(pais.PaisNombre+pais.IdPais);
                        sPais = pais.IdPais;
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
            if (Controlador.EvalSec.consultar("Personal", Objeto.Common.SEC_INGRESAR) == 1)
            {
                if (rbtn_first.Checked)
                {
                    try
                    {
                        blockTxtEmailNum(0);
                        navegador1.sNombreBD = "elearningdb";
                        navegador1.sNombreTabla = "personal_reg";
                        navegador1.sServidor = "127.0.0.1";
                        navegador1.sUsuario = "elearn";
                        navegador1.sPass = "$ele@rn$";

                        if ((selectedCombo()) && (!emptyFields()))
                        {
                            //MessageBox.Show("Seleccionar elemento en ComboBox", "Registro de Personal");
                            sNon = txtnom1.Text;
                            sApe = txtnombre2.Text;
                            sDir = txtDire.Text;
                            string aux1 = dtP_1.Text;
                            string dt1 = DateTime.Parse(aux1).ToString("yyyy/MM/dd");
                            string aux2 = dtP_2.Text;
                            string dt2 = DateTime.Parse(aux2).ToString("yyyy/MM/dd");

                            ArrayList listacampos = new ArrayList();
                            listacampos.Add("id_reg");
                            listacampos.Add("nom_per");
                            listacampos.Add("ape_per");
                            listacampos.Add("dir_per");
                            listacampos.Add("fecha_creado");
                            listacampos.Add("fecha_nac");
                            listacampos.Add("id_dept");
                            listacampos.Add("id_pais");
                            listacampos.Add("id_tipo");

                            ArrayList listavalores = new ArrayList();
                            listavalores.Add(sIdReg);
                            listavalores.Add(sNon);
                            listavalores.Add(sApe);
                            listavalores.Add(sDir);
                            listavalores.Add(dt1);
                            listavalores.Add(dt2);
                            listavalores.Add(sDept);
                            listavalores.Add(sPais);
                            listavalores.Add(sPers);

                            Navegador.Utilidades.GeneradorSQL sqlGen = new Navegador.Utilidades.GeneradorSQL(Objeto.Common.dbServerIP, Objeto.Common.dbName, Objeto.Common.dbUser, Objeto.Common.dbPass, "personal_reg");
                            sqlGen.setCodigoInstDML(1);
                            sqlGen.setCampos(listacampos);
                            sqlGen.setValores(listavalores);
                            sqlGen.ejecutar();
                        }else { MessageBox.Show("LLenar los campos y selecciones de datos para ingresar!", "E-Learning"); }
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                }

                if (rbtn_second.Checked)
                {
                    try
                    {
                        if (!emptyTxtNum())
                        {
                            string sArea, sNum = "";
                            sArea = txt_area.Text;
                            sNum = txt_num.Text;

                            ArrayList listacamposN = new ArrayList();
                            listacamposN.Add("id_tel");
                            listacamposN.Add("area_code");
                            listacamposN.Add("reg_id_per");
                            listacamposN.Add("reg_id_reg");

                            ArrayList listValN = new ArrayList();
                            listValN.Add(sNum);
                            listValN.Add(sArea);
                            listValN.Add(iIdPer);
                            listValN.Add(sIdReg);

                            Navegador.Utilidades.GeneradorSQL sqlGen = new Navegador.Utilidades.GeneradorSQL(Objeto.Common.dbServerIP, Objeto.Common.dbName, Objeto.Common.dbUser, Objeto.Common.dbPass, "telefono");
                            sqlGen.setCodigoInstDML(1);
                            sqlGen.setCampos(listacamposN);
                            sqlGen.setValores(listValN);
                            sqlGen.ejecutar();
                        }

                    }
                    catch (Exception ex) { }
                }

                if (rbtn_third.Checked)
                {
                    try
                    {
                        if (!emptyTxtEmail())
                        {
                            string sEmail = "";
                            sEmail = txt_email.Text;

                            ArrayList listacamposE = new ArrayList();
                            listacamposE.Add("id_email");
                            listacamposE.Add("reg_id_per");
                            listacamposE.Add("reg_id_reg");

                            ArrayList listValE = new ArrayList();
                            listValE.Add(sEmail);
                            listValE.Add(sRegId);
                            listValE.Add(sIdReg);
                        }
                    }
                    catch (Exception ex) { }
                }
            }else { MessageBox.Show("Usuario sin privilegios para ingresar personal!", "E-Learning"); }
        }

        private bool emptyFields()
        {
            if ((string.IsNullOrEmpty(txtDire.Text)) || (string.IsNullOrEmpty(txtnom1.Text)) || (string.IsNullOrEmpty(txtnombre2.Text)) )
            {
                return true;
            }
            return false;
        }

        private bool selectedCombo()
        {
            if( (cmb_dept.SelectedIndex >= 0) && (cmb_pais.SelectedIndex >=0) && (cmb_per.SelectedIndex >=0))
            {
                return true;
            }
            return false;
        }

        private bool emptyTxtNum()
        {
            if ((string.IsNullOrEmpty(txt_area.Text)) || (string.IsNullOrEmpty(txt_num.Text)) || (string.IsNullOrEmpty(sRegId)) || (iIdPer == 0))
            {
                return true;
            }
            return false;
        }

        private bool emptyTxtEmail()
        {
            if ( (string.IsNullOrEmpty(txt_area.Text)) || (string.IsNullOrEmpty(lbl_perid.Text)) || (string.IsNullOrEmpty(sRegId)) || (iIdPer == 0) )
            {
                return true;
            }
            return false;
        }

        private void blockTxtEmailNum(int aux)
        {
            if (aux == 0)
            {
                cmb_email.Enabled = false;
                txt_email.Enabled = false;
                txt_area.Enabled = false;
                txt_num.Enabled = false;
                cmb_num.Enabled = false;
            }else
            {
                cmb_email.Enabled = true;
                txt_email.Enabled = true;
                txt_area.Enabled = true;
                txt_num.Enabled = true;
                cmb_num.Enabled = true;
            }
        }

        private void getPersonalData()
        {
            try
            {
                // LLenar datagridview con el personal general existente
                String qString = @"select p.id_reg as ID, p.id_per as ID, p.nom_per as Nombres, p.ape_per as Apellidos, p.fecha_creado as Creado, p.fecha_nac as Nacimiento, d.nom_dept as Departamento, ps.nom_p as Pais, p.dir_per as Domicilio, t.nom_tipo as Personal
                from personal_reg as p, dept as d, pais as ps, tipo_personal as t where p.id_dept = d.id_dept and p.id_pais = ps.id_pais and p.id_tipo = t.id_tipo";
                if (Controlador.EvalSec.consultar("Personal", Objeto.Common.SEC_CONSULTAR) == 1)
                {
                    dataGridView1.DataSource = Objeto.dbAccess.selectQ(qString);
                }

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

        private void rbtn_third_CheckedChanged(object sender, EventArgs e)
        {
            rbtn_first.Checked = false;
            rbtn_second.Checked = false;
            blockTxt(0);
            blockTxtwNum(0);
            blockTxtwMail(1);
        }

        private void navegador1_RecibidorEliminar(object sender, EventArgs e)
        {
            if (Controlador.EvalSec.consultar("Personal", Objeto.Common.SEC_ELIMINAR) == 1)
            {

            }
        }

        private void navegador1_RecibidorAnterior(object sender, EventArgs e)
        {
            if (Controlador.EvalSec.consultar("Personal", Objeto.Common.SEC_CONSULTAR) == 1)
            {

            }
        }

        private void navegador1_RecibidorSiguiente(object sender, EventArgs e)
        {
            if (Controlador.EvalSec.consultar("Personal", Objeto.Common.SEC_CONSULTAR) == 1)
            {

            }
        }

        private void rbtn_second_CheckedChanged(object sender, EventArgs e)
        {
            rbtn_first.Checked = false;
            rbtn_third.Checked = false;
            blockTxtwMail(0);
            blockTxt(0);
            blockTxtwNum(1);
        }

        private void rbtn_first_CheckedChanged(object sender, EventArgs e)
        {
            rbtn_second.Checked = false;
            rbtn_third.Checked = false;
            blockTxtEmailNum(0);
            blockTxt(1);
        }

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
                    clearComboBoxMailNum();
                    sRegId = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                    iIdPer = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
                    txtnom1.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
                    txtnombre2.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
                    dtP_1.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[4].Value);
                    dtP_2.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[5].Value);
                    txtDire.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[8].Value);
                    lbl_perid.Text = sRegId + iIdPer;
                    getNumAndEmail();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message+ex.Source); }
        }

        public frmPersonal()
        {
            InitializeComponent();
            getPersonalData();
            navegador1.setSecProfile(nomApp);
            //blockTxt();
        }

        private void clearComboBoxMailNum()
        {
            if ((cmb_email.Items.Count > 0) && (cmb_num.Items.Count > 0))
            {
                cmb_email.Items.Clear();
                cmb_num.Items.Clear();
            }
        }
        
        private void blockTxt(int aux)
        {
            if (aux == 0)
            {
                txtDire.Enabled = false;
                txtnom1.Enabled = false;
                txtnombre2.Enabled = false;
                cmb_pais.Enabled = false;
                cmb_dept.Enabled = false;
                cmb_per.Enabled = false;
            }
            else
            {
                txtDire.Enabled = true;
                txtnom1.Enabled = true;
                txtnombre2.Enabled = true;
                cmb_pais.Enabled = true;
                cmb_dept.Enabled = true;
                cmb_per.Enabled = true;
            }
        }

        private void blockTxtwMail(int aux)
        {
            if (aux == 0)
            {
                cmb_email.Enabled = false;
                txt_email.Enabled = false;
            }
            else
            {
                cmb_email.Enabled = true;
                txt_email.Enabled = true;
            }
        }

        private void blockTxtwNum(int aux)
        {
            if (aux == 0)
            {
                txt_area.Enabled = false;
                txt_num.Enabled = false;
                cmb_num.Enabled = false;
            }
            else
            {
                txt_area.Enabled = true;
                txt_num.Enabled = true;
                cmb_num.Enabled = true;
            }
        }

        private void getNumAndEmail()
        {
            if( !(string.IsNullOrEmpty(lbl_perid.Text)) && !(lbl_perid.Text.Equals("-")) ){

                //ComboBox con los correos del personal

                string qString = @"SELECT m.id_email FROM email_reg as m , personal_reg as p where m.reg_id_per = p.id_per and m.reg_id_per = '" + iIdPer + "' ";
                DataTable dt = Objeto.dbAccess.selectQ(qString);
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

                //ComboBox con los numeros telefonicos del personal
                qString = @"select t.id_tel, t.area_code from telefono as t, personal_reg as p where t.reg_id_per = p.id_per and t.reg_id_per = '" + iIdPer + "' ";
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
            }
        } 
    }
}
