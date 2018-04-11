namespace eLRNadminApp
{
    partial class Noticias
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.navegador1 = new Navegador.Navegador();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_id_per = new System.Windows.Forms.Label();
            this.lbl_id_not = new System.Windows.Forms.Label();
            this.dtP_2 = new System.Windows.Forms.DateTimePicker();
            this.dtP_1 = new System.Windows.Forms.DateTimePicker();
            this.txt_nom_not = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Dgv_noticias = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_noticias)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo de la noticia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Codigo del Empleado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(192, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre de la Noticia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(192, 148);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha de Creacion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(192, 177);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha de la noticia";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.navegador1);
            this.panel1.Location = new System.Drawing.Point(41, 39);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1064, 123);
            this.panel1.TabIndex = 5;
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(173, 28);
            this.navegador1.Margin = new System.Windows.Forms.Padding(5);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(745, 58);
            this.navegador1.sNombreBD = null;
            this.navegador1.sNombreTabla = null;
            this.navegador1.sPass = null;
            this.navegador1.sResult = null;
            this.navegador1.sServidor = null;
            this.navegador1.sUsuario = null;
            this.navegador1.TabIndex = 0;
            this.navegador1.RecibidorInsertar += new System.EventHandler(this.navegador1_RecibidorInsertar);
            this.navegador1.RecibidorActualizar += new System.EventHandler(this.navegador1_RecibidorActualizar);
            this.navegador1.RecibidorEliminar += new System.EventHandler(this.navegador1_RecibidorEliminar);
            this.navegador1.RecibidorSiguiente += new System.EventHandler(this.navegador1_RecibidorSiguiente);
            this.navegador1.RecibidorAnterior += new System.EventHandler(this.navegador1_RecibidorAnterior);
            this.navegador1.RecibidorPrimero += new System.EventHandler(this.navegador1_RecibidorPrimero);
            this.navegador1.RecibidorUltimo += new System.EventHandler(this.navegador1_RecibidorUltimo);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbl_id_per);
            this.panel2.Controls.Add(this.lbl_id_not);
            this.panel2.Controls.Add(this.dtP_2);
            this.panel2.Controls.Add(this.dtP_1);
            this.panel2.Controls.Add(this.txt_nom_not);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(41, 171);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1064, 233);
            this.panel2.TabIndex = 6;
            // 
            // lbl_id_per
            // 
            this.lbl_id_per.AutoSize = true;
            this.lbl_id_per.Location = new System.Drawing.Point(390, 82);
            this.lbl_id_per.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_id_per.Name = "lbl_id_per";
            this.lbl_id_per.Size = new System.Drawing.Size(0, 17);
            this.lbl_id_per.TabIndex = 11;
            // 
            // lbl_id_not
            // 
            this.lbl_id_not.AutoSize = true;
            this.lbl_id_not.Location = new System.Drawing.Point(390, 54);
            this.lbl_id_not.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_id_not.Name = "lbl_id_not";
            this.lbl_id_not.Size = new System.Drawing.Size(0, 17);
            this.lbl_id_not.TabIndex = 10;
            // 
            // dtP_2
            // 
            this.dtP_2.Location = new System.Drawing.Point(393, 185);
            this.dtP_2.Margin = new System.Windows.Forms.Padding(4);
            this.dtP_2.Name = "dtP_2";
            this.dtP_2.Size = new System.Drawing.Size(408, 22);
            this.dtP_2.TabIndex = 9;
            // 
            // dtP_1
            // 
            this.dtP_1.Location = new System.Drawing.Point(393, 153);
            this.dtP_1.Margin = new System.Windows.Forms.Padding(4);
            this.dtP_1.Name = "dtP_1";
            this.dtP_1.Size = new System.Drawing.Size(408, 22);
            this.dtP_1.TabIndex = 8;
            // 
            // txt_nom_not
            // 
            this.txt_nom_not.Location = new System.Drawing.Point(393, 121);
            this.txt_nom_not.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nom_not.Name = "txt_nom_not";
            this.txt_nom_not.Size = new System.Drawing.Size(408, 22);
            this.txt_nom_not.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Dgv_noticias);
            this.panel3.Location = new System.Drawing.Point(41, 412);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1064, 278);
            this.panel3.TabIndex = 7;
            // 
            // Dgv_noticias
            // 
            this.Dgv_noticias.AllowUserToAddRows = false;
            this.Dgv_noticias.AllowUserToDeleteRows = false;
            this.Dgv_noticias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_noticias.Location = new System.Drawing.Point(4, 4);
            this.Dgv_noticias.Margin = new System.Windows.Forms.Padding(4);
            this.Dgv_noticias.Name = "Dgv_noticias";
            this.Dgv_noticias.ReadOnly = true;
            this.Dgv_noticias.Size = new System.Drawing.Size(1056, 271);
            this.Dgv_noticias.TabIndex = 0;
            this.Dgv_noticias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_noticias_CellClick);
            // 
            // Noticias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1148, 705);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Noticias";
            this.Text = "Noticias";
            this.Load += new System.EventHandler(this.Noticias_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_noticias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private Navegador.Navegador navegador1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dtP_2;
        private System.Windows.Forms.DateTimePicker dtP_1;
        private System.Windows.Forms.TextBox txt_nom_not;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView Dgv_noticias;
        private System.Windows.Forms.Label lbl_id_per;
        private System.Windows.Forms.Label lbl_id_not;
    }
}