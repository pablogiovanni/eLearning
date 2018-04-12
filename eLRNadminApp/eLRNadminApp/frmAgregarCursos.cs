using Navegador.Utilidades;
using System;
using System.Collections;
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
    public partial class frmAgregarCursos : Form

    {
        private static string nomApp = "AgregarCurso";
        public frmAgregarCursos()
        {

            InitializeComponent();
            e();
        }
        int indiceFacultad;
        int indiceCarrera;
        
        public void e()
        {
            label9.Visible = false;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void navegador1_RecibidorInsertar(object sender, EventArgs e)
        {
            string bd = navegador1.sNombreBD;
            string server = navegador1.sServidor;
            string user = navegador1.sUsuario;
            string pass = navegador1.sPass;
            string nametable = navegador1.sNombreTabla;


            String campo1 = textBox1.Text;
            String campo2 = textBox2.Text;
            String campo3 = textBox3.Text;
            String campo4= textBox4.Text;
            String campo5 = textBox5.Text;
            String campo6 = textBox6.Text;
            String campo7 = label9.Text;
            String campo8 = label10.Text;
            ArrayList listavalores = new ArrayList();
            ArrayList listacampos = new ArrayList();



            listavalores.Add(campo1);
            listavalores.Add(campo2);
            listavalores.Add(campo3);
            listavalores.Add(campo4);
            listavalores.Add(campo5);
            listavalores.Add(campo6);
            listavalores.Add(campo7);
            listavalores.Add(campo8);

            listacampos.Add(textBox1.Tag.ToString());
            listacampos.Add(textBox2.Tag.ToString());
            listacampos.Add(textBox3.Tag.ToString());
            listacampos.Add(textBox4.Tag.ToString());
            listacampos.Add(textBox5.Tag.ToString());
            listacampos.Add(textBox6.Tag.ToString());
            listacampos.Add(label9.Tag.ToString());
            listacampos.Add(label10.Tag.ToString());



            GeneradorSQL gsql = new GeneradorSQL(server, bd, user, pass, nametable);
            gsql.setCodigoInstDML(1);
            gsql.setCampos(listacampos);
            gsql.setValores(listavalores);
            gsql.ejecutar();




        }

        private void navegador1_RecibidorEliminar(object sender, EventArgs e)
        {
            string bd = navegador1.sNombreBD;
            string server = navegador1.sServidor;
            string user = navegador1.sUsuario;
            string pass = navegador1.sPass;
            string nametable = navegador1.sNombreTabla;

            String campo1 = textBox1.Text;






            GeneradorSQL gsql = new GeneradorSQL(server, bd, user, pass, nametable);
            gsql.setComparacion(textBox1.Tag.ToString(), campo1);
            gsql.setCodigoInstDML(3);
            gsql.ejecutar();

        }

        private void navegador1_RecibidorActualizar(object sender, EventArgs e)
        {
         
                string bd = navegador1.sNombreBD;
                string server = navegador1.sServidor;
                string user = navegador1.sUsuario;
                string pass = navegador1.sPass;
                string nametable = navegador1.sNombreTabla;

                String campo1 = textBox1.Text;
                String campo2 = textBox2.Text;
                String campo3 = textBox3.Text;
                String campo4 = textBox4.Text;
                String campo5 = textBox5.Text;
                String campo6 = textBox6.Text;


                ArrayList listavalores = new ArrayList();
                ArrayList listacampos = new ArrayList();



                listavalores.Add(campo1);
                listavalores.Add(campo2);
                listavalores.Add(campo3);
                listavalores.Add(campo4);
                listavalores.Add(campo5);
                listavalores.Add(campo6);


                listacampos.Add(textBox1.Tag.ToString());
                listacampos.Add(textBox2.Tag.ToString());
                listacampos.Add(textBox3.Tag.ToString());
                listacampos.Add(textBox4.Tag.ToString());
                listacampos.Add(textBox5.Tag.ToString());
                listacampos.Add(textBox6.Tag.ToString());


                GeneradorSQL gsql = new GeneradorSQL(server, bd, user, pass, nametable);
                //aqui en comparacion metes el textbox.tag es decir el txt con el nombre del campo por eso el tag, seguido del campo es decir el contenido de ese txt que vos o el user mete
                gsql.setComparacion(textBox1.Tag.ToString(), campo1);
                //aquie es el "2" porque setea que es el update, ya que el insert es 1 si te das cuenta y cambia el numero si es delete o buscar 
                gsql.setCodigoInstDML(2);
                gsql.setCampos(listacampos);
                gsql.setValores(listavalores);
                gsql.ejecutar();
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
       indiceFacultad = comboBox1.SelectedIndex+1;
            label9.Text = indiceFacultad.ToString();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            indiceCarrera = comboBox2.SelectedIndex + 1;
            label10.Text = indiceCarrera.ToString();

        }

        private void navegador1_RecibidorPrimero(object sender, EventArgs e)
        {
               String resultado = navegador1.sResult;
               String[] token = resultado.Split(',');
               //aqui van despues del token en "orden" como queres que se muestren los campos de la bd
              textBox1.Text = token[0];
               textBox2.Text = token[1];
               textBox3.Text = token[2];
               textBox4.Text = token[3];
               textBox5.Text = token[4];
               textBox6.Text = token[5];
           /*  comboBox1.Text = token[0];
               comboBox2.Text = token[1];*/
           
        }

        private void navegador1_RecibidorAnterior(object sender, EventArgs e)
        {
            String resultado = navegador1.sResult;
            String[] token = resultado.Split(',');
            //aqui van despues del token en "orden" como queres que se muestren los campos de la bd
            textBox1.Text = token[3];
            textBox2.Text = token[4];
            textBox3.Text = token[5];
            textBox4.Text = token[6];
            textBox5.Text = token[6];
            textBox6.Text = token[8];
            comboBox1.Text = comboBox1.SelectedText = "Ingenieria de Sistemas";
            comboBox2.Text = comboBox2.SelectedText = "Ingenieria de Sistemas";
        }

        private void frmAgregarCursos_Load(object sender, EventArgs e)
        {

        }
    }
}
