namespace PEASA_App
{
    partial class AsistenciaSoldaduraG3
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
            this.dgv_AttendanceList1 = new System.Windows.Forms.DataGridView();
            this.btn_ConfirmarAsistencia = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dt_dateAttendance = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AttendanceList1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_AttendanceList1
            // 
            this.dgv_AttendanceList1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(218)))), ((int)(((byte)(250)))));
            this.dgv_AttendanceList1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_AttendanceList1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_AttendanceList1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgv_AttendanceList1.GridColor = System.Drawing.SystemColors.Control;
            this.dgv_AttendanceList1.Location = new System.Drawing.Point(28, 75);
            this.dgv_AttendanceList1.Name = "dgv_AttendanceList1";
            this.dgv_AttendanceList1.RowHeadersWidth = 51;
            this.dgv_AttendanceList1.RowTemplate.Height = 24;
            this.dgv_AttendanceList1.Size = new System.Drawing.Size(1411, 527);
            this.dgv_AttendanceList1.TabIndex = 11;
            // 
            // btn_ConfirmarAsistencia
            // 
            this.btn_ConfirmarAsistencia.Location = new System.Drawing.Point(465, 12);
            this.btn_ConfirmarAsistencia.Name = "btn_ConfirmarAsistencia";
            this.btn_ConfirmarAsistencia.Size = new System.Drawing.Size(178, 39);
            this.btn_ConfirmarAsistencia.TabIndex = 10;
            this.btn_ConfirmarAsistencia.Text = "Confirmar Asistencia";
            this.btn_ConfirmarAsistencia.UseVisualStyleBackColor = true;
            this.btn_ConfirmarAsistencia.Click += new System.EventHandler(this.btn_ConfirmarAsistencia_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Fecha:";
            // 
            // dt_dateAttendance
            // 
            this.dt_dateAttendance.Location = new System.Drawing.Point(87, 22);
            this.dt_dateAttendance.Name = "dt_dateAttendance";
            this.dt_dateAttendance.Size = new System.Drawing.Size(354, 22);
            this.dt_dateAttendance.TabIndex = 8;
            // 
            // AsistenciaSoldaduraG3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(218)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1502, 646);
            this.Controls.Add(this.dgv_AttendanceList1);
            this.Controls.Add(this.btn_ConfirmarAsistencia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dt_dateAttendance);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AsistenciaSoldaduraG3";
            this.Text = "AsistenciaSoldaduraG3";
            this.Load += new System.EventHandler(this.AsistenciaSoldaduraG3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AttendanceList1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_AttendanceList1;
        private System.Windows.Forms.Button btn_ConfirmarAsistencia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dt_dateAttendance;
    }
}