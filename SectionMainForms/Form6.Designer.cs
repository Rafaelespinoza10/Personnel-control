namespace PEASA_App 
{
    partial class Form6
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRegistrarse = new System.Windows.Forms.Button();
            this.btn_viewPassword = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pb_user = new System.Windows.Forms.PictureBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.TxtUser = new System.Windows.Forms.TextBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btn_viewConfirmPass = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_user)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(182)))), ((int)(((byte)(244)))));
            this.panelMain.Controls.Add(this.pictureBox1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(378, 568);
            this.panelMain.TabIndex = 0;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btn_exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(378, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(485, 37);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackgroundImage = global::PEASA_App.Properties.Resources.minimizar;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(377, -5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 32);
            this.button1.TabIndex = 3;
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
            this.btn_exit.Location = new System.Drawing.Point(422, 0);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(63, 23);
            this.btn_exit.TabIndex = 2;
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(517, 527);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 23);
            this.label2.TabIndex = 17;
            this.label2.Text = "¿Ya tienes cuenta?";
            // 
            // btnRegistrarse
            // 
            this.btnRegistrarse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(182)))), ((int)(((byte)(244)))));
            this.btnRegistrarse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegistrarse.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarse.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRegistrarse.Location = new System.Drawing.Point(438, 462);
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.Size = new System.Drawing.Size(412, 41);
            this.btnRegistrarse.TabIndex = 16;
            this.btnRegistrarse.Text = "Registrarse";
            this.btnRegistrarse.UseVisualStyleBackColor = false;
            this.btnRegistrarse.Click += new System.EventHandler(this.btnRegistrarse_Click);
//            this.btnRegistrarse.Enter += new System.EventHandler(this.btnRegistrarse_Enter);
            // 
            // btn_viewPassword
            // 
            this.btn_viewPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_viewPassword.BackColor = System.Drawing.Color.Transparent;
            this.btn_viewPassword.BackgroundImage = global::PEASA_App.Properties.Resources.ViewPassword_removebg_preview;
            this.btn_viewPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_viewPassword.FlatAppearance.BorderSize = 0;
            this.btn_viewPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_viewPassword.Location = new System.Drawing.Point(793, 290);
            this.btn_viewPassword.Name = "btn_viewPassword";
            this.btn_viewPassword.Size = new System.Drawing.Size(57, 37);
            this.btn_viewPassword.TabIndex = 10;
            this.btn_viewPassword.UseVisualStyleBackColor = false;
            this.btn_viewPassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_viewPassword_MouseDown);
            this.btn_viewPassword.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_viewPassword_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(597, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 38);
            this.label1.TabIndex = 15;
            this.label1.Text = "Registro";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::PEASA_App.Properties.Resources.password_removebg_preview;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(396, 279);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(59, 56);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pb_user
            // 
            this.pb_user.BackgroundImage = global::PEASA_App.Properties.Resources.User_image;
            this.pb_user.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_user.Location = new System.Drawing.Point(396, 120);
            this.pb_user.Name = "pb_user";
            this.pb_user.Size = new System.Drawing.Size(58, 53);
            this.pb_user.TabIndex = 13;
            this.pb_user.TabStop = false;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtPassword.Location = new System.Drawing.Point(464, 289);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(316, 33);
            this.txtPassword.TabIndex = 12;
            this.txtPassword.Text = "Contraseña";
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // TxtUser
            // 
            this.TxtUser.BackColor = System.Drawing.Color.White;
            this.TxtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtUser.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUser.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.TxtUser.Location = new System.Drawing.Point(470, 131);
            this.TxtUser.Name = "TxtUser";
            this.TxtUser.Size = new System.Drawing.Size(380, 33);
            this.TxtUser.TabIndex = 11;
            this.TxtUser.Text = "Usuario";
            this.TxtUser.Enter += new System.EventHandler(this.TxtUser_Enter);
            this.TxtUser.Leave += new System.EventHandler(this.TxtUser_Leave);
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BackColor = System.Drawing.Color.White;
            this.txtConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirmPassword.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtConfirmPassword.Location = new System.Drawing.Point(464, 370);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(316, 33);
            this.txtConfirmPassword.TabIndex = 19;
            this.txtConfirmPassword.Text = "Confirmar contraseña";
            this.txtConfirmPassword.TextChanged += new System.EventHandler(this.txtConfirmPassword_TextChanged);
            this.txtConfirmPassword.Enter += new System.EventHandler(this.txtConfirmPassword_Enter);
            this.txtConfirmPassword.Leave += new System.EventHandler(this.txtConfirmPassword_Leave);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::PEASA_App.Properties.Resources.password_removebg_preview;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(396, 357);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(59, 56);
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            // 
            // btn_viewConfirmPass
            // 
            this.btn_viewConfirmPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_viewConfirmPass.BackColor = System.Drawing.Color.Transparent;
            this.btn_viewConfirmPass.BackgroundImage = global::PEASA_App.Properties.Resources.ViewPassword_removebg_preview;
            this.btn_viewConfirmPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_viewConfirmPass.FlatAppearance.BorderSize = 0;
            this.btn_viewConfirmPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_viewConfirmPass.Location = new System.Drawing.Point(794, 373);
            this.btn_viewConfirmPass.Name = "btn_viewConfirmPass";
            this.btn_viewConfirmPass.Size = new System.Drawing.Size(57, 37);
            this.btn_viewConfirmPass.TabIndex = 21;
            this.btn_viewConfirmPass.UseVisualStyleBackColor = false;
            this.btn_viewConfirmPass.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_viewConfirmPass_MouseDown);
            this.btn_viewConfirmPass.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_viewConfirmPass_MouseUp);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtEmail.Location = new System.Drawing.Point(470, 207);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(380, 33);
            this.txtEmail.TabIndex = 22;
            this.txtEmail.Text = "Correo electrónico";
            this.txtEmail.Enter += new System.EventHandler(this.txtEmail_Enter);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::PEASA_App.Properties.Resources.Email_removebg_preview;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(396, 198);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(58, 59);
            this.pictureBox4.TabIndex = 23;
            this.pictureBox4.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.linkLabel1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(674, 522);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(123, 28);
            this.linkLabel1.TabIndex = 24;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Inicia sesión";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(218)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(863, 568);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btn_viewConfirmPass);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.btnRegistrarse);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btn_viewPassword);
            this.Controls.Add(this.TxtUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.pb_user);
            this.Name = "Form6";
            this.Text = "Form6";
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_user)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRegistrarse;
        private System.Windows.Forms.Button btn_viewPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pb_user;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox TxtUser;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btn_viewConfirmPass;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}