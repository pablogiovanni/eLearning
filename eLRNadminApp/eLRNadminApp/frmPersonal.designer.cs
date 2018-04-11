namespace eLRNadminApp
{
    partial class frmPersonal
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnom1 = new System.Windows.Forms.TextBox();
            this.txtnombre2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_pais = new System.Windows.Forms.Label();
            this.lbl_tipoP = new System.Windows.Forms.Label();
            this.txtDire = new System.Windows.Forms.TextBox();
            this.lbl_dom = new System.Windows.Forms.Label();
            this.lbl_id_emp = new System.Windows.Forms.Label();
            this.navegador1 = new Navegador.Navegador();
            this.dtP_1 = new System.Windows.Forms.DateTimePicker();
            this.dtP_2 = new System.Windows.Forms.DateTimePicker();
            this.cmb_dept = new System.Windows.Forms.ComboBox();
            this.cmb_per = new System.Windows.Forms.ComboBox();
            this.cmb_pais = new System.Windows.Forms.ComboBox();
            this.lbl_perid = new System.Windows.Forms.Label();
            this.grpB1 = new System.Windows.Forms.GroupBox();
            this.rbtn_second = new System.Windows.Forms.RadioButton();
            this.cmb_num = new System.Windows.Forms.ComboBox();
            this.txt_num = new System.Windows.Forms.TextBox();
            this.txt_area = new System.Windows.Forms.TextBox();
            this.grpB2 = new System.Windows.Forms.GroupBox();
            this.rbtn_third = new System.Windows.Forms.RadioButton();
            this.cmb_email = new System.Windows.Forms.ComboBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.rbtn_first = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpB1.SuspendLayout();
            this.grpB2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 417);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1440, 185);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 204);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombres";
            // 
            // txtnom1
            // 
            this.txtnom1.Location = new System.Drawing.Point(137, 200);
            this.txtnom1.Margin = new System.Windows.Forms.Padding(4);
            this.txtnom1.Name = "txtnom1";
            this.txtnom1.Size = new System.Drawing.Size(265, 22);
            this.txtnom1.TabIndex = 3;
            // 
            // txtnombre2
            // 
            this.txtnombre2.Location = new System.Drawing.Point(137, 232);
            this.txtnombre2.Margin = new System.Windows.Forms.Padding(4);
            this.txtnombre2.Name = "txtnombre2";
            this.txtnombre2.Size = new System.Drawing.Size(265, 22);
            this.txtnombre2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 236);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Apellidos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 268);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fecha Creación";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 300);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nacimiento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 332);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Departamemto";
            // 
            // lbl_pais
            // 
            this.lbl_pais.AutoSize = true;
            this.lbl_pais.Location = new System.Drawing.Point(411, 232);
            this.lbl_pais.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_pais.Name = "lbl_pais";
            this.lbl_pais.Size = new System.Drawing.Size(35, 17);
            this.lbl_pais.TabIndex = 18;
            this.lbl_pais.Text = "Pais";
            // 
            // lbl_tipoP
            // 
            this.lbl_tipoP.AutoSize = true;
            this.lbl_tipoP.Location = new System.Drawing.Point(411, 200);
            this.lbl_tipoP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_tipoP.Name = "lbl_tipoP";
            this.lbl_tipoP.Size = new System.Drawing.Size(64, 17);
            this.lbl_tipoP.TabIndex = 20;
            this.lbl_tipoP.Text = "Personal";
            // 
            // txtDire
            // 
            this.txtDire.Location = new System.Drawing.Point(483, 266);
            this.txtDire.Margin = new System.Windows.Forms.Padding(4);
            this.txtDire.Name = "txtDire";
            this.txtDire.Size = new System.Drawing.Size(249, 22);
            this.txtDire.TabIndex = 23;
            // 
            // lbl_dom
            // 
            this.lbl_dom.AutoSize = true;
            this.lbl_dom.Location = new System.Drawing.Point(411, 269);
            this.lbl_dom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_dom.Name = "lbl_dom";
            this.lbl_dom.Size = new System.Drawing.Size(64, 17);
            this.lbl_dom.TabIndex = 22;
            this.lbl_dom.Text = "Domicilio";
            // 
            // lbl_id_emp
            // 
            this.lbl_id_emp.AutoSize = true;
            this.lbl_id_emp.Location = new System.Drawing.Point(13, 142);
            this.lbl_id_emp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_id_emp.Name = "lbl_id_emp";
            this.lbl_id_emp.Size = new System.Drawing.Size(29, 17);
            this.lbl_id_emp.TabIndex = 32;
            this.lbl_id_emp.Text = "ID: ";
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(345, 27);
            this.navegador1.Margin = new System.Windows.Forms.Padding(5);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(745, 58);
            this.navegador1.sNombreBD = null;
            this.navegador1.sNombreTabla = null;
            this.navegador1.sPass = null;
            this.navegador1.sResult = null;
            this.navegador1.sServidor = null;
            this.navegador1.sUsuario = null;
            this.navegador1.TabIndex = 33;
            this.navegador1.RecibidorInsertar += new System.EventHandler(this.navegador1_RecibidorInsertar);
            this.navegador1.RecibidorActualizar += new System.EventHandler(this.navegador1_RecibidorActualizar);
            this.navegador1.RecibidorEliminar += new System.EventHandler(this.navegador1_RecibidorEliminar);
            this.navegador1.RecibidorSiguiente += new System.EventHandler(this.navegador1_RecibidorSiguiente);
            this.navegador1.RecibidorAnterior += new System.EventHandler(this.navegador1_RecibidorAnterior);
            // 
            // dtP_1
            // 
            this.dtP_1.Location = new System.Drawing.Point(137, 268);
            this.dtP_1.Margin = new System.Windows.Forms.Padding(4);
            this.dtP_1.Name = "dtP_1";
            this.dtP_1.Size = new System.Drawing.Size(265, 22);
            this.dtP_1.TabIndex = 34;
            // 
            // dtP_2
            // 
            this.dtP_2.Location = new System.Drawing.Point(137, 300);
            this.dtP_2.Margin = new System.Windows.Forms.Padding(4);
            this.dtP_2.Name = "dtP_2";
            this.dtP_2.Size = new System.Drawing.Size(265, 22);
            this.dtP_2.TabIndex = 35;
            // 
            // cmb_dept
            // 
            this.cmb_dept.FormattingEnabled = true;
            this.cmb_dept.Location = new System.Drawing.Point(137, 332);
            this.cmb_dept.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_dept.Name = "cmb_dept";
            this.cmb_dept.Size = new System.Drawing.Size(265, 24);
            this.cmb_dept.TabIndex = 36;
            this.cmb_dept.SelectedValueChanged += new System.EventHandler(this.cmb_dept_SelectedValueChanged);
            // 
            // cmb_per
            // 
            this.cmb_per.FormattingEnabled = true;
            this.cmb_per.Location = new System.Drawing.Point(483, 200);
            this.cmb_per.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_per.Name = "cmb_per";
            this.cmb_per.Size = new System.Drawing.Size(249, 24);
            this.cmb_per.TabIndex = 37;
            this.cmb_per.SelectedValueChanged += new System.EventHandler(this.cmb_per_SelectedValueChanged);
            // 
            // cmb_pais
            // 
            this.cmb_pais.FormattingEnabled = true;
            this.cmb_pais.Location = new System.Drawing.Point(483, 233);
            this.cmb_pais.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_pais.Name = "cmb_pais";
            this.cmb_pais.Size = new System.Drawing.Size(249, 24);
            this.cmb_pais.TabIndex = 38;
            this.cmb_pais.SelectedValueChanged += new System.EventHandler(this.cmb_pais_SelectedValueChanged);
            // 
            // lbl_perid
            // 
            this.lbl_perid.AutoSize = true;
            this.lbl_perid.Location = new System.Drawing.Point(134, 142);
            this.lbl_perid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_perid.Name = "lbl_perid";
            this.lbl_perid.Size = new System.Drawing.Size(13, 17);
            this.lbl_perid.TabIndex = 39;
            this.lbl_perid.Text = "-";
            // 
            // grpB1
            // 
            this.grpB1.Controls.Add(this.rbtn_second);
            this.grpB1.Controls.Add(this.cmb_num);
            this.grpB1.Controls.Add(this.txt_num);
            this.grpB1.Controls.Add(this.txt_area);
            this.grpB1.Location = new System.Drawing.Point(761, 190);
            this.grpB1.Name = "grpB1";
            this.grpB1.Size = new System.Drawing.Size(329, 148);
            this.grpB1.TabIndex = 40;
            this.grpB1.TabStop = false;
            this.grpB1.Text = "Número Telefónico";
            // 
            // rbtn_second
            // 
            this.rbtn_second.AutoSize = true;
            this.rbtn_second.Location = new System.Drawing.Point(306, 120);
            this.rbtn_second.Name = "rbtn_second";
            this.rbtn_second.Size = new System.Drawing.Size(17, 16);
            this.rbtn_second.TabIndex = 43;
            this.rbtn_second.TabStop = true;
            this.rbtn_second.UseVisualStyleBackColor = true;
            this.rbtn_second.CheckedChanged += new System.EventHandler(this.rbtn_second_CheckedChanged);
            // 
            // cmb_num
            // 
            this.cmb_num.FormattingEnabled = true;
            this.cmb_num.Location = new System.Drawing.Point(7, 117);
            this.cmb_num.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_num.Name = "cmb_num";
            this.cmb_num.Size = new System.Drawing.Size(160, 24);
            this.cmb_num.TabIndex = 42;
            // 
            // txt_num
            // 
            this.txt_num.Location = new System.Drawing.Point(139, 46);
            this.txt_num.Name = "txt_num";
            this.txt_num.Size = new System.Drawing.Size(184, 22);
            this.txt_num.TabIndex = 2;
            // 
            // txt_area
            // 
            this.txt_area.Location = new System.Drawing.Point(7, 46);
            this.txt_area.Name = "txt_area";
            this.txt_area.Size = new System.Drawing.Size(100, 22);
            this.txt_area.TabIndex = 1;
            // 
            // grpB2
            // 
            this.grpB2.Controls.Add(this.rbtn_third);
            this.grpB2.Controls.Add(this.cmb_email);
            this.grpB2.Controls.Add(this.txt_email);
            this.grpB2.Location = new System.Drawing.Point(1127, 190);
            this.grpB2.Name = "grpB2";
            this.grpB2.Size = new System.Drawing.Size(329, 148);
            this.grpB2.TabIndex = 41;
            this.grpB2.TabStop = false;
            this.grpB2.Text = "Correo Electrónico";
            // 
            // rbtn_third
            // 
            this.rbtn_third.AutoSize = true;
            this.rbtn_third.Location = new System.Drawing.Point(306, 120);
            this.rbtn_third.Name = "rbtn_third";
            this.rbtn_third.Size = new System.Drawing.Size(17, 16);
            this.rbtn_third.TabIndex = 45;
            this.rbtn_third.TabStop = true;
            this.rbtn_third.UseVisualStyleBackColor = true;
            this.rbtn_third.CheckedChanged += new System.EventHandler(this.rbtn_third_CheckedChanged);
            // 
            // cmb_email
            // 
            this.cmb_email.FormattingEnabled = true;
            this.cmb_email.Location = new System.Drawing.Point(7, 117);
            this.cmb_email.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_email.Name = "cmb_email";
            this.cmb_email.Size = new System.Drawing.Size(160, 24);
            this.cmb_email.TabIndex = 43;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(6, 45);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(317, 22);
            this.txt_email.TabIndex = 3;
            // 
            // rbtn_first
            // 
            this.rbtn_first.AutoSize = true;
            this.rbtn_first.Location = new System.Drawing.Point(385, 363);
            this.rbtn_first.Name = "rbtn_first";
            this.rbtn_first.Size = new System.Drawing.Size(17, 16);
            this.rbtn_first.TabIndex = 42;
            this.rbtn_first.TabStop = true;
            this.rbtn_first.UseVisualStyleBackColor = true;
            this.rbtn_first.CheckedChanged += new System.EventHandler(this.rbtn_first_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 23);
            this.button1.TabIndex = 43;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1472, 617);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rbtn_first);
            this.Controls.Add(this.grpB2);
            this.Controls.Add(this.grpB1);
            this.Controls.Add(this.lbl_perid);
            this.Controls.Add(this.cmb_pais);
            this.Controls.Add(this.cmb_per);
            this.Controls.Add(this.cmb_dept);
            this.Controls.Add(this.dtP_2);
            this.Controls.Add(this.dtP_1);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.lbl_id_emp);
            this.Controls.Add(this.txtDire);
            this.Controls.Add(this.lbl_dom);
            this.Controls.Add(this.lbl_tipoP);
            this.Controls.Add(this.lbl_pais);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtnombre2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnom1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPersonal";
            this.Text = "Mantenimiento de Personal General ";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmEmpleados_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpB1.ResumeLayout(false);
            this.grpB1.PerformLayout();
            this.grpB2.ResumeLayout(false);
            this.grpB2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnom1;
        private System.Windows.Forms.TextBox txtnombre2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_pais;
        private System.Windows.Forms.Label lbl_tipoP;
        private System.Windows.Forms.TextBox txtDire;
        private System.Windows.Forms.Label lbl_dom;
        private System.Windows.Forms.Label lbl_id_emp;
        private Navegador.Navegador navegador1;
        private System.Windows.Forms.DateTimePicker dtP_1;
        private System.Windows.Forms.DateTimePicker dtP_2;
        private System.Windows.Forms.ComboBox cmb_dept;
        private System.Windows.Forms.ComboBox cmb_per;
        private System.Windows.Forms.ComboBox cmb_pais;
        private System.Windows.Forms.Label lbl_perid;
        private System.Windows.Forms.GroupBox grpB1;
        private System.Windows.Forms.GroupBox grpB2;
        private System.Windows.Forms.TextBox txt_num;
        private System.Windows.Forms.TextBox txt_area;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.ComboBox cmb_num;
        private System.Windows.Forms.ComboBox cmb_email;
        private System.Windows.Forms.RadioButton rbtn_first;
        private System.Windows.Forms.RadioButton rbtn_second;
        private System.Windows.Forms.RadioButton rbtn_third;
        private System.Windows.Forms.Button button1;
    }
}