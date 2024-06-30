namespace PEASA_App
{
    partial class AgregarRutasTransporte
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
            this.btnCloseWindow = new System.Windows.Forms.Button();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_addNewRute = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_descriptionRute = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_RuteNumber = new System.Windows.Forms.TextBox();
            this.panelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCloseWindow
            // 
            this.btnCloseWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseWindow.BackgroundImage = global::PEASA_App.Properties.Resources.Close_png;
            this.btnCloseWindow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCloseWindow.FlatAppearance.BorderSize = 0;
            this.btnCloseWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseWindow.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnCloseWindow.Location = new System.Drawing.Point(512, 2);
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
            this.panelTitle.Size = new System.Drawing.Size(575, 26);
            this.panelTitle.TabIndex = 13;
            this.panelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseDown_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(175, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(276, 31);
            this.label6.TabIndex = 19;
            this.label6.Text = "Nueva Ruta de transporte";
            // 
            // btn_addNewRute
            // 
            this.btn_addNewRute.Location = new System.Drawing.Point(239, 342);
            this.btn_addNewRute.Name = "btn_addNewRute";
            this.btn_addNewRute.Size = new System.Drawing.Size(119, 48);
            this.btn_addNewRute.TabIndex = 18;
            this.btn_addNewRute.Text = "Agregar";
            this.btn_addNewRute.UseVisualStyleBackColor = true;
            this.btn_addNewRute.Click += new System.EventHandler(this.btn_addNewRute_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Descripción:";
            // 
            // txt_descriptionRute
            // 
            this.txt_descriptionRute.Location = new System.Drawing.Point(195, 254);
            this.txt_descriptionRute.Name = "txt_descriptionRute";
            this.txt_descriptionRute.Size = new System.Drawing.Size(283, 22);
            this.txt_descriptionRute.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Numero de ruta:";
            // 
            // txt_RuteNumber
            // 
            this.txt_RuteNumber.Location = new System.Drawing.Point(195, 210);
            this.txt_RuteNumber.Name = "txt_RuteNumber";
            this.txt_RuteNumber.Size = new System.Drawing.Size(283, 22);
            this.txt_RuteNumber.TabIndex = 14;
            // 
            // AgregarRutasTransporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(575, 547);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_addNewRute);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_descriptionRute);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_RuteNumber);
            this.Controls.Add(this.panelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgregarRutasTransporte";
            this.Text = "AgregarRutasTransporte";
            this.panelTitle.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCloseWindow;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_addNewRute;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_descriptionRute;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_RuteNumber;
    }
}