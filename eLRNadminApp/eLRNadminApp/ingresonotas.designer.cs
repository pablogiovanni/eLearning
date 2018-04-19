namespace eLRNadminApp
{
    partial class ingresonotas
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
            this.cmb_ciclo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_anio = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Codigo_curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ciclo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jornada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Actividad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCalidicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_ciclo
            // 
            this.cmb_ciclo.FormattingEnabled = true;
            this.cmb_ciclo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cmb_ciclo.Location = new System.Drawing.Point(396, 109);
            this.cmb_ciclo.Name = "cmb_ciclo";
            this.cmb_ciclo.Size = new System.Drawing.Size(121, 24);
            this.cmb_ciclo.TabIndex = 11;
            this.cmb_ciclo.Text = "Ciclo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(198, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Codigo del Curso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(194, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(358, 38);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ingreso Calificaciones";
            // 
            // cmb_anio
            // 
            this.cmb_anio.FormattingEnabled = true;
            this.cmb_anio.Items.AddRange(new object[] {
            "2018",
            "2019",
            "2020"});
            this.cmb_anio.Location = new System.Drawing.Point(395, 67);
            this.cmb_anio.Name = "cmb_anio";
            this.cmb_anio.Size = new System.Drawing.Size(121, 24);
            this.cmb_anio.TabIndex = 13;
            this.cmb_anio.Text = "Año";
            this.cmb_anio.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo_curso,
            this.Nombre,
            this.Ciclo,
            this.Jornada,
            this.Actividad,
            this.valor,
            this.totalCalidicacion});
            this.dataGridView1.Location = new System.Drawing.Point(200, 254);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(870, 192);
            this.dataGridView1.TabIndex = 14;
            // 
            // Codigo_curso
            // 
            this.Codigo_curso.HeaderText = "Codigo Alumno";
            this.Codigo_curso.Name = "Codigo_curso";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre Alumno";
            this.Nombre.Name = "Nombre";
            // 
            // Ciclo
            // 
            this.Ciclo.HeaderText = "Ciclo";
            this.Ciclo.Name = "Ciclo";
            // 
            // Jornada
            // 
            this.Jornada.HeaderText = "Jornada";
            this.Jornada.Name = "Jornada";
            // 
            // Actividad
            // 
            this.Actividad.HeaderText = "Actividad";
            this.Actividad.Name = "Actividad";
            // 
            // valor
            // 
            this.valor.HeaderText = "Valor Actividad";
            this.valor.Name = "valor";
            // 
            // totalCalidicacion
            // 
            this.totalCalidicacion.HeaderText = "Total";
            this.totalCalidicacion.Name = "totalCalidicacion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(198, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Codigo del Curso";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(198, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Codigo del Curso";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "Matutina",
            "Vespertina",
            "Fin de Semana"});
            this.comboBox4.Location = new System.Drawing.Point(395, 157);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 24);
            this.comboBox4.TabIndex = 18;
            this.comboBox4.Text = "Curso";
            // 
            // ingresonotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 508);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmb_anio);
            this.Controls.Add(this.cmb_ciclo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Name = "ingresonotas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingreso Notas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmb_ciclo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_anio;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ciclo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jornada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Actividad;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCalidicacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox4;
    }
}