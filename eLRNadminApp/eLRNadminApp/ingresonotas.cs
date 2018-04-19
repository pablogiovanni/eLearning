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
    public partial class ingresonotas : Form
    {
        List<Objeto.Curso> lCurso = new List<Objeto.Curso>();

        public ingresonotas()
        {
            InitializeComponent();
        }

        private void fillComboBoxCursos()
        {
            string qString = @"select id_pais, nom_p from pais";
            DataTable dt = Objeto.dbAccess.selectQ(qString);
            Objeto.Curso cursoObj;

            //Cargar datos a los objetvos comboBox para paises
            foreach (DataRow row in dt.Rows)
            {
                cursoObj = new Objeto.Curso(1,1,1,1,1,1,1,"");
                lCurso.Add(cursoObj);
            }
            foreach (Objeto.Curso objtPais in lCurso)
            {
                //cmb_pais.Items.Add(objtPais.PaisNombre);
            }
        }

        private bool selectedCombo()
        {
            //if ((cmb_dept.SelectedIndex >= 0) && (cmb_pais.SelectedIndex >= 0) && (cmb_per.SelectedIndex >= 0))
            //{
              //  return true;
            //}
            return false;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
