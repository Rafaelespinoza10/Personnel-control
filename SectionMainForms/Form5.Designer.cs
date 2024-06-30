namespace PEASA_App
{
    partial class Form5
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.TxtUser = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.pb_user = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_viewPassword = new System.Windows.Forms.Button();
            this.btnAccess = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.LnInscribirse = new System.Windows.Forms.LinkLabel();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_user)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(182)))), ((int)(((byte)(244)))));
            this.panelMenu.Controls.Add(this.flowLayoutPanel1);
            this.panelMenu.Controls.Add(this.pictureBox1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(378, 568);
            this.panelMenu.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(232, 308);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(8, 8);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PEASA_App.Properties.Resources.Logo_PeasaAuto;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-35, 155);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(426, 235);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.White;
            this.panelTitleBar.Controls.Add(this.button1);
            this.panelTitleBar.Controls.Add(this.btn_exit);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(378, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(485, 37);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown_1);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackgroundImage = global::PEASA_App.Properties.Resources.minimizar;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(380, -5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 32);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_exit.BackgroundImage = global::PEASA_App.Properties.Resources.Close_png;
            this.btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Location = new System.Drawing.Point(425, 0);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(63, 23);
            this.btn_exit.TabIndex = 0;
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // TxtUser
            // 
            this.TxtUser.BackColor = System.Drawing.Color.White;
            this.TxtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtUser.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUser.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.TxtUser.Location = new System.Drawing.Point(471, 188);
            this.TxtUser.Name = "TxtUser";
            this.TxtUser.Size = new System.Drawing.Size(380, 33);
            this.TxtUser.TabIndex = 2;
            this.TxtUser.Text = "Usuario";
            this.TxtUser.Enter += new System.EventHandler(this.TxtUser_Enter);
            this.TxtUser.Leave += new System.EventHandler(this.TxtUser_Leave);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtPassword.Location = new System.Drawing.Point(471, 277);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(316, 33);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.Text = "Contraseña";
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // pb_user
            // 
            this.pb_user.BackgroundImage = global::PEASA_App.Properties.Resources.User_image;
            this.pb_user.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_user.Location = new System.Drawing.Point(398, 172);
            this.pb_user.Name = "pb_user";
            this.pb_user.Size = new System.Drawing.Size(58, 53);
            this.pb_user.TabIndex = 4;
            this.pb_user.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::PEASA_App.Properties.Resources.password_removebg_preview;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(398, 266);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(59, 56);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(552, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 38);
            this.label1.TabIndex = 6;
            this.label1.Text = "Iniciar Sesión";
            // 
            // btn_viewPassword
            // 
            this.btn_viewPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_viewPassword.BackColor = System.Drawing.Color.Transparent;
            this.btn_viewPassword.BackgroundImage = global::PEASA_App.Properties.Resources.ViewPassword_removebg_preview;
            this.btn_viewPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_viewPassword.FlatAppearance.BorderSize = 0;
            this.btn_viewPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_viewPassword.Location = new System.Drawing.Point(794, 274);
            this.btn_viewPassword.Name = "btn_viewPassword";
            this.btn_viewPassword.Size = new System.Drawing.Size(57, 37);
            this.btn_viewPassword.TabIndex = 2;
            this.btn_viewPassword.UseVisualStyleBackColor = false;
            this.btn_viewPassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_viewPassword_MouseDown);
            this.btn_viewPassword.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_viewPassword_MouseUp);
            // 
            // btnAccess
            // 
            this.btnAccess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(182)))), ((int)(((byte)(244)))));
            this.btnAccess.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAccess.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccess.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAccess.Location = new System.Drawing.Point(439, 376);
            this.btnAccess.Name = "btnAccess";
            this.btnAccess.Size = new System.Drawing.Size(412, 41);
            this.btnAccess.TabIndex = 7;
            this.btnAccess.Text = "Acceder";
            this.btnAccess.UseVisualStyleBackColor = false;
            this.btnAccess.Click += new System.EventHandler(this.btnAccess_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(505, 459);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "¿No tienes cuenta?";
            // 
            // LnInscribirse
            // 
            this.LnInscribirse.AutoSize = true;
            this.LnInscribirse.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LnInscribirse.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LnInscribirse.Location = new System.Drawing.Point(667, 454);
            this.LnInscribirse.Name = "LnInscribirse";
            this.LnInscribirse.Size = new System.Drawing.Size(159, 28);
            this.LnInscribirse.TabIndex = 9;
            this.LnInscribirse.TabStop = true;
            this.LnInscribirse.Text = "Crea una cuenta";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(218)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(863, 568);
            this.Controls.Add(this.LnInscribirse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAccess);
            this.Controls.Add(this.btn_viewPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pb_user);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.TxtUser);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "Form5";
            this.Text = "Form5";
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_user)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox TxtUser;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.PictureBox pb_user;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_viewPassword;
        private System.Windows.Forms.Button btnAccess;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel LnInscribirse;
    }
}