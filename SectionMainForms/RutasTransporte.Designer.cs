namespace PEASA_App
{
    partial class RutasTransporte
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
            this.dtGridRutes = new System.Windows.Forms.DataGridView();
            this.txtTransportDescription = new System.Windows.Forms.TextBox();
            this.btn_AddRute = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_deleteJobCenter = new System.Windows.Forms.Button();
            this.btn_searchJobCenter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridRutes)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGridRutes
            // 
            this.dtGridRutes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridRutes.Location = new System.Drawing.Point(78, 160);
            this.dtGridRutes.Name = "dtGridRutes";
            this.dtGridRutes.RowHeadersWidth = 51;
            this.dtGridRutes.Size = new System.Drawing.Size(1113, 492);
            this.dtGridRutes.TabIndex = 0;
            // 
            // txtTransportDescription
            // 
            this.txtTransportDescription.Location = new System.Drawing.Point(158, 84);
            this.txtTransportDescription.Name = "txtTransportDescription";
            this.txtTransportDescription.Size = new System.Drawing.Size(298, 22);
            this.txtTransportDescription.TabIndex = 2;
            // 
            // btn_AddRute
            // 
            this.btn_AddRute.Image = global::PEASA_App.Properties.Resources.agregar;
            this.btn_AddRute.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AddRute.Location = new System.Drawing.Point(1056, 73);
            this.btn_AddRute.Name = "btn_AddRute";
            this.btn_AddRute.Size = new System.Drawing.Size(122, 38);
            this.btn_AddRute.TabIndex = 6;
            this.btn_AddRute.Text = "Agregar";
            this.btn_AddRute.UseVisualStyleBackColor = true;
            this.btn_AddRute.Click += new System.EventHandler(this.btn_AddRute_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Descripción de ruta";
            // 
            // btn_deleteJobCenter
            // 
            this.btn_deleteJobCenter.Image = global::PEASA_App.Properties.Resources.borrar;
            this.btn_deleteJobCenter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_deleteJobCenter.Location = new System.Drawing.Point(603, 72);
            this.btn_deleteJobCenter.Name = "btn_deleteJobCenter";
            this.btn_deleteJobCenter.Size = new System.Drawing.Size(124, 40);
            this.btn_deleteJobCenter.TabIndex = 15;
            this.btn_deleteJobCenter.Text = "Borrar";
            this.btn_deleteJobCenter.UseVisualStyleBackColor = true;
            this.btn_deleteJobCenter.Click += new System.EventHandler(this.btn_deleteJobCenter_Click);
            // 
            // btn_searchJobCenter
            // 
            this.btn_searchJobCenter.Image = global::PEASA_App.Properties.Resources.Busqueda;
            this.btn_searchJobCenter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_searchJobCenter.Location = new System.Drawing.Point(473, 72);
            this.btn_searchJobCenter.Name = "btn_searchJobCenter";
            this.btn_searchJobCenter.Size = new System.Drawing.Size(124, 40);
            this.btn_searchJobCenter.TabIndex = 14;
            this.btn_searchJobCenter.Text = "Buscar";
            this.btn_searchJobCenter.UseVisualStyleBackColor = true;
            this.btn_searchJobCenter.Click += new System.EventHandler(this.btn_searchJobCenter_Click);
            // 
            // RutasTransporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(218)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1247, 720);
            this.Controls.Add(this.btn_deleteJobCenter);
            this.Controls.Add(this.btn_searchJobCenter);
            this.Controls.Add(this.btn_AddRute);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTransportDescription);
            this.Controls.Add(this.dtGridRutes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RutasTransporte";
            this.Text = "RutasTransporte";
            this.Load += new System.EventHandler(this.RutasTransporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridRutes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGridRutes;
        private System.Windows.Forms.TextBox txtTransportDescription;
        private System.Windows.Forms.Button btn_AddRute;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_deleteJobCenter;
        private System.Windows.Forms.Button btn_searchJobCenter;
    }
}