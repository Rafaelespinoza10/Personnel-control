namespace PEASA_App
{
    partial class AgregaCapacitacion
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
            this.panelTitle = new System.Windows.Forms.Panel();
            this.btnCloseWindow = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_AddNewCapacitation = new System.Windows.Forms.Button();
            this.dt_fecha = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tx_calificacion = new System.Windows.Forms.TextBox();
            this.cb_capacitacion = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_nomina = new System.Windows.Forms.TextBox();
            this.panelTitle.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelTitle.Controls.Add(this.btnCloseWindow);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(860, 26);
            this.panelTitle.TabIndex = 26;
            this.panelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseDown);
            // 
            // btnCloseWindow
            // 
            this.btnCloseWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseWindow.BackgroundImage = global::PEASA_App.Properties.Resources.Close_png;
            this.btnCloseWindow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCloseWindow.FlatAppearance.BorderSize = 0;
            this.btnCloseWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseWindow.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnCloseWindow.Location = new System.Drawing.Point(797, 2);
            this.btnCloseWindow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCloseWindow.Name = "btnCloseWindow";
            this.btnCloseWindow.Size = new System.Drawing.Size(63, 23);
            this.btnCloseWindow.TabIndex = 6;
            this.btnCloseWindow.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnCloseWindow.UseVisualStyleBackColor = true;
            this.btnCloseWindow.Click += new System.EventHandler(this.btnCloseWindow_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.btn_AddNewCapacitation);
            this.groupBox2.Controls.Add(this.dt_fecha);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.tx_calificacion);
            this.groupBox2.Controls.Add(this.cb_capacitacion);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txt_nomina);
            this.groupBox2.Location = new System.Drawing.Point(96, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(674, 402);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Agregar";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(238, 35);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label10.Size = new System.Drawing.Size(244, 31);
            this.label10.TabIndex = 37;
            this.label10.Text = "Registrar Capacitación";
            // 
            // btn_AddNewCapacitation
            // 
            this.btn_AddNewCapacitation.Location = new System.Drawing.Point(297, 284);
            this.btn_AddNewCapacitation.Name = "btn_AddNewCapacitation";
            this.btn_AddNewCapacitation.Size = new System.Drawing.Size(153, 39);
            this.btn_AddNewCapacitation.TabIndex = 35;
            this.btn_AddNewCapacitation.Text = "Agregar";
            this.btn_AddNewCapacitation.UseVisualStyleBackColor = true;
            this.btn_AddNewCapacitation.Click += new System.EventHandler(this.btn_AddNewCapacitation_Click_1);
            // 
            // dt_fecha
            // 
            this.dt_fecha.Location = new System.Drawing.Point(253, 224);
            this.dt_fecha.Name = "dt_fecha";
            this.dt_fecha.Size = new System.Drawing.Size(283, 22);
            this.dt_fecha.TabIndex = 34;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(85, 221);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(151, 25);
            this.label11.TabIndex = 33;
            this.label11.Text = "Fecha de registro:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(131, 180);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 25);
            this.label12.TabIndex = 32;
            this.label12.Text = "Calificación:";
            // 
            // tx_calificacion
            // 
            this.tx_calificacion.Location = new System.Drawing.Point(253, 180);
            this.tx_calificacion.Name = "tx_calificacion";
            this.tx_calificacion.Size = new System.Drawing.Size(283, 22);
            this.tx_calificacion.TabIndex = 31;
            // 
            // cb_capacitacion
            // 
            this.cb_capacitacion.FormattingEnabled = true;
            this.cb_capacitacion.Items.AddRange(new object[] {
            "Generalidades de seguridad",
            "Puesta a punto",
            "Reporte de producción",
            "Condiciones de Operación",
            "Automantenimiento CheckList",
            "Uso de escantillones",
            "Instrumentos de medición",
            "Control de producto no conforme",
            "Hoja de autoinspección"});
            this.cb_capacitacion.Location = new System.Drawing.Point(253, 140);
            this.cb_capacitacion.Name = "cb_capacitacion";
            this.cb_capacitacion.Size = new System.Drawing.Size(283, 24);
            this.cb_capacitacion.TabIndex = 30;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(120, 140);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(116, 25);
            this.label13.TabIndex = 29;
            this.label13.Text = "Capacitación:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(157, 94);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 25);
            this.label14.TabIndex = 28;
            this.label14.Text = "Nómina:";
            // 
            // txt_nomina
            // 
            this.txt_nomina.Location = new System.Drawing.Point(253, 97);
            this.txt_nomina.Name = "txt_nomina";
            this.txt_nomina.Size = new System.Drawing.Size(283, 22);
            this.txt_nomina.TabIndex = 27;
            // 
            // AgregaCapacitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(860, 492);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgregaCapacitacion";
            this.Text = "AgregaCapacitacion";
            this.panelTitle.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Button btnCloseWindow;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_AddNewCapacitation;
        private System.Windows.Forms.DateTimePicker dt_fecha;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tx_calificacion;
        private System.Windows.Forms.ComboBox cb_capacitacion;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_nomina;
    }
}