namespace PEASA_App
{
    partial class LineaProduccion
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
            this.dataProductionLine = new System.Windows.Forms.DataGridView();
            this.txt_nameLineProduction = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_DeleteProductionLine = new System.Windows.Forms.Button();
            this.btn_AddProductionline = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataProductionLine)).BeginInit();
            this.SuspendLayout();
            // 
            // dataProductionLine
            // 
            this.dataProductionLine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataProductionLine.Location = new System.Drawing.Point(54, 128);
            this.dataProductionLine.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataProductionLine.Name = "dataProductionLine";
            this.dataProductionLine.RowHeadersWidth = 51;
            this.dataProductionLine.Size = new System.Drawing.Size(1434, 397);
            this.dataProductionLine.TabIndex = 1;
            // 
            // txt_nameLineProduction
            // 
            this.txt_nameLineProduction.Location = new System.Drawing.Point(303, 64);
            this.txt_nameLineProduction.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_nameLineProduction.Name = "txt_nameLineProduction";
            this.txt_nameLineProduction.Size = new System.Drawing.Size(232, 22);
            this.txt_nameLineProduction.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Linea de producción:";
            // 
            // btn_Search
            // 
            this.btn_Search.Image = global::PEASA_App.Properties.Resources.Busqueda;
            this.btn_Search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Search.Location = new System.Drawing.Point(681, 55);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(143, 39);
            this.btn_Search.TabIndex = 6;
            this.btn_Search.Text = "Buscar";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_DeleteProductionLine
            // 
            this.btn_DeleteProductionLine.Image = global::PEASA_App.Properties.Resources.borrar;
            this.btn_DeleteProductionLine.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DeleteProductionLine.Location = new System.Drawing.Point(543, 55);
            this.btn_DeleteProductionLine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_DeleteProductionLine.Name = "btn_DeleteProductionLine";
            this.btn_DeleteProductionLine.Size = new System.Drawing.Size(133, 39);
            this.btn_DeleteProductionLine.TabIndex = 7;
            this.btn_DeleteProductionLine.Text = "Borrar";
            this.btn_DeleteProductionLine.UseVisualStyleBackColor = true;
            this.btn_DeleteProductionLine.Click += new System.EventHandler(this.btn_DeleteProductionLine_Click);
            // 
            // btn_AddProductionline
            // 
            this.btn_AddProductionline.Image = global::PEASA_App.Properties.Resources.agregar;
            this.btn_AddProductionline.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AddProductionline.Location = new System.Drawing.Point(1326, 57);
            this.btn_AddProductionline.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_AddProductionline.Name = "btn_AddProductionline";
            this.btn_AddProductionline.Size = new System.Drawing.Size(143, 39);
            this.btn_AddProductionline.TabIndex = 8;
            this.btn_AddProductionline.Text = "Agregar";
            this.btn_AddProductionline.UseVisualStyleBackColor = true;
            this.btn_AddProductionline.Click += new System.EventHandler(this.btn_AddProductionline_Click);
            // 
            // LineaProduccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(218)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1623, 612);
            this.Controls.Add(this.btn_AddProductionline);
            this.Controls.Add(this.btn_DeleteProductionLine);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.dataProductionLine);
            this.Controls.Add(this.txt_nameLineProduction);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LineaProduccion";
            this.Text = "LineaProduccion";
            this.Load += new System.EventHandler(this.LineaProduccion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataProductionLine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataProductionLine;
        private System.Windows.Forms.TextBox txt_nameLineProduction;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_DeleteProductionLine;
        private System.Windows.Forms.Button btn_AddProductionline;
    }
}