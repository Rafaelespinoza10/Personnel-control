namespace PEASA_App
{
    partial class AgregarTrabajador
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
            this.panelTitle = new System.Windows.Forms.Panel();
            this.btnCloseWindow = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_AddNewWorker = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_largeNomina = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nomina = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_Name = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbx_Sex = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_route = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_WorkArea = new System.Windows.Forms.TextBox();
            this.dtime_dateStart = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_education = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_origin = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dt_birthDay = new System.Windows.Forms.DateTimePicker();
            this.cb_parents = new System.Windows.Forms.ComboBox();
            this.panelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelTitle.Controls.Add(this.btnCloseWindow);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(557, 26);
            this.panelTitle.TabIndex = 25;
            this.panelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseDown);
            // 
            // btnCloseWindow
            // 
            this.btnCloseWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseWindow.BackgroundImage = global::PEASA_App.Properties.Resources.Close_png;
            this.btnCloseWindow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCloseWindow.FlatAppearance.BorderSize = 0;
            this.btnCloseWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseWindow.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnCloseWindow.Location = new System.Drawing.Point(494, 2);
            this.btnCloseWindow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCloseWindow.Name = "btnCloseWindow";
            this.btnCloseWindow.Size = new System.Drawing.Size(63, 23);
            this.btnCloseWindow.TabIndex = 6;
            this.btnCloseWindow.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnCloseWindow.UseVisualStyleBackColor = true;
            this.btnCloseWindow.Click += new System.EventHandler(this.btnCloseWindow_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(189, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 31);
            this.label6.TabIndex = 24;
            this.label6.Text = "Nuevo trabajador";
            // 
            // btn_AddNewWorker
            // 
            this.btn_AddNewWorker.Location = new System.Drawing.Point(195, 559);
            this.btn_AddNewWorker.Name = "btn_AddNewWorker";
            this.btn_AddNewWorker.Size = new System.Drawing.Size(127, 45);
            this.btn_AddNewWorker.TabIndex = 23;
            this.btn_AddNewWorker.Text = "Agregar";
            this.btn_AddNewWorker.UseVisualStyleBackColor = true;
            this.btn_AddNewWorker.Click += new System.EventHandler(this.btn_AddNewWorker_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(153, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 25);
            this.label5.TabIndex = 22;
            this.label5.Text = "Sexo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 25);
            this.label4.TabIndex = 20;
            this.label4.Text = "Fecha de nacimiento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "Fecha de ingreso:";
            // 
            // txt_largeNomina
            // 
            this.txt_largeNomina.Location = new System.Drawing.Point(226, 167);
            this.txt_largeNomina.Name = "txt_largeNomina";
            this.txt_largeNomina.Size = new System.Drawing.Size(283, 22);
            this.txt_largeNomina.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(130, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nómina:";
            // 
            // txt_nomina
            // 
            this.txt_nomina.Location = new System.Drawing.Point(226, 131);
            this.txt_nomina.Name = "txt_nomina";
            this.txt_nomina.Size = new System.Drawing.Size(283, 22);
            this.txt_nomina.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nombre completo:";
            // 
            // txb_Name
            // 
            this.txb_Name.Location = new System.Drawing.Point(226, 95);
            this.txb_Name.Name = "txb_Name";
            this.txb_Name.Size = new System.Drawing.Size(283, 22);
            this.txb_Name.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(86, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 25);
            this.label7.TabIndex = 26;
            this.label7.Text = "Nómina larga:";
            // 
            // cbx_Sex
            // 
            this.cbx_Sex.FormattingEnabled = true;
            this.cbx_Sex.Items.AddRange(new object[] {
            "H",
            "M"});
            this.cbx_Sex.Location = new System.Drawing.Point(226, 281);
            this.cbx_Sex.Name = "cbx_Sex";
            this.cbx_Sex.Size = new System.Drawing.Size(283, 24);
            this.cbx_Sex.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(153, 314);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 25);
            this.label8.TabIndex = 28;
            this.label8.Text = "Ruta:";
            // 
            // txt_route
            // 
            this.txt_route.Location = new System.Drawing.Point(226, 318);
            this.txt_route.Name = "txt_route";
            this.txt_route.Size = new System.Drawing.Size(283, 22);
            this.txt_route.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(69, 352);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 25);
            this.label9.TabIndex = 30;
            this.label9.Text = "Área de trabajo:";
            // 
            // txt_WorkArea
            // 
            this.txt_WorkArea.Location = new System.Drawing.Point(226, 355);
            this.txt_WorkArea.Name = "txt_WorkArea";
            this.txt_WorkArea.Size = new System.Drawing.Size(283, 22);
            this.txt_WorkArea.TabIndex = 31;
            // 
            // dtime_dateStart
            // 
            this.dtime_dateStart.Location = new System.Drawing.Point(226, 201);
            this.dtime_dateStart.Name = "dtime_dateStart";
            this.dtime_dateStart.Size = new System.Drawing.Size(283, 22);
            this.dtime_dateStart.TabIndex = 32;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(98, 391);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 25);
            this.label10.TabIndex = 33;
            this.label10.Text = "Escolaridad:";
            // 
            // tb_education
            // 
            this.tb_education.Location = new System.Drawing.Point(225, 395);
            this.tb_education.Name = "tb_education";
            this.tb_education.Size = new System.Drawing.Size(283, 22);
            this.tb_education.TabIndex = 34;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(20, 437);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(186, 25);
            this.label11.TabIndex = 35;
            this.label11.Text = "Lugar de procedencia:";
            // 
            // tb_origin
            // 
            this.tb_origin.Location = new System.Drawing.Point(226, 437);
            this.tb_origin.Name = "tb_origin";
            this.tb_origin.Size = new System.Drawing.Size(283, 22);
            this.tb_origin.TabIndex = 36;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(67, 476);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(133, 25);
            this.label12.TabIndex = 37;
            this.label12.Text = "Padre o madre:";
            // 
            // dt_birthDay
            // 
            this.dt_birthDay.Location = new System.Drawing.Point(226, 239);
            this.dt_birthDay.Name = "dt_birthDay";
            this.dt_birthDay.Size = new System.Drawing.Size(283, 22);
            this.dt_birthDay.TabIndex = 39;
            // 
            // cb_parents
            // 
            this.cb_parents.FormattingEnabled = true;
            this.cb_parents.Items.AddRange(new object[] {
            "Sí",
            "No"});
            this.cb_parents.Location = new System.Drawing.Point(226, 480);
            this.cb_parents.Name = "cb_parents";
            this.cb_parents.Size = new System.Drawing.Size(283, 24);
            this.cb_parents.TabIndex = 40;
            // 
            // AgregarTrabajador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(557, 625);
            this.Controls.Add(this.cb_parents);
            this.Controls.Add(this.dt_birthDay);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tb_origin);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tb_education);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dtime_dateStart);
            this.Controls.Add(this.txt_WorkArea);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_route);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbx_Sex);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_AddNewWorker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_largeNomina);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_nomina);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txb_Name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgregarTrabajador";
            this.Text = "AgregarTrabajador";
            this.panelTitle.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Button btnCloseWindow;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_AddNewWorker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_largeNomina;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nomina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_Name;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbx_Sex;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_route;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_WorkArea;
        private System.Windows.Forms.DateTimePicker dtime_dateStart;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_education;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_origin;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dt_birthDay;
        private System.Windows.Forms.ComboBox cb_parents;
    }
}