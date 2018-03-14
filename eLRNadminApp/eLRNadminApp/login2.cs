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
    public partial class login2 : Form
    {
        public login2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Objeto.AclUser acl_1 = new Objeto.AclUser(1, "Modulo 1");
            Objeto.AclUser acl_2 = new Objeto.AclUser(2, "Modulo 2");

            List<Objeto.AclUser> lAcls = new List<Objeto.AclUser>();

            lAcls.Add(acl_1);
            lAcls.Add(acl_2);

            Objeto.AclUser acl = new Objeto.AclUser(2, "modulo");

            if (lAcls.Contains(acl))
            {
                MessageBox.Show("ACL: " +acl.ModuloID+ "->" +acl.ModuloNombre+ " encontrada","MessageACL");
            }

            foreach(Objeto.AclUser acls in lAcls)
            {
                MessageBox.Show(acls.ModuloID.ToString()+" "+acls.ModuloNombre,"ACLS!");
            }
        }
    }
}
