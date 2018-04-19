namespace eLRNadminApp
{
    partial class frmhorarios
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
            this.dgvHorarios = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbFacultad = new System.Windows.Forms.TextBox();
            this.tbCurso = new System.Windows.Forms.TextBox();
            this.tbCarrera = new System.Windows.Forms.TextBox();
            this.tbCatedratico = new System.Windows.Forms.TextBox();
            this.tbSalon = new System.Windows.Forms.TextBox();
            this.tbEdificio = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.dtF = new System.Windows.Forms.DateTimePicker();
            this.dtI = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.tbSeccion = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbLunes = new System.Windows.Forms.TextBox();
            this.tbMartes = new System.Windows.Forms.TextBox();
            this.tbMiercoles = new System.Windows.Forms.TextBox();
            this.tbJueves = new System.Windows.Forms.TextBox();
            this.tbSabado = new System.Windows.Forms.TextBox();
            this.tbViernes = new System.Windows.Forms.TextBox();
            this.tbDomingo = new System.Windows.Forms.TextBox();
            this.lbl_id_cat = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorarios)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(57, 20);
            this.navegador1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(745, 58);
            this.navegador1.sNombreBD = null;
            this.navegador1.sNombreTabla = null;
            this.navegador1.sPass = null;
            this.navegador1.sResult = null;
            this.navegador1.sServidor = null;
            this.navegador1.sUsuario = null;
            this.navegador1.TabIndex = 0;
            this.navegador1.RecibidorActualizar += new System.EventHandler(this.navegador1_RecibidorActualizar);
            this.navegador1.RecibidorSiguiente += new System.EventHandler(this.navegador1_RecibidorSiguiente);
            this.navegador1.RecibidorAnterior += new System.EventHandler(this.navegador1_RecibidorAnterior);
            this.navegador1.RecibidorPrimero += new System.EventHandler(this.navegador1_RecibidorPrimero);
            this.navegador1.RecibidorUltimo += new System.EventHandler(this.navegador1_RecibidorUltimo);
            // 
            // dgvHorarios
            // 
            this.dgvHorarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHorarios.Location = new System.Drawing.Point(16, 352);
            this.dgvHorarios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvHorarios.Name = "dgvHorarios";
            this.dgvHorarios.Size = new System.Drawing.Size(884, 193);
            this.dgvHorarios.TabIndex = 1;
            this.dgvHorarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHorarios_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_id_cat);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbFacultad);
            this.panel1.Controls.Add(this.tbCurso);
            this.panel1.Controls.Add(this.tbCarrera);
            this.panel1.Controls.Add(this.tbCatedratico);
            this.panel1.Controls.Add(this.tbSalon);
            this.panel1.Controls.Add(this.tbEdificio);
            this.panel1.Controls.Add(this.tbID);
            this.panel1.Location = new System.Drawing.Point(23, 132);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(877, 94);
            this.panel1.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(403, 25);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 17);
            this.label7.TabIndex = 29;
            this.label7.Text = "Carrera ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(575, 25);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 17);
            this.label6.TabIndex = 28;
            this.label6.Text = "Facultad ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 63);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "Catedratico ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(241, 62);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "Salon ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(403, 62);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Edificio ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "Curso ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "ID:";
            // 
            // tbFacultad
            // 
            this.tbFacultad.Location = new System.Drawing.Point(669, 16);
            this.tbFacultad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbFacultad.Name = "tbFacultad";
            this.tbFacultad.Size = new System.Drawing.Size(77, 22);
            this.tbFacultad.TabIndex = 22;
            // 
            // tbCurso
            // 
            this.tbCurso.Location = new System.Drawing.Point(316, 16);
            this.tbCurso.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbCurso.Name = "tbCurso";
            this.tbCurso.Size = new System.Drawing.Size(77, 22);
            this.tbCurso.TabIndex = 21;
            // 
            // tbCarrera
            // 
            this.tbCarrera.Location = new System.Drawing.Point(488, 16);
            this.tbCarrera.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbCarrera.Name = "tbCarrera";
            this.tbCarrera.Size = new System.Drawing.Size(77, 22);
            this.tbCarrera.TabIndex = 20;
            // 
            // tbCatedratico
            // 
            this.tbCatedratico.Location = new System.Drawing.Point(144, 54);
            this.tbCatedratico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbCatedratico.Name = "tbCatedratico";
            this.tbCatedratico.Size = new System.Drawing.Size(77, 22);
            this.tbCatedratico.TabIndex = 19;
            // 
            // tbSalon
            // 
            this.tbSalon.Location = new System.Drawing.Point(316, 53);
            this.tbSalon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbSalon.Name = "tbSalon";
            this.tbSalon.Size = new System.Drawing.Size(77, 22);
            this.tbSalon.TabIndex = 18;
            // 
            // tbEdificio
            // 
            this.tbEdificio.Location = new System.Drawing.Point(488, 53);
            this.tbEdificio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbEdificio.Name = "tbEdificio";
            this.tbEdificio.Size = new System.Drawing.Size(77, 22);
            this.tbEdificio.TabIndex = 17;
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(144, 12);
            this.tbID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(77, 22);
            this.tbID.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.navegador1);
            this.panel2.Location = new System.Drawing.Point(23, 15);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(877, 95);
            this.panel2.TabIndex = 17;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.dtF);
            this.panel3.Controls.Add(this.dtI);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.tbSeccion);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.tbLunes);
            this.panel3.Controls.Add(this.tbMartes);
            this.panel3.Controls.Add(this.tbMiercoles);
            this.panel3.Controls.Add(this.tbJueves);
            this.panel3.Controls.Add(this.tbSabado);
            this.panel3.Controls.Add(this.tbViernes);
            this.panel3.Controls.Add(this.tbDomingo);
            this.panel3.Location = new System.Drawing.Point(23, 244);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(877, 101);
            this.panel3.TabIndex = 18;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(449, 64);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(91, 17);
            this.label17.TabIndex = 19;
            this.label17.Text = "Hora finaliza:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(236, 62);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(79, 17);
            this.label16.TabIndex = 18;
            this.label16.Text = "Hora inicio:";
            // 
            // dtF
            // 
            this.dtF.CustomFormat = "Hh";
            this.dtF.Location = new System.Drawing.Point(551, 55);
            this.dtF.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtF.Name = "dtF";
            this.dtF.Size = new System.Drawing.Size(115, 22);
            this.dtF.TabIndex = 17;
            this.dtF.Value = new System.DateTime(2018, 4, 17, 19, 3, 0, 0);
            // 
            // dtI
            // 
            this.dtI.CustomFormat = "Hh";
            this.dtI.Location = new System.Drawing.Point(325, 54);
            this.dtI.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtI.Name = "dtI";
            this.dtI.Size = new System.Drawing.Size(115, 22);
            this.dtI.TabIndex = 16;
            this.dtI.Value = new System.DateTime(2018, 4, 17, 19, 3, 0, 0);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(39, 64);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 17);
            this.label15.TabIndex = 15;
            this.label15.Text = "Seccion:";
            // 
            // tbSeccion
            // 
            this.tbSeccion.Location = new System.Drawing.Point(116, 55);
            this.tbSeccion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbSeccion.Name = "tbSeccion";
            this.tbSeccion.Size = new System.Drawing.Size(33, 22);
            this.tbSeccion.TabIndex = 14;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(705, 23);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 17);
            this.label14.TabIndex = 13;
            this.label14.Text = "Sabado:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(593, 25);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 17);
            this.label13.TabIndex = 12;
            this.label13.Text = "Viernes:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(484, 25);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 17);
            this.label12.TabIndex = 11;
            this.label12.Text = "Jueves:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(368, 25);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 17);
            this.label11.TabIndex = 10;
            this.label11.Text = "Miercoles:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(261, 25);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = "Martes:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(159, 25);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Lunes:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 25);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Domingo:";
            // 
            // tbLunes
            // 
            this.tbLunes.Location = new System.Drawing.Point(219, 16);
            this.tbLunes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbLunes.Name = "tbLunes";
            this.tbLunes.Size = new System.Drawing.Size(33, 22);
            this.tbLunes.TabIndex = 6;
            // 
            // tbMartes
            // 
            this.tbMartes.Location = new System.Drawing.Point(325, 16);
            this.tbMartes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbMartes.Name = "tbMartes";
            this.tbMartes.Size = new System.Drawing.Size(33, 22);
            this.tbMartes.TabIndex = 5;
            // 
            // tbMiercoles
            // 
            this.tbMiercoles.Location = new System.Drawing.Point(441, 16);
            this.tbMiercoles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbMiercoles.Name = "tbMiercoles";
            this.tbMiercoles.Size = new System.Drawing.Size(33, 22);
            this.tbMiercoles.TabIndex = 4;
            // 
            // tbJueves
            // 
            this.tbJueves.Location = new System.Drawing.Point(551, 16);
            this.tbJueves.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbJueves.Name = "tbJueves";
            this.tbJueves.Size = new System.Drawing.Size(33, 22);
            this.tbJueves.TabIndex = 3;
            // 
            // tbSabado
            // 
            this.tbSabado.Location = new System.Drawing.Point(776, 16);
            this.tbSabado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbSabado.Name = "tbSabado";
            this.tbSabado.Size = new System.Drawing.Size(33, 22);
            this.tbSabado.TabIndex = 2;
            // 
            // tbViernes
            // 
            this.tbViernes.Location = new System.Drawing.Point(661, 16);
            this.tbViernes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbViernes.Name = "tbViernes";
            this.tbViernes.Size = new System.Drawing.Size(33, 22);
            this.tbViernes.TabIndex = 1;
            // 
            // tbDomingo
            // 
            this.tbDomingo.Location = new System.Drawing.Point(116, 16);
            this.tbDomingo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbDomingo.Name = "tbDomingo";
            this.tbDomingo.Size = new System.Drawing.Size(33, 22);
            this.tbDomingo.TabIndex = 0;
            // 
            // lbl_id_cat
            // 
            this.lbl_id_cat.AutoSize = true;
            this.lbl_id_cat.Location = new System.Drawing.Point(666, 59);
            this.lbl_id_cat.Name = "lbl_id_cat";
            this.lbl_id_cat.Size = new System.Drawing.Size(13, 17);
            this.lbl_id_cat.TabIndex = 30;
            this.lbl_id_cat.Text = "-";
            // 
            // frmhorarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(943, 560);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvHorarios);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmhorarios";
            this.Text = "Horarios";
            this.Load += new System.EventHandler(this.frmhorarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorarios)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Navegador.Navegador navegador1;
        private System.Windows.Forms.DataGridView dgvHorarios;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFacultad;
        private System.Windows.Forms.TextBox tbCurso;
        private System.Windows.Forms.TextBox tbCarrera;
        private System.Windows.Forms.TextBox tbCatedratico;
        private System.Windows.Forms.TextBox tbSalon;
        private System.Windows.Forms.TextBox tbEdificio;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbSeccion;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbLunes;
        private System.Windows.Forms.TextBox tbMartes;
        private System.Windows.Forms.TextBox tbMiercoles;
        private System.Windows.Forms.TextBox tbJueves;
        private System.Windows.Forms.TextBox tbSabado;
        private System.Windows.Forms.TextBox tbViernes;
        private System.Windows.Forms.TextBox tbDomingo;
        private System.Windows.Forms.DateTimePicker dtI;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker dtF;
        private System.Windows.Forms.Label lbl_id_cat;
    }
}