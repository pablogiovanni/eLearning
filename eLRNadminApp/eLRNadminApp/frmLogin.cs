﻿using System;
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
        private List<Objeto.AclUser> loginLacl = null;

        public void setAclList(List<Objeto.AclUser> auxList)
        {
            if (Objeto.Common.signedIn)
            {
                this.loginLacl = auxList;
            }
            this.loginLacl = null;
        }

        public frm_init()
        {
            InitializeComponent();
            cerrarSesiónToolStripMenuItem.Enabled = false;
            blockMenu();
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
            Usuarios usr_frm = new Usuarios();
            usr_frm.MdiParent = this;
            usr_frm.Show();
        }

        private void personalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPersonal frmPrn = new frmPersonal();
            frmPrn.MdiParent = this;
            frmPrn.Show();
        }

        private void alumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlumno frmAlu = new frmAlumno();
            frmAlu.MdiParent = this;
            frmAlu.Show();
        }

        private void catedráticosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCatedratico frmCat = new frmCatedratico();
            frmCat.MdiParent = this;
            frmCat.Show();
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
        }

        private void aplicacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Aplicaciones2 frmApp = new Aplicaciones2();
            frmApp.MdiParent = this;
            frmApp.Show();
        }

        private void permisosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_MantenimientoApp frmApp = new Frm_MantenimientoApp();
            frmApp.MdiParent = this;
            frmApp.Show();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(Objeto.AclUser acl in loginLacl)
            {
                MessageBox.Show(acl.ModuloID + acl.ModuloNombre);
            }
        }
    }
}
