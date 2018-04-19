namespace eLRNadminApp
{
    partial class actividadesnota
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
            this.txt_nom_act = new System.Windows.Forms.TextBox();
            this.Dgv_act = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_nota_total = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_id_act = new System.Windows.Forms.Label();
            this.navegador1 = new Navegador.Navegador();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_act)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de la Actividad";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(266, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(545, 46);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingreso de Actividades Nota";
            // 
            // txt_nom_act
            // 
            this.txt_nom_act.Location = new System.Drawing.Point(340, 292);
            this.txt_nom_act.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_nom_act.Name = "txt_nom_act";
            this.txt_nom_act.Size = new System.Drawing.Size(248, 26);
            this.txt_nom_act.TabIndex = 8;
            // 
            // Dgv_act
            // 
            this.Dgv_act.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_act.Location = new System.Drawing.Point(76, 334);
            this.Dgv_act.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Dgv_act.Name = "Dgv_act";
            this.Dgv_act.RowTemplate.Height = 24;
            this.Dgv_act.Size = new System.Drawing.Size(952, 240);
            this.Dgv_act.TabIndex = 10;
            this.Dgv_act.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_act_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(672, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(449, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Total Puntos Asignados en esta actividad";
            // 
            // txt_nota_total
            // 
            this.txt_nota_total.Location = new System.Drawing.Point(826, 299);
            this.txt_nota_total.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_nota_total.Name = "txt_nota_total";
            this.txt_nota_total.Size = new System.Drawing.Size(114, 26);
            this.txt_nota_total.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "ID actividad";
            // 
            // lbl_id_act
            // 
            this.lbl_id_act.AutoSize = true;
            this.lbl_id_act.Location = new System.Drawing.Point(336, 251);
            this.lbl_id_act.Name = "lbl_id_act";
            this.lbl_id_act.Size = new System.Drawing.Size(14, 20);
            this.lbl_id_act.TabIndex = 14;
            this.lbl_id_act.Text = "-";
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(122, 79);
            this.navegador1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(838, 72);
            this.navegador1.sNombreBD = null;
            this.navegador1.sNombreTabla = null;
            this.navegador1.sPass = null;
            this.navegador1.sResult = null;
            this.navegador1.sServidor = null;
            this.navegador1.sUsuario = null;
            this.navegador1.TabIndex = 15;
            this.navegador1.RecibidorInsertar += new System.EventHandler(this.navegador1_RecibidorInsertar);
            this.navegador1.RecibidorActualizar += new System.EventHandler(this.navegador1_RecibidorActualizar);
            // 
            // actividadesnota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1125, 618);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.lbl_id_act);
            this.Controls.Add(this.txt_nota_total);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Dgv_act);
            this.Controls.Add(this.txt_nom_act);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "actividadesnota";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actividades Nota";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_act)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nom_act;
        private System.Windows.Forms.DataGridView Dgv_act;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_nota_total;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_id_act;
        private Navegador.Navegador navegador1;
    }
}