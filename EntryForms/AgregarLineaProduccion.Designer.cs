namespace PEASA_App
{
    partial class AgregarLineaProduccion
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
            this.components = new System.ComponentModel.Container();
            this.txt_lineProductionAdd = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_addNewLine = new System.Windows.Forms.Button();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnCloseWindow = new System.Windows.Forms.Button();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_lineProductionAdd
            // 
            this.txt_lineProductionAdd.Location = new System.Drawing.Point(254, 208);
            this.txt_lineProductionAdd.Name = "txt_lineProductionAdd";
            this.txt_lineProductionAdd.Size = new System.Drawing.Size(271, 22);
            this.txt_lineProductionAdd.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nueva Linea de Producción";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Linea de producción: ";
            // 
            // btn_addNewLine
            // 
            this.btn_addNewLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addNewLine.Location = new System.Drawing.Point(195, 286);
            this.btn_addNewLine.Name = "btn_addNewLine";
            this.btn_addNewLine.Size = new System.Drawing.Size(122, 46);
            this.btn_addNewLine.TabIndex = 4;
            this.btn_addNewLine.Text = "Agregar ";
            this.btn_addNewLine.UseVisualStyleBackColor = true;
            this.btn_addNewLine.Click += new System.EventHandler(this.btn_addNewLine_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelTitleBar.Controls.Add(this.btnCloseWindow);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(570, 26);
            this.panelTitleBar.TabIndex = 5;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btnCloseWindow
            // 
            this.btnCloseWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseWindow.BackgroundImage = global::PEASA_App.Properties.Resources.Close_png;
            this.btnCloseWindow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCloseWindow.FlatAppearance.BorderSize = 0;
            this.btnCloseWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseWindow.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnCloseWindow.Location = new System.Drawing.Point(507, 2);
            this.btnCloseWindow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCloseWindow.Name = "btnCloseWindow";
            this.btnCloseWindow.Size = new System.Drawing.Size(63, 23);
            this.btnCloseWindow.TabIndex = 6;
            this.btnCloseWindow.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnCloseWindow.UseVisualStyleBackColor = true;
            this.btnCloseWindow.Click += new System.EventHandler(this.btnCloseWindow_Click);
            // 
            // AgregarLineaProduccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 526);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.btn_addNewLine);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_lineProductionAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgregarLineaProduccion";
            this.Text = "AgregarLineaProduccion";
            this.panelTitleBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_lineProductionAdd;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_addNewLine;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Button btnCloseWindow;
    }
}