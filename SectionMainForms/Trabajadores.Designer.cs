namespace PEASA_App
{
    partial class Trabajadores
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
            this.btn_deleteJobCenter = new System.Windows.Forms.Button();
            this.btn_searchName = new System.Windows.Forms.Button();
            this.btn_addjobarea = new System.Windows.Forms.Button();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.dtgv_jobcenter = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nomina = new System.Windows.Forms.TextBox();
            this.btn_searchGender = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_searchJoinDate = new System.Windows.Forms.Button();
            this.dateTime_Joindate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_gender = new System.Windows.Forms.ComboBox();
            this.btn_searchWorkCenter = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_WorkArea = new System.Windows.Forms.TextBox();
            this.btn_searchProductionline = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_supervisor = new System.Windows.Forms.TextBox();
            this.btn_searchSuper = new System.Windows.Forms.Button();
            this.btn_searchNomina = new System.Windows.Forms.Button();
            this.btn_SearchWorkArea = new System.Windows.Forms.Button();
            this.txt_CenterJob = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_ProductionLine = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarNuevoTrabajadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incapacidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darDeAltaIncapacidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bajasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darDeBajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_jobcenter)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_deleteJobCenter
            // 
            this.btn_deleteJobCenter.Image = global::PEASA_App.Properties.Resources.borrar;
            this.btn_deleteJobCenter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_deleteJobCenter.Location = new System.Drawing.Point(1428, 73);
            this.btn_deleteJobCenter.Name = "btn_deleteJobCenter";
            this.btn_deleteJobCenter.Size = new System.Drawing.Size(124, 40);
            this.btn_deleteJobCenter.TabIndex = 24;
            this.btn_deleteJobCenter.Text = "Borrar";
            this.btn_deleteJobCenter.UseVisualStyleBackColor = true;
            // 
            // btn_searchName
            // 
            this.btn_searchName.Image = global::PEASA_App.Properties.Resources.Busqueda;
            this.btn_searchName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_searchName.Location = new System.Drawing.Point(379, 85);
            this.btn_searchName.Name = "btn_searchName";
            this.btn_searchName.Size = new System.Drawing.Size(124, 40);
            this.btn_searchName.TabIndex = 23;
            this.btn_searchName.Text = "Buscar";
            this.btn_searchName.UseVisualStyleBackColor = true;
            this.btn_searchName.Click += new System.EventHandler(this.btn_searchName_Click);
            // 
            // btn_addjobarea
            // 
            this.btn_addjobarea.Image = global::PEASA_App.Properties.Resources.agregar;
            this.btn_addjobarea.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_addjobarea.Location = new System.Drawing.Point(1428, 120);
            this.btn_addjobarea.Name = "btn_addjobarea";
            this.btn_addjobarea.Size = new System.Drawing.Size(124, 40);
            this.btn_addjobarea.TabIndex = 22;
            this.btn_addjobarea.Text = "Agregar ";
            this.btn_addjobarea.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_addjobarea.UseVisualStyleBackColor = true;
            this.btn_addjobarea.Click += new System.EventHandler(this.btn_addjobarea_Click);
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(22, 98);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(351, 22);
            this.txt_Name.TabIndex = 21;
            // 
            // dtgv_jobcenter
            // 
            this.dtgv_jobcenter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgv_jobcenter.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(218)))), ((int)(((byte)(250)))));
            this.dtgv_jobcenter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgv_jobcenter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_jobcenter.Location = new System.Drawing.Point(22, 313);
            this.dtgv_jobcenter.Name = "dtgv_jobcenter";
            this.dtgv_jobcenter.RowHeadersWidth = 51;
            this.dtgv_jobcenter.RowTemplate.Height = 24;
            this.dtgv_jobcenter.Size = new System.Drawing.Size(1536, 478);
            this.dtgv_jobcenter.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 18);
            this.label1.TabIndex = 25;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 18);
            this.label2.TabIndex = 26;
            this.label2.Text = "Nómina:";
            // 
            // txt_nomina
            // 
            this.txt_nomina.Location = new System.Drawing.Point(22, 140);
            this.txt_nomina.Name = "txt_nomina";
            this.txt_nomina.Size = new System.Drawing.Size(351, 22);
            this.txt_nomina.TabIndex = 27;
            // 
            // btn_searchGender
            // 
            this.btn_searchGender.Image = global::PEASA_App.Properties.Resources.Busqueda;
            this.btn_searchGender.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_searchGender.Location = new System.Drawing.Point(741, 89);
            this.btn_searchGender.Name = "btn_searchGender";
            this.btn_searchGender.Size = new System.Drawing.Size(124, 40);
            this.btn_searchGender.TabIndex = 28;
            this.btn_searchGender.Text = "Buscar";
            this.btn_searchGender.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 18);
            this.label3.TabIndex = 30;
            this.label3.Text = "Fecha de ingreso:";
            // 
            // btn_searchJoinDate
            // 
            this.btn_searchJoinDate.Image = global::PEASA_App.Properties.Resources.Busqueda;
            this.btn_searchJoinDate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_searchJoinDate.Location = new System.Drawing.Point(379, 182);
            this.btn_searchJoinDate.Name = "btn_searchJoinDate";
            this.btn_searchJoinDate.Size = new System.Drawing.Size(124, 40);
            this.btn_searchJoinDate.TabIndex = 31;
            this.btn_searchJoinDate.Text = "Buscar";
            this.btn_searchJoinDate.UseVisualStyleBackColor = true;
            // 
            // dateTime_Joindate
            // 
            this.dateTime_Joindate.Location = new System.Drawing.Point(22, 189);
            this.dateTime_Joindate.Name = "dateTime_Joindate";
            this.dateTime_Joindate.Size = new System.Drawing.Size(351, 22);
            this.dateTime_Joindate.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(589, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 18);
            this.label4.TabIndex = 33;
            this.label4.Text = "Sexo:";
            // 
            // cb_gender
            // 
            this.cb_gender.FormattingEnabled = true;
            this.cb_gender.Location = new System.Drawing.Point(593, 96);
            this.cb_gender.Name = "cb_gender";
            this.cb_gender.Size = new System.Drawing.Size(142, 24);
            this.cb_gender.TabIndex = 34;
            // 
            // btn_searchWorkCenter
            // 
            this.btn_searchWorkCenter.Image = global::PEASA_App.Properties.Resources.Busqueda;
            this.btn_searchWorkCenter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_searchWorkCenter.Location = new System.Drawing.Point(930, 185);
            this.btn_searchWorkCenter.Name = "btn_searchWorkCenter";
            this.btn_searchWorkCenter.Size = new System.Drawing.Size(124, 40);
            this.btn_searchWorkCenter.TabIndex = 35;
            this.btn_searchWorkCenter.Text = "Buscar";
            this.btn_searchWorkCenter.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(589, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 18);
            this.label5.TabIndex = 36;
            this.label5.Text = "Linea de producción:";
            // 
            // txt_WorkArea
            // 
            this.txt_WorkArea.Location = new System.Drawing.Point(27, 243);
            this.txt_WorkArea.Name = "txt_WorkArea";
            this.txt_WorkArea.Size = new System.Drawing.Size(346, 22);
            this.txt_WorkArea.TabIndex = 37;
            // 
            // btn_searchProductionline
            // 
            this.btn_searchProductionline.Image = global::PEASA_App.Properties.Resources.Busqueda;
            this.btn_searchProductionline.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_searchProductionline.Location = new System.Drawing.Point(930, 234);
            this.btn_searchProductionline.Name = "btn_searchProductionline";
            this.btn_searchProductionline.Size = new System.Drawing.Size(124, 40);
            this.btn_searchProductionline.TabIndex = 38;
            this.btn_searchProductionline.Text = "Buscar";
            this.btn_searchProductionline.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(589, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 18);
            this.label6.TabIndex = 39;
            this.label6.Text = "Supervisor:";
            // 
            // txt_supervisor
            // 
            this.txt_supervisor.Location = new System.Drawing.Point(593, 146);
            this.txt_supervisor.Name = "txt_supervisor";
            this.txt_supervisor.Size = new System.Drawing.Size(331, 22);
            this.txt_supervisor.TabIndex = 40;
            // 
            // btn_searchSuper
            // 
            this.btn_searchSuper.Image = global::PEASA_App.Properties.Resources.Busqueda;
            this.btn_searchSuper.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_searchSuper.Location = new System.Drawing.Point(930, 131);
            this.btn_searchSuper.Name = "btn_searchSuper";
            this.btn_searchSuper.Size = new System.Drawing.Size(124, 40);
            this.btn_searchSuper.TabIndex = 41;
            this.btn_searchSuper.Text = "Buscar";
            this.btn_searchSuper.UseVisualStyleBackColor = true;
            // 
            // btn_searchNomina
            // 
            this.btn_searchNomina.Image = global::PEASA_App.Properties.Resources.Busqueda;
            this.btn_searchNomina.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_searchNomina.Location = new System.Drawing.Point(379, 131);
            this.btn_searchNomina.Name = "btn_searchNomina";
            this.btn_searchNomina.Size = new System.Drawing.Size(124, 40);
            this.btn_searchNomina.TabIndex = 42;
            this.btn_searchNomina.Text = "Buscar";
            this.btn_searchNomina.UseVisualStyleBackColor = true;
            this.btn_searchNomina.Click += new System.EventHandler(this.btn_searchNomina_Click);
            // 
            // btn_SearchWorkArea
            // 
            this.btn_SearchWorkArea.Image = global::PEASA_App.Properties.Resources.Busqueda;
            this.btn_SearchWorkArea.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SearchWorkArea.Location = new System.Drawing.Point(379, 234);
            this.btn_SearchWorkArea.Name = "btn_SearchWorkArea";
            this.btn_SearchWorkArea.Size = new System.Drawing.Size(124, 40);
            this.btn_SearchWorkArea.TabIndex = 43;
            this.btn_SearchWorkArea.Text = "Buscar";
            this.btn_SearchWorkArea.UseVisualStyleBackColor = true;
            // 
            // txt_CenterJob
            // 
            this.txt_CenterJob.Location = new System.Drawing.Point(593, 194);
            this.txt_CenterJob.Name = "txt_CenterJob";
            this.txt_CenterJob.Size = new System.Drawing.Size(331, 22);
            this.txt_CenterJob.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(589, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 18);
            this.label7.TabIndex = 45;
            this.label7.Text = "Centro de trabajo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 18);
            this.label8.TabIndex = 46;
            this.label8.Text = "Área de trabajo:";
            // 
            // txt_ProductionLine
            // 
            this.txt_ProductionLine.Location = new System.Drawing.Point(593, 242);
            this.txt_ProductionLine.Name = "txt_ProductionLine";
            this.txt_ProductionLine.Size = new System.Drawing.Size(331, 22);
            this.txt_ProductionLine.TabIndex = 47;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.incapacidadesToolStripMenuItem,
            this.bajasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1756, 28);
            this.menuStrip1.TabIndex = 48;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarNuevoTrabajadorToolStripMenuItem});
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            // 
            // agregarNuevoTrabajadorToolStripMenuItem
            // 
            this.agregarNuevoTrabajadorToolStripMenuItem.Name = "agregarNuevoTrabajadorToolStripMenuItem";
            this.agregarNuevoTrabajadorToolStripMenuItem.Size = new System.Drawing.Size(264, 26);
            this.agregarNuevoTrabajadorToolStripMenuItem.Text = "Agregar nuevo trabajador";
            this.agregarNuevoTrabajadorToolStripMenuItem.Click += new System.EventHandler(this.agregarNuevoTrabajadorToolStripMenuItem_Click);
            // 
            // incapacidadesToolStripMenuItem
            // 
            this.incapacidadesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.darDeAltaIncapacidadToolStripMenuItem});
            this.incapacidadesToolStripMenuItem.Name = "incapacidadesToolStripMenuItem";
            this.incapacidadesToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.incapacidadesToolStripMenuItem.Text = "Incapacidades";
            // 
            // darDeAltaIncapacidadToolStripMenuItem
            // 
            this.darDeAltaIncapacidadToolStripMenuItem.Name = "darDeAltaIncapacidadToolStripMenuItem";
            this.darDeAltaIncapacidadToolStripMenuItem.Size = new System.Drawing.Size(290, 26);
            this.darDeAltaIncapacidadToolStripMenuItem.Text = "Dar de alta/baja  incapacidad";
            this.darDeAltaIncapacidadToolStripMenuItem.Click += new System.EventHandler(this.darDeAltaIncapacidadToolStripMenuItem_Click);
            // 
            // bajasToolStripMenuItem
            // 
            this.bajasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.darDeBajaToolStripMenuItem});
            this.bajasToolStripMenuItem.Name = "bajasToolStripMenuItem";
            this.bajasToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.bajasToolStripMenuItem.Text = "Bajas";
            // 
            // darDeBajaToolStripMenuItem
            // 
            this.darDeBajaToolStripMenuItem.Name = "darDeBajaToolStripMenuItem";
            this.darDeBajaToolStripMenuItem.Size = new System.Drawing.Size(268, 26);
            this.darDeBajaToolStripMenuItem.Text = "Dar de baja un trabajador ";
            this.darDeBajaToolStripMenuItem.Click += new System.EventHandler(this.darDeBajaToolStripMenuItem_Click);
            // 
            // Trabajadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(218)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1756, 835);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.txt_ProductionLine);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_CenterJob);
            this.Controls.Add(this.btn_SearchWorkArea);
            this.Controls.Add(this.btn_searchNomina);
            this.Controls.Add(this.btn_searchSuper);
            this.Controls.Add(this.txt_supervisor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_searchProductionline);
            this.Controls.Add(this.txt_WorkArea);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_searchWorkCenter);
            this.Controls.Add(this.cb_gender);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTime_Joindate);
            this.Controls.Add(this.btn_searchJoinDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_searchGender);
            this.Controls.Add(this.txt_nomina);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_deleteJobCenter);
            this.Controls.Add(this.btn_searchName);
            this.Controls.Add(this.btn_addjobarea);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.dtgv_jobcenter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Trabajadores";
            this.Text = "Trabajadores";
            this.Load += new System.EventHandler(this.Trabajadores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_jobcenter)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_deleteJobCenter;
        private System.Windows.Forms.Button btn_searchName;
        private System.Windows.Forms.Button btn_addjobarea;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.DataGridView dtgv_jobcenter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nomina;
        private System.Windows.Forms.Button btn_searchGender;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_searchJoinDate;
        private System.Windows.Forms.DateTimePicker dateTime_Joindate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_gender;
        private System.Windows.Forms.Button btn_searchWorkCenter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_WorkArea;
        private System.Windows.Forms.Button btn_searchProductionline;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_supervisor;
        private System.Windows.Forms.Button btn_searchSuper;
        private System.Windows.Forms.Button btn_searchNomina;
        private System.Windows.Forms.Button btn_SearchWorkArea;
        private System.Windows.Forms.TextBox txt_CenterJob;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_ProductionLine;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarNuevoTrabajadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incapacidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darDeAltaIncapacidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bajasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darDeBajaToolStripMenuItem;
    }
}