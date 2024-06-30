namespace PEASA_App
{
    partial class UserInfo
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_centroTrabajo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_description = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_requiredPersonal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_activePersonal = new System.Windows.Forms.TextBox();
            this.LoginWorkCenter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dataGridView1.Location = new System.Drawing.Point(366, 165);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1245, 592);
            this.dataGridView1.TabIndex = 1;
            // 
            // txt_centroTrabajo
            // 
            this.txt_centroTrabajo.Location = new System.Drawing.Point(146, 259);
            this.txt_centroTrabajo.Name = "txt_centroTrabajo";
            this.txt_centroTrabajo.Size = new System.Drawing.Size(175, 22);
            this.txt_centroTrabajo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Centro de Trabajo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Descripción:";
            // 
            // Txt_description
            // 
            this.Txt_description.Location = new System.Drawing.Point(146, 316);
            this.Txt_description.Name = "Txt_description";
            this.Txt_description.Size = new System.Drawing.Size(175, 22);
            this.Txt_description.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Personal requerido:";
            // 
            // txt_requiredPersonal
            // 
            this.txt_requiredPersonal.Location = new System.Drawing.Point(146, 373);
            this.txt_requiredPersonal.Name = "txt_requiredPersonal";
            this.txt_requiredPersonal.Size = new System.Drawing.Size(175, 22);
            this.txt_requiredPersonal.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 430);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Personal Activo:";
            // 
            // txt_activePersonal
            // 
            this.txt_activePersonal.Location = new System.Drawing.Point(146, 427);
            this.txt_activePersonal.Name = "txt_activePersonal";
            this.txt_activePersonal.Size = new System.Drawing.Size(175, 22);
            this.txt_activePersonal.TabIndex = 9;
            // 
            // LoginWorkCenter
            // 
            this.LoginWorkCenter.Location = new System.Drawing.Point(106, 500);
            this.LoginWorkCenter.Name = "LoginWorkCenter";
            this.LoginWorkCenter.Size = new System.Drawing.Size(215, 53);
            this.LoginWorkCenter.TabIndex = 10;
            this.LoginWorkCenter.Text = "Registrar centro de trabajo";
            this.LoginWorkCenter.UseVisualStyleBackColor = true;
            // 
            // UserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(218)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1653, 779);
            this.Controls.Add(this.LoginWorkCenter);
            this.Controls.Add(this.txt_activePersonal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_requiredPersonal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txt_description);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_centroTrabajo);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UserInfo";
            this.Text = "UserInfo";
            this.Load += new System.EventHandler(this.UserInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_centroTrabajo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_description;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_requiredPersonal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_activePersonal;
        private System.Windows.Forms.Button LoginWorkCenter;
    }
}