namespace PEASA_App
{
    partial class AgregarAreaTrabajo
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
            this.label6 = new System.Windows.Forms.Label();
            this.btn_AddNewArea = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_centerNumber = new System.Windows.Forms.TextBox();
            this.btnCloseWindow = new System.Windows.Forms.Button();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.panelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(171, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(243, 31);
            this.label6.TabIndex = 15;
            this.label6.Text = "Nueva Área de trabajo";
            // 
            // btn_AddNewArea
            // 
            this.btn_AddNewArea.Location = new System.Drawing.Point(243, 263);
            this.btn_AddNewArea.Name = "btn_AddNewArea";
            this.btn_AddNewArea.Size = new System.Drawing.Size(119, 48);
            this.btn_AddNewArea.TabIndex = 14;
            this.btn_AddNewArea.Text = "Agregar";
            this.btn_AddNewArea.UseVisualStyleBackColor = true;
            this.btn_AddNewArea.Click += new System.EventHandler(this.btn_AddNewArea_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Área de trabajo";
            // 
            // Txt_centerNumber
            // 
            this.Txt_centerNumber.Location = new System.Drawing.Point(226, 169);
            this.Txt_centerNumber.Name = "Txt_centerNumber";
            this.Txt_centerNumber.Size = new System.Drawing.Size(283, 22);
            this.Txt_centerNumber.TabIndex = 12;
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
            this.btnCloseWindow.Click += new System.EventHandler(this.btnCloseWindow_Click_1);
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelTitle.Controls.Add(this.btnCloseWindow);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(557, 26);
            this.panelTitle.TabIndex = 16;
            this.panelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseDown_1);
            // 
            // AgregarAreaTrabajo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 500);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_AddNewArea);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_centerNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgregarAreaTrabajo";
            this.Text = "AgregarAreaTrabajo";
            this.panelTitle.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_AddNewArea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_centerNumber;
        private System.Windows.Forms.Button btnCloseWindow;
        private System.Windows.Forms.Panel panelTitle;
    }
}