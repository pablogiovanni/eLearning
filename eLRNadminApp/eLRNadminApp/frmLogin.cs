using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eLRNadminApp.Controlador;

namespace eLRNadminApp
{
    public partial class frm_init : Form
    {
        public frm_init()
        {
            InitializeComponent();
            cerrarSesiónToolStripMenuItem.Enabled = false;
            blockMenu();
            clearPermissions();
            setParams("127.0.0.1", "elearningdb", "", "elearn", "$ele@rn$");
        }

        private void setParams(string ip, string name, string tablename, string user, string pass)
        {
            Objeto.Common.dbName = name;
            Objeto.Common.dbServerIP = ip;
            Objeto.Common.dbTableName = tablename;
            Objeto.Common.dbUser = user;
            Objeto.Common.dbPass = pass;
        }

        public void setUsrNameFrm()
        {
            this.Text = "SISTEMA DE ELEARNING   USUARIO:["+Globales.nom_usuario+"]"+"    ID:["+Objeto.Common.idPLogin+"]";
        }

        private void iniciarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login_frm = new Login();
            login_frm.MdiParent = this;
            login_frm.Show();
            cerrarSesiónToolStripMenuItem.Enabled = true;
            iniciarSesiónToolStripMenuItem.Enabled = false;
            unblockMenu();  
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cerrarSesiónToolStripMenuItem.Enabled = false;
            iniciarSesiónToolStripMenuItem.Enabled = true;
            blockMenu();
            clearPermissions();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Controlador.EvalSec.consultar("Usuario", Objeto.Common.SEC_CONSULTAR) == 1)
            {
                Usuarios usr_frm = new Usuarios();
                usr_frm.MdiParent = this;
                usr_frm.Show();
            }
            else { MessageBox.Show("Usuario sin privilegios para consular usuarios!", "E-Learning"); }
        }

        private void personalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Controlador.EvalSec.consultar("Personal", Objeto.Common.SEC_CONSULTAR) == 1)
            {
                try
                {
                    if (Objeto.Common.signedIn)
                    {
                        frmPersonal frmPrn = new frmPersonal("Personal");
                        frmPrn.MdiParent = this;
                        frmPrn.Show();
                    }
                    else { MessageBox.Show("Identificación de usuario inválida!", "e-Learning"); }
                }
                catch (Exception ex) { }
            }
            else { MessageBox.Show("Usuario sin privilegios para consular el persona!", "E-Learning"); }
        }

        private void alumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Controlador.EvalSec.consultar("Alumno", Objeto.Common.SEC_CONSULTAR) == 1) {
                try
                {
                    if (Objeto.Common.signedIn) {
                        frmPersonal frmAlu = new frmPersonal("Alumno");
                        frmAlu.MdiParent = this;
                        frmAlu.Show();
                    }
                }
                catch (Exception es) { }
            }
            else { MessageBox.Show("Usuario sin privilegios para consular alumnos!", "E-Learning"); }
        }

        private void catedráticosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Controlador.EvalSec.consultar("Catedratico", Objeto.Common.SEC_CONSULTAR) == 1)
            {
                try
                {
                    if (Objeto.Common.signedIn)
                    {
                        frmPersonal frmCat = new frmPersonal("Catedratico");
                        frmCat.MdiParent = this;
                        frmCat.Show();
                    }
                }
                catch (Exception ex) { }
            }
            else { MessageBox.Show("Usuario sin privilegios para consular catedráticos!", "E-Learning"); }
        }

        public void blockMenu()
        {
            this.administrativoToolStripMenuItem.Enabled = false;
            this.académicoToolStripMenuItem.Enabled = false;
        }

        public void unblockMenu()
        {
            this.administrativoToolStripMenuItem.Enabled = true;
            this.académicoToolStripMenuItem.Enabled = true;
        }

        private void clearPermissions()
        {
            Objeto.Common.signedIn = false;
            Objeto.Common.idPLogin = 0;
            Objeto.Common.regPLogin = "";
            Objeto.Common.usrLogin = "";
            Globales.id_usuario = 0;
            Globales.nom_usuario = "";
            Objeto.Common.setAclList();
            Controlador.EvalSec.clearACLs();
        }

        private void aplicacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Controlador.EvalSec.consultar("Aplicacion", Objeto.Common.SEC_CONSULTAR) == 1)
            {
                try
                {
                    if (Objeto.Common.signedIn)
                    {
                        Aplicaciones2 frmApp = new Aplicaciones2();
                        frmApp.MdiParent = this;
                        frmApp.Show();
                    }
                }
                catch (Exception ex) { }
            }
            else { MessageBox.Show("Usuario sin privilegios para consular aplicaciones!", "E-Learning"); }
        }

        private void permisosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Controlador.EvalSec.consultar("Permiso", Objeto.Common.SEC_CONSULTAR) == 1)
            {
                try
                {
                    if (Objeto.Common.signedIn)
                    {
                        Frm_MantenimientoApp frmApp = new Frm_MantenimientoApp();
                        frmApp.MdiParent = this;
                        frmApp.Show();
                    }
                }catch(Exception ex) { }
            }
            else { MessageBox.Show("Usuario sin privilegios para consular permisos!", "E-Learning"); }
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                List<Objeto.AclUser> list = new List<Objeto.AclUser>();
                list = Objeto.Common.ListAcl;

                foreach (Objeto.AclUser acl in list)
                {
                    MessageBox.Show(acl.ModuloNombre);
                }
            }catch(Exception ex) { MessageBox.Show(ex.Message); }
            Objeto.Common.setAclList();
        }

        private void tmr_loginFrm_Tick(object sender, EventArgs e)
        {
            setUsrNameFrm();
        }

        private void noticiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Controlador.EvalSec.consultar("Noticias", Objeto.Common.SEC_CONSULTAR) == 1)
            {
                try
                {
                    if (Objeto.Common.signedIn)
                    {
                        Noticias frmNot = new Noticias();
                        frmNot.MdiParent = this;
                        frmNot.Show();
                    }
                }
                catch (Exception ex) { }
            }
            else { MessageBox.Show("Usuario sin privilegios para consular noticias!", "E-Learning"); }
        }

        private void facultadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Controlador.EvalSec.consultar("Facultad", Objeto.Common.SEC_CONSULTAR) == 1)
            {
                try
                {
                    if (Objeto.Common.signedIn)
                    {
                        frmAgregarFacultad frmFac = new frmAgregarFacultad();
                        frmFac.MdiParent = this;
                        frmFac.Show();
                    }
                }
                catch (Exception ex) { }
            }
            else { MessageBox.Show("Usuario sin privilegios para consular facultades!", "E-Learning"); }
        }
    }
}
