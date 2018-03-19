namespace eLRNadminApp
{
    partial class Encuestas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_cod_noticia = new System.Windows.Forms.TextBox();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dt_fecha_creacion = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_empleado = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.navegador1 = new Navegador.Navegador();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(12, 314);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(731, 226);
            this.panel3.TabIndex = 19;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 8);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(725, 208);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.comboBox3);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.comboBox2);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.txt_cod_noticia);
            this.panel2.Controls.Add(this.txt_descripcion);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dt_fecha_creacion);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cb_empleado);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(12, 93);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(731, 215);
            this.panel2.TabIndex = 18;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // txt_cod_noticia
            // 
            this.txt_cod_noticia.Location = new System.Drawing.Point(143, 17);
            this.txt_cod_noticia.Name = "txt_cod_noticia";
            this.txt_cod_noticia.Size = new System.Drawing.Size(182, 20);
            this.txt_cod_noticia.TabIndex = 1;
            this.txt_cod_noticia.Tag = "id_noticia";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(143, 179);
            this.txt_descripcion.Multiline = true;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(182, 20);
            this.txt_descripcion.TabIndex = 6;
            this.txt_descripcion.Tag = "nom_noticia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Codigo Curso";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Codigo encuesta";
            // 
            // dt_fecha_creacion
            // 
            this.dt_fecha_creacion.Location = new System.Drawing.Point(474, 155);
            this.dt_fecha_creacion.Name = "dt_fecha_creacion";
            this.dt_fecha_creacion.Size = new System.Drawing.Size(200, 20);
            this.dt_fecha_creacion.TabIndex = 9;
            this.dt_fecha_creacion.Tag = "fecha_creado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Categoria encuesta";
            // 
            // cb_empleado
            // 
            this.cb_empleado.FormattingEnabled = true;
            this.cb_empleado.Location = new System.Drawing.Point(143, 54);
            this.cb_empleado.Name = "cb_empleado";
            this.cb_empleado.Size = new System.Drawing.Size(182, 21);
            this.cb_empleado.TabIndex = 4;
            this.cb_empleado.Tag = "id_emp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(377, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fecha creacion";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.navegador1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(731, 75);
            this.panel1.TabIndex = 17;
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(87, 18);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(559, 47);
            this.navegador1.sNombreBD = "elearningDB";
            this.navegador1.sNombreTabla = "noticia";
            this.navegador1.sPass = null;
            this.navegador1.sResult = null;
            this.navegador1.sServidor = "localhost";
            this.navegador1.sUsuario = "root";
            this.navegador1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Categoria encuesta";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(143, 91);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(182, 21);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.Tag = "id_emp";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Codigo personal";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(143, 118);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(182, 21);
            this.comboBox2.TabIndex = 14;
            this.comboBox2.Tag = "id_emp";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Codigo registro";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(143, 145);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(182, 21);
            this.comboBox3.TabIndex = 16;
            this.comboBox3.Tag = "id_emp";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(492, 20);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(182, 20);
            this.textBox1.TabIndex = 18;
            this.textBox1.Tag = "nom_noticia";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(371, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Codigo Carrera";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(492, 51);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(182, 20);
            this.textBox2.TabIndex = 20;
            this.textBox2.Tag = "nom_noticia";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(371, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Codigo Facultad";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(492, 119);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(182, 20);
            this.textBox3.TabIndex = 24;
            this.textBox3.Tag = "nom_noticia";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(371, 126);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Path";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(492, 88);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(182, 20);
            this.textBox4.TabIndex = 22;
            this.textBox4.Tag = "nom_noticia";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(371, 95);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Nombre";
            // 
            // Encuestas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 542);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Encuestas";
            this.Text = "Encuestas";
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_cod_noticia;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dt_fecha_creacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_empleado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private Navegador.Navegador navegador1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label9;
    }
}