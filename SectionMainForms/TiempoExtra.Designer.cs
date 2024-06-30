namespace PEASA_App
{
    partial class TiempoExtra
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_ProductionLine = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_CenterJob = new System.Windows.Forms.TextBox();
            this.btn_searchSuper = new System.Windows.Forms.Button();
            this.txt_supervisor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_searchProductionline = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_searchWorkCenter = new System.Windows.Forms.Button();
            this.btn_searchNomina = new System.Windows.Forms.Button();
            this.txt_nomina = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_searchName = new System.Windows.Forms.Button();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.dtg_extraTime = new System.Windows.Forms.DataGridView();
            this.agregarTiempoExtraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_extraTime)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1772, 28);
            this.menuStrip1.TabIndex = 51;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarTiempoExtraToolStripMenuItem});
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
 //           this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // txt_ProductionLine
            // 
            this.txt_ProductionLine.Location = new System.Drawing.Point(58, 171);
            this.txt_ProductionLine.Name = "txt_ProductionLine";
            this.txt_ProductionLine.Size = new System.Drawing.Size(349, 22);
            this.txt_ProductionLine.TabIndex = 96;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(676, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 18);
            this.label7.TabIndex = 95;
            this.label7.Text = "Centro de trabajo:";
            // 
            // txt_CenterJob
            // 
            this.txt_CenterJob.Location = new System.Drawing.Point(680, 113);
            this.txt_CenterJob.Name = "txt_CenterJob";
            this.txt_CenterJob.Size = new System.Drawing.Size(331, 22);
            this.txt_CenterJob.TabIndex = 94;
            // 
            // btn_searchSuper
            // 
            this.btn_searchSuper.Image = global::PEASA_App.Properties.Resources.Busqueda;
            this.btn_searchSuper.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_searchSuper.Location = new System.Drawing.Point(1017, 50);
            this.btn_searchSuper.Name = "btn_searchSuper";
            this.btn_searchSuper.Size = new System.Drawing.Size(124, 40);
            this.btn_searchSuper.TabIndex = 93;
            this.btn_searchSuper.Text = "Buscar";
            this.btn_searchSuper.UseVisualStyleBackColor = true;
            // 
            // txt_supervisor
            // 
            this.txt_supervisor.Location = new System.Drawing.Point(680, 65);
            this.txt_supervisor.Name = "txt_supervisor";
            this.txt_supervisor.Size = new System.Drawing.Size(331, 22);
            this.txt_supervisor.TabIndex = 92;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(676, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 18);
            this.label6.TabIndex = 91;
            this.label6.Text = "Supervisor:";
            // 
            // btn_searchProductionline
            // 
            this.btn_searchProductionline.Image = global::PEASA_App.Properties.Resources.Busqueda;
            this.btn_searchProductionline.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_searchProductionline.Location = new System.Drawing.Point(413, 163);
            this.btn_searchProductionline.Name = "btn_searchProductionline";
            this.btn_searchProductionline.Size = new System.Drawing.Size(124, 40);
            this.btn_searchProductionline.TabIndex = 90;
            this.btn_searchProductionline.Text = "Buscar";
            this.btn_searchProductionline.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(54, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 18);
            this.label5.TabIndex = 89;
            this.label5.Text = "Linea de producción:";
            // 
            // btn_searchWorkCenter
            // 
            this.btn_searchWorkCenter.Image = global::PEASA_App.Properties.Resources.Busqueda;
            this.btn_searchWorkCenter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_searchWorkCenter.Location = new System.Drawing.Point(1017, 104);
            this.btn_searchWorkCenter.Name = "btn_searchWorkCenter";
            this.btn_searchWorkCenter.Size = new System.Drawing.Size(124, 40);
            this.btn_searchWorkCenter.TabIndex = 88;
            this.btn_searchWorkCenter.Text = "Buscar";
            this.btn_searchWorkCenter.UseVisualStyleBackColor = true;
            // 
            // btn_searchNomina
            // 
            this.btn_searchNomina.Image = global::PEASA_App.Properties.Resources.Busqueda;
            this.btn_searchNomina.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_searchNomina.Location = new System.Drawing.Point(413, 103);
            this.btn_searchNomina.Name = "btn_searchNomina";
            this.btn_searchNomina.Size = new System.Drawing.Size(124, 40);
            this.btn_searchNomina.TabIndex = 85;
            this.btn_searchNomina.Text = "Buscar";
            this.btn_searchNomina.UseVisualStyleBackColor = true;
            // 
            // txt_nomina
            // 
            this.txt_nomina.Location = new System.Drawing.Point(56, 112);
            this.txt_nomina.Name = "txt_nomina";
            this.txt_nomina.Size = new System.Drawing.Size(351, 22);
            this.txt_nomina.TabIndex = 83;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 18);
            this.label2.TabIndex = 82;
            this.label2.Text = "Nómina:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 18);
            this.label1.TabIndex = 81;
            this.label1.Text = "Nombre:";
            // 
            // btn_searchName
            // 
            this.btn_searchName.Image = global::PEASA_App.Properties.Resources.Busqueda;
            this.btn_searchName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_searchName.Location = new System.Drawing.Point(413, 49);
            this.btn_searchName.Name = "btn_searchName";
            this.btn_searchName.Size = new System.Drawing.Size(124, 40);
            this.btn_searchName.TabIndex = 80;
            this.btn_searchName.Text = "Buscar";
            this.btn_searchName.UseVisualStyleBackColor = true;
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(56, 62);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(351, 22);
            this.txt_Name.TabIndex = 79;
            // 
            // dtg_extraTime
            // 
            this.dtg_extraTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtg_extraTime.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(218)))), ((int)(((byte)(250)))));
            this.dtg_extraTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtg_extraTime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_extraTime.Location = new System.Drawing.Point(27, 221);
            this.dtg_extraTime.Name = "dtg_extraTime";
            this.dtg_extraTime.RowHeadersWidth = 51;
            this.dtg_extraTime.RowTemplate.Height = 24;
            this.dtg_extraTime.Size = new System.Drawing.Size(1993, 641);
            this.dtg_extraTime.TabIndex = 97;
            // 
            // agregarTiempoExtraToolStripMenuItem
            // 
            this.agregarTiempoExtraToolStripMenuItem.Name = "agregarTiempoExtraToolStripMenuItem";
            this.agregarTiempoExtraToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.agregarTiempoExtraToolStripMenuItem.Text = "Agregar tiempo Extra";
            this.agregarTiempoExtraToolStripMenuItem.Click += new System.EventHandler(this.agregarTiempoExtraToolStripMenuItem_Click);
            // 
            // TiempoExtra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(218)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1772, 831);
            this.Controls.Add(this.dtg_extraTime);
            this.Controls.Add(this.txt_ProductionLine);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_CenterJob);
            this.Controls.Add(this.btn_searchSuper);
            this.Controls.Add(this.txt_supervisor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_searchProductionline);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_searchWorkCenter);
            this.Controls.Add(this.btn_searchNomina);
            this.Controls.Add(this.txt_nomina);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_searchName);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TiempoExtra";
            this.Text = "TiempoExtra";
            this.Load += new System.EventHandler(this.TiempoExtra_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_extraTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.TextBox txt_ProductionLine;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_CenterJob;
        private System.Windows.Forms.Button btn_searchSuper;
        private System.Windows.Forms.TextBox txt_supervisor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_searchProductionline;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_searchWorkCenter;
        private System.Windows.Forms.Button btn_searchNomina;
        private System.Windows.Forms.TextBox txt_nomina;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_searchName;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.DataGridView dtg_extraTime;
        private System.Windows.Forms.ToolStripMenuItem agregarTiempoExtraToolStripMenuItem;
    }
}