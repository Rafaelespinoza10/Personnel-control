namespace PEASA_App
{
    partial class AreaTrabajo
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
            this.btn_searchJobCenter = new System.Windows.Forms.Button();
            this.btn_addjobarea = new System.Windows.Forms.Button();
            this.Txt_NumeroCentro = new System.Windows.Forms.TextBox();
            this.dtgv_jobcenter = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_jobcenter)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_deleteJobCenter
            // 
            this.btn_deleteJobCenter.Image = global::PEASA_App.Properties.Resources.borrar;
            this.btn_deleteJobCenter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_deleteJobCenter.Location = new System.Drawing.Point(571, 45);
            this.btn_deleteJobCenter.Name = "btn_deleteJobCenter";
            this.btn_deleteJobCenter.Size = new System.Drawing.Size(124, 40);
            this.btn_deleteJobCenter.TabIndex = 19;
            this.btn_deleteJobCenter.Text = "Borrar";
            this.btn_deleteJobCenter.UseVisualStyleBackColor = true;
            this.btn_deleteJobCenter.Click += new System.EventHandler(this.btn_deleteJobCenter_Click);
            // 
            // btn_searchJobCenter
            // 
            this.btn_searchJobCenter.Image = global::PEASA_App.Properties.Resources.Busqueda;
            this.btn_searchJobCenter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_searchJobCenter.Location = new System.Drawing.Point(441, 45);
            this.btn_searchJobCenter.Name = "btn_searchJobCenter";
            this.btn_searchJobCenter.Size = new System.Drawing.Size(124, 40);
            this.btn_searchJobCenter.TabIndex = 18;
            this.btn_searchJobCenter.Text = "Buscar";
            this.btn_searchJobCenter.UseVisualStyleBackColor = true;
            this.btn_searchJobCenter.Click += new System.EventHandler(this.btn_searchJobCenter_Click_1);
            // 
            // btn_addjobarea
            // 
            this.btn_addjobarea.Image = global::PEASA_App.Properties.Resources.agregar;
            this.btn_addjobarea.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_addjobarea.Location = new System.Drawing.Point(1090, 45);
            this.btn_addjobarea.Name = "btn_addjobarea";
            this.btn_addjobarea.Size = new System.Drawing.Size(124, 40);
            this.btn_addjobarea.TabIndex = 17;
            this.btn_addjobarea.Text = "Agregar ";
            this.btn_addjobarea.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_addjobarea.UseVisualStyleBackColor = true;
            this.btn_addjobarea.Click += new System.EventHandler(this.btn_addjobarea_Click);
            // 
            // Txt_NumeroCentro
            // 
            this.Txt_NumeroCentro.Location = new System.Drawing.Point(137, 54);
            this.Txt_NumeroCentro.Name = "Txt_NumeroCentro";
            this.Txt_NumeroCentro.Size = new System.Drawing.Size(276, 22);
            this.Txt_NumeroCentro.TabIndex = 16;
            // 
            // dtgv_jobcenter
            // 
            this.dtgv_jobcenter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_jobcenter.Location = new System.Drawing.Point(61, 130);
            this.dtgv_jobcenter.Name = "dtgv_jobcenter";
            this.dtgv_jobcenter.RowHeadersWidth = 51;
            this.dtgv_jobcenter.RowTemplate.Height = 24;
            this.dtgv_jobcenter.Size = new System.Drawing.Size(1153, 455);
            this.dtgv_jobcenter.TabIndex = 14;
            // 
            // AreaTrabajo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(218)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1361, 685);
            this.Controls.Add(this.btn_deleteJobCenter);
            this.Controls.Add(this.btn_searchJobCenter);
            this.Controls.Add(this.btn_addjobarea);
            this.Controls.Add(this.Txt_NumeroCentro);
            this.Controls.Add(this.dtgv_jobcenter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AreaTrabajo";
            this.Text = "AreaTrabajo";
            this.Load += new System.EventHandler(this.AreaTrabajo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_jobcenter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_deleteJobCenter;
        private System.Windows.Forms.Button btn_searchJobCenter;
        private System.Windows.Forms.Button btn_addjobarea;
        private System.Windows.Forms.TextBox Txt_NumeroCentro;
        private System.Windows.Forms.DataGridView dtgv_jobcenter;
    }
}