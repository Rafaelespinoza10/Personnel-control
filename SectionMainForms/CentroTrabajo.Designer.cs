namespace PEASA_App
{
    partial class CentroTrabajo
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
            this.dtgv_jobcenter = new System.Windows.Forms.DataGridView();
            this.Txt_NumeroCentro = new System.Windows.Forms.TextBox();
            this.btn_AddJobCenter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_searchJobCenter = new System.Windows.Forms.Button();
            this.btn_deleteJobCenter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_jobcenter)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgv_jobcenter
            // 
            this.dtgv_jobcenter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_jobcenter.Location = new System.Drawing.Point(59, 129);
            this.dtgv_jobcenter.Name = "dtgv_jobcenter";
            this.dtgv_jobcenter.RowHeadersWidth = 51;
            this.dtgv_jobcenter.RowTemplate.Height = 24;
            this.dtgv_jobcenter.Size = new System.Drawing.Size(1153, 455);
            this.dtgv_jobcenter.TabIndex = 0;
            // 
            // Txt_NumeroCentro
            // 
            this.Txt_NumeroCentro.Location = new System.Drawing.Point(179, 54);
            this.Txt_NumeroCentro.Name = "Txt_NumeroCentro";
            this.Txt_NumeroCentro.Size = new System.Drawing.Size(255, 22);
            this.Txt_NumeroCentro.TabIndex = 6;
            // 
            // btn_AddJobCenter
            // 
            this.btn_AddJobCenter.Image = global::PEASA_App.Properties.Resources.agregar;
            this.btn_AddJobCenter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AddJobCenter.Location = new System.Drawing.Point(1072, 45);
            this.btn_AddJobCenter.Name = "btn_AddJobCenter";
            this.btn_AddJobCenter.Size = new System.Drawing.Size(124, 40);
            this.btn_AddJobCenter.TabIndex = 11;
            this.btn_AddJobCenter.Text = "Agregar ";
            this.btn_AddJobCenter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_AddJobCenter.UseVisualStyleBackColor = true;
            this.btn_AddJobCenter.Click += new System.EventHandler(this.btn_AddJobCenter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numero de centro:";
            // 
            // btn_searchJobCenter
            // 
            this.btn_searchJobCenter.Image = global::PEASA_App.Properties.Resources.Busqueda;
            this.btn_searchJobCenter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_searchJobCenter.Location = new System.Drawing.Point(462, 45);
            this.btn_searchJobCenter.Name = "btn_searchJobCenter";
            this.btn_searchJobCenter.Size = new System.Drawing.Size(124, 40);
            this.btn_searchJobCenter.TabIndex = 12;
            this.btn_searchJobCenter.Text = "Buscar";
            this.btn_searchJobCenter.UseVisualStyleBackColor = true;
            this.btn_searchJobCenter.Click += new System.EventHandler(this.btn_searchJobCenter_Click);
            // 
            // btn_deleteJobCenter
            // 
            this.btn_deleteJobCenter.Image = global::PEASA_App.Properties.Resources.borrar;
            this.btn_deleteJobCenter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_deleteJobCenter.Location = new System.Drawing.Point(592, 45);
            this.btn_deleteJobCenter.Name = "btn_deleteJobCenter";
            this.btn_deleteJobCenter.Size = new System.Drawing.Size(124, 40);
            this.btn_deleteJobCenter.TabIndex = 13;
            this.btn_deleteJobCenter.Text = "Borrar";
            this.btn_deleteJobCenter.UseVisualStyleBackColor = true;
            this.btn_deleteJobCenter.Click += new System.EventHandler(this.btn_deleteJobCenter_Click);
            // 
            // CentroTrabajo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(218)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1264, 656);
            this.Controls.Add(this.btn_deleteJobCenter);
            this.Controls.Add(this.btn_searchJobCenter);
            this.Controls.Add(this.btn_AddJobCenter);
            this.Controls.Add(this.Txt_NumeroCentro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgv_jobcenter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CentroTrabajo";
            this.Text = "CentroTrabajo";
            this.Load += new System.EventHandler(this.CentroTrabajo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_jobcenter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgv_jobcenter;
        private System.Windows.Forms.TextBox Txt_NumeroCentro;
        private System.Windows.Forms.Button btn_AddJobCenter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_searchJobCenter;
        private System.Windows.Forms.Button btn_deleteJobCenter;
    }
}