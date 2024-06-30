namespace PEASA_App
{
    partial class AltaTrabajadorEstampados
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
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_AddEstampadosWorker = new System.Windows.Forms.Button();
            this.txt_largeNomina = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nomina = new System.Windows.Forms.TextBox();
            this.txt_workCenter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_supervisor = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCloseWindow = new System.Windows.Forms.Button();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(74, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 25);
            this.label7.TabIndex = 44;
            this.label7.Text = "Nómina larga:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(142, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(401, 31);
            this.label6.TabIndex = 43;
            this.label6.Text = "Dar de alta trabajador en estampados";
            // 
            // btn_AddEstampadosWorker
            // 
            this.btn_AddEstampadosWorker.Location = new System.Drawing.Point(263, 281);
            this.btn_AddEstampadosWorker.Name = "btn_AddEstampadosWorker";
            this.btn_AddEstampadosWorker.Size = new System.Drawing.Size(163, 44);
            this.btn_AddEstampadosWorker.TabIndex = 42;
            this.btn_AddEstampadosWorker.Text = "Dar de alta";
            this.btn_AddEstampadosWorker.UseVisualStyleBackColor = true;
            this.btn_AddEstampadosWorker.Click += new System.EventHandler(this.btn_AddEstampadosWorker_Click);
            // 
            // txt_largeNomina
            // 
            this.txt_largeNomina.Location = new System.Drawing.Point(218, 130);
            this.txt_largeNomina.Name = "txt_largeNomina";
            this.txt_largeNomina.Size = new System.Drawing.Size(283, 22);
            this.txt_largeNomina.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(114, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 25);
            this.label2.TabIndex = 36;
            this.label2.Text = "Nómina:";
            // 
            // txt_nomina
            // 
            this.txt_nomina.Location = new System.Drawing.Point(218, 89);
            this.txt_nomina.Name = "txt_nomina";
            this.txt_nomina.Size = new System.Drawing.Size(283, 22);
            this.txt_nomina.TabIndex = 35;
            // 
            // txt_workCenter
            // 
            this.txt_workCenter.Location = new System.Drawing.Point(218, 176);
            this.txt_workCenter.Name = "txt_workCenter";
            this.txt_workCenter.Size = new System.Drawing.Size(283, 22);
            this.txt_workCenter.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 25);
            this.label1.TabIndex = 53;
            this.label1.Text = "Centro de trabajo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(93, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 25);
            this.label3.TabIndex = 55;
            this.label3.Text = "Supervisor:";
            // 
            // cb_supervisor
            // 
            this.cb_supervisor.FormattingEnabled = true;
            this.cb_supervisor.Items.AddRange(new object[] {
            "Marcos Narciso",
            "Oscar Armendariz"});
            this.cb_supervisor.Location = new System.Drawing.Point(218, 216);
            this.cb_supervisor.Name = "cb_supervisor";
            this.cb_supervisor.Size = new System.Drawing.Size(283, 24);
            this.cb_supervisor.TabIndex = 56;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_supervisor);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_workCenter);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btn_AddEstampadosWorker);
            this.groupBox1.Controls.Add(this.txt_largeNomina);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_nomina);
            this.groupBox1.Location = new System.Drawing.Point(131, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(659, 364);
            this.groupBox1.TabIndex = 57;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registrar";
            // 
            // btnCloseWindow
            // 
            this.btnCloseWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseWindow.BackgroundImage = global::PEASA_App.Properties.Resources.Close_png;
            this.btnCloseWindow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCloseWindow.FlatAppearance.BorderSize = 0;
            this.btnCloseWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseWindow.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnCloseWindow.Location = new System.Drawing.Point(827, 2);
            this.btnCloseWindow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCloseWindow.Name = "btnCloseWindow";
            this.btnCloseWindow.Size = new System.Drawing.Size(63, 23);
            this.btnCloseWindow.TabIndex = 6;
            this.btnCloseWindow.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnCloseWindow.UseVisualStyleBackColor = true;
            this.btnCloseWindow.Click += new System.EventHandler(this.btnCloseWindow_Click);
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelTitle.Controls.Add(this.btnCloseWindow);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(890, 26);
            this.panelTitle.TabIndex = 51;
            this.panelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseDown);
            // 
            // AltaTrabajadorEstampados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(890, 412);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AltaTrabajadorEstampados";
            this.Text = "AltaTrabajadorEstampados";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelTitle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_AddEstampadosWorker;
        private System.Windows.Forms.TextBox txt_largeNomina;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nomina;
        private System.Windows.Forms.TextBox txt_workCenter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_supervisor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCloseWindow;
        private System.Windows.Forms.Panel panelTitle;
    }
}