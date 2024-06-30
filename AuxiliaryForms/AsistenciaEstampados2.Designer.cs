namespace PEASA_App
{
    partial class AsistenciaEstampados2
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
            this.dgv_AttendanceList2 = new System.Windows.Forms.DataGridView();
            this.btn_ConfirmarAsistencia = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dt_dateAttendance = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AttendanceList2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_AttendanceList2
            // 
            this.dgv_AttendanceList2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(218)))), ((int)(((byte)(250)))));
            this.dgv_AttendanceList2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_AttendanceList2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_AttendanceList2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgv_AttendanceList2.GridColor = System.Drawing.SystemColors.Control;
            this.dgv_AttendanceList2.Location = new System.Drawing.Point(60, 123);
            this.dgv_AttendanceList2.Name = "dgv_AttendanceList2";
            this.dgv_AttendanceList2.RowHeadersWidth = 51;
            this.dgv_AttendanceList2.RowTemplate.Height = 24;
            this.dgv_AttendanceList2.Size = new System.Drawing.Size(1396, 610);
            this.dgv_AttendanceList2.TabIndex = 7;
            // 
            // btn_ConfirmarAsistencia
            // 
            this.btn_ConfirmarAsistencia.Location = new System.Drawing.Point(537, 45);
            this.btn_ConfirmarAsistencia.Name = "btn_ConfirmarAsistencia";
            this.btn_ConfirmarAsistencia.Size = new System.Drawing.Size(178, 39);
            this.btn_ConfirmarAsistencia.TabIndex = 6;
            this.btn_ConfirmarAsistencia.Text = "Confirmar Asistencia";
            this.btn_ConfirmarAsistencia.UseVisualStyleBackColor = true;
            this.btn_ConfirmarAsistencia.Click += new System.EventHandler(this.btn_ConfirmarAsistencia_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Fecha:";
            // 
            // dt_dateAttendance
            // 
            this.dt_dateAttendance.Location = new System.Drawing.Point(159, 55);
            this.dt_dateAttendance.Name = "dt_dateAttendance";
            this.dt_dateAttendance.Size = new System.Drawing.Size(354, 22);
            this.dt_dateAttendance.TabIndex = 4;
            // 
            // AsistenciaEstampados2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(218)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1517, 779);
            this.Controls.Add(this.dgv_AttendanceList2);
            this.Controls.Add(this.btn_ConfirmarAsistencia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dt_dateAttendance);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AsistenciaEstampados2";
            this.Text = "AsistenciaEstampados2";
            this.Load += new System.EventHandler(this.AsistenciaEstampados2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AttendanceList2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_AttendanceList2;
        private System.Windows.Forms.Button btn_ConfirmarAsistencia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dt_dateAttendance;
    }
}