namespace PEASA_App
{
    partial class AltaTrabajadoresSoldadura
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
            this.cb_supervisor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_workCenter = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_addSoldaduraWorker = new System.Windows.Forms.Button();
            this.txt_largeNomina = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nomina = new System.Windows.Forms.TextBox();
            this.gp_Registrar = new System.Windows.Forms.GroupBox();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.btnCloseWindow = new System.Windows.Forms.Button();
            this.gp_Registrar.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_supervisor
            // 
            this.cb_supervisor.FormattingEnabled = true;
            this.cb_supervisor.Items.AddRange(new object[] {
            "Oscar Jara",
            "Osvaldo Andraca",
            "David Aranda"});
            this.cb_supervisor.Location = new System.Drawing.Point(210, 216);
            this.cb_supervisor.Name = "cb_supervisor";
            this.cb_supervisor.Size = new System.Drawing.Size(283, 24);
            this.cb_supervisor.TabIndex = 66;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(85, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 25);
            this.label3.TabIndex = 65;
            this.label3.Text = "Supervisor:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 25);
            this.label1.TabIndex = 64;
            this.label1.Text = "Centro de trabajo:";
            // 
            // txt_workCenter
            // 
            this.txt_workCenter.Location = new System.Drawing.Point(210, 176);
            this.txt_workCenter.Name = "txt_workCenter";
            this.txt_workCenter.Size = new System.Drawing.Size(283, 22);
            this.txt_workCenter.TabIndex = 63;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(66, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 25);
            this.label7.TabIndex = 62;
            this.label7.Text = "Nómina larga:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(134, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(474, 31);
            this.label6.TabIndex = 61;
            this.label6.Text = "Dar de alta trabajador en soldadura y punteo";
            // 
            // btn_addSoldaduraWorker
            // 
            this.btn_addSoldaduraWorker.Location = new System.Drawing.Point(255, 281);
            this.btn_addSoldaduraWorker.Name = "btn_addSoldaduraWorker";
            this.btn_addSoldaduraWorker.Size = new System.Drawing.Size(163, 44);
            this.btn_addSoldaduraWorker.TabIndex = 60;
            this.btn_addSoldaduraWorker.Text = "Dar de alta";
            this.btn_addSoldaduraWorker.UseVisualStyleBackColor = true;
            this.btn_addSoldaduraWorker.Click += new System.EventHandler(this.btn_addSoldaduraWorker_Click);
            // 
            // txt_largeNomina
            // 
            this.txt_largeNomina.Location = new System.Drawing.Point(210, 130);
            this.txt_largeNomina.Name = "txt_largeNomina";
            this.txt_largeNomina.Size = new System.Drawing.Size(283, 22);
            this.txt_largeNomina.TabIndex = 59;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(106, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 25);
            this.label2.TabIndex = 58;
            this.label2.Text = "Nómina:";
            // 
            // txt_nomina
            // 
            this.txt_nomina.Location = new System.Drawing.Point(210, 89);
            this.txt_nomina.Name = "txt_nomina";
            this.txt_nomina.Size = new System.Drawing.Size(283, 22);
            this.txt_nomina.TabIndex = 57;
            // 
            // gp_Registrar
            // 
            this.gp_Registrar.Controls.Add(this.cb_supervisor);
            this.gp_Registrar.Controls.Add(this.label3);
            this.gp_Registrar.Controls.Add(this.label1);
            this.gp_Registrar.Controls.Add(this.txt_workCenter);
            this.gp_Registrar.Controls.Add(this.label7);
            this.gp_Registrar.Controls.Add(this.label6);
            this.gp_Registrar.Controls.Add(this.btn_addSoldaduraWorker);
            this.gp_Registrar.Controls.Add(this.txt_largeNomina);
            this.gp_Registrar.Controls.Add(this.label2);
            this.gp_Registrar.Controls.Add(this.txt_nomina);
            this.gp_Registrar.Location = new System.Drawing.Point(124, 32);
            this.gp_Registrar.Name = "gp_Registrar";
            this.gp_Registrar.Size = new System.Drawing.Size(602, 331);
            this.gp_Registrar.TabIndex = 67;
            this.gp_Registrar.TabStop = false;
            this.gp_Registrar.Text = "Registrar";
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelTitle.Controls.Add(this.btnCloseWindow);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(872, 26);
            this.panelTitle.TabIndex = 68;
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
            this.btnCloseWindow.Location = new System.Drawing.Point(809, 2);
            this.btnCloseWindow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCloseWindow.Name = "btnCloseWindow";
            this.btnCloseWindow.Size = new System.Drawing.Size(63, 23);
            this.btnCloseWindow.TabIndex = 6;
            this.btnCloseWindow.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnCloseWindow.UseVisualStyleBackColor = true;
            this.btnCloseWindow.Click += new System.EventHandler(this.btnCloseWindow_Click);
            // 
            // AltaTrabajadoresSoldadura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(872, 365);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.gp_Registrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AltaTrabajadoresSoldadura";
            this.Text = "AltaTrabajadoresSoldadura";
            this.gp_Registrar.ResumeLayout(false);
            this.gp_Registrar.PerformLayout();
            this.panelTitle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_supervisor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_workCenter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_addSoldaduraWorker;
        private System.Windows.Forms.TextBox txt_largeNomina;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nomina;
        private System.Windows.Forms.GroupBox gp_Registrar;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Button btnCloseWindow;
    }
}