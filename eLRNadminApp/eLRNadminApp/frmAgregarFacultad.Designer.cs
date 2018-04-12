namespace eLRNadminApp
{
    partial class frmAgregarFacultad
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
            this.navegador1 = new Navegador.Navegador();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dgvFacultad = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacultad)).BeginInit();
            this.SuspendLayout();
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(25, 23);
            this.navegador1.Margin = new System.Windows.Forms.Padding(4);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Agregue una Facultad";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(226, 133);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(482, 22);
            this.textBox1.TabIndex = 2;
            // 
            // dgvFacultad
            // 
            this.dgvFacultad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacultad.Location = new System.Drawing.Point(37, 230);
            this.dgvFacultad.Name = "dgvFacultad";
            this.dgvFacultad.RowTemplate.Height = 24;
            this.dgvFacultad.Size = new System.Drawing.Size(756, 150);
            this.dgvFacultad.TabIndex = 3;
            this.dgvFacultad.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFacultad_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Agregue descripcion";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(226, 181);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(482, 22);
            this.textBox2.TabIndex = 5;
            // 
            // frmAgregarFacultad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 485);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvFacultad);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.navegador1);
            this.Name = "frmAgregarFacultad";
            this.Text = "frmAgregarFacultad";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacultad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Navegador.Navegador navegador1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dgvFacultad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
    }
}