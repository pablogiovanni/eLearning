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
    public partial class frmCatedratico : Form
    {
        private const string nomApp = "Catedratico";
        public frmCatedratico()
        {
            InitializeComponent();
            navegador1.setSecProfile(nomApp);
        }
    }
}
