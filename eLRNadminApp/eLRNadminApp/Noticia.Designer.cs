namespace eLRNadminApp
{
    partial class Noticia
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
            this.dt_fecha_noticia = new System.Windows.Forms.DateTimePicker();
            this.txt_cod_noticia = new System.Windows.Forms.TextBox();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dt_fecha_creacion = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_empleado = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.navegador1 = new Navegador.Navegador();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(12, 316);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(731, 250);
            this.panel3.TabIndex = 16;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 14);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(699, 212);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dt_fecha_noticia);
            this.panel2.Controls.Add(this.txt_cod_noticia);
            this.panel2.Controls.Add(this.txt_descripcion);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dt_fecha_creacion);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.cb_empleado);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(12, 93);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(731, 217);
            this.panel2.TabIndex = 15;
            // 
            // dt_fecha_noticia
            // 
            this.dt_fecha_noticia.Location = new System.Drawing.Point(483, 54);
            this.dt_fecha_noticia.Name = "dt_fecha_noticia";
            this.dt_fecha_noticia.Size = new System.Drawing.Size(200, 20);
            this.dt_fecha_noticia.TabIndex = 10;
            this.dt_fecha_noticia.Tag = "fecha_noticia";
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
            this.txt_descripcion.Location = new System.Drawing.Point(159, 98);
            this.txt_descripcion.Multiline = true;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(553, 109);
            this.txt_descripcion.TabIndex = 6;
            this.txt_descripcion.Tag = "nom_noticia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Descripcion:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Codigo Noticia";
            // 
            // dt_fecha_creacion
            // 
            this.dt_fecha_creacion.Location = new System.Drawing.Point(483, 19);
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
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Codigo Empleado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(389, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fecha noticia";
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
            this.label4.Location = new System.Drawing.Point(386, 19);
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
            this.panel1.TabIndex = 14;
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
            // Noticia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 574);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Noticia";
            this.Text = " Noticias";
            this.Load += new System.EventHandler(this.Noticia_Load);
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
        private System.Windows.Forms.DateTimePicker dt_fecha_noticia;
        private System.Windows.Forms.TextBox txt_cod_noticia;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dt_fecha_creacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_empleado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private Navegador.Navegador navegador1;
    }
}