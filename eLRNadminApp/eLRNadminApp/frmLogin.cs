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
        }

        private void iniciarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login_frm = new Login();
            login_frm.MdiParent = this;
            login_frm.Show();
            cerrarSesiónToolStripMenuItem.Enabled = true;
            iniciarSesiónToolStripMenuItem.Enabled = false;     
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cerrarSesiónToolStripMenuItem.Enabled = false;
            iniciarSesiónToolStripMenuItem.Enabled = true;
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

        private void frm_init_Load(object sender, EventArgs e)
        {

        }

        private void pruebaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void asiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
