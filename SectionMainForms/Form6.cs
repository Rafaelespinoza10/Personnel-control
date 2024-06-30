using MySql.Data.MySqlClient;
using PEASA_App.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PEASA_App
{
    public partial class Form6 : Form
    {
        private int borderSize = 2;
        private ErrorProvider errorProvider;
        private LoginManager loginManager;
        public Form6()
        {
            InitializeComponent();
            this.Padding = new Padding(borderSize);
            this.BackColor = Color.FromArgb(196, 218, 250);
            configurarRedondeoTextBox(TxtUser);
            configurarRedondeoTextBox(txtEmail);
            configurarRedondeoTextBox(txtPassword);
            configurarRedondeoTextBox(txtConfirmPassword);

            errorProvider = new ErrorProvider();
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;

            txtPassword.TextChanged += txtConfirmPassword_TextChanged;
            linkLabel1.LinkClicked += LinkLabel1_LinkClicked;

            // Configurar LoginManager con la información de la base de datos
            string server = "localhost";
            string database = "registros";
            string username = "root";
            string password = Environment.GetEnvironmentVariable("DB_PASSWORD");
            loginManager = new LoginManager(server, database, username, password);
        
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();

            Form5 formRegistro = new Form5();
            formRegistro.Show();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void btn_exit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Elimina la barra de titulo 
        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }
            base.WndProc(ref m);
        }
        //Redondeo de textBox
        private void configurarRedondeoTextBox(TextBox textBox)
        {
            GraphicsPath path = new GraphicsPath();
            int radius = 10; // Puedes ajustar el radio según tus preferencias

            path.AddArc(0, 0, radius * 2, radius * 2, 180, 90);
            path.AddArc(textBox.Width - (radius * 2), 0, radius * 2, radius * 2, 270, 90);
            path.AddArc(textBox.Width - (radius * 2), textBox.Height - (radius * 2), radius * 2, radius * 2, 0, 90);
            path.AddArc(0, textBox.Height - (radius * 2), radius * 2, radius * 2, 90, 90);

            // Cerrar el recorrido
            path.CloseFigure();

            // Aplicar la región al TextBox
            textBox.Region = new Region(path);




        }

        private void TxtUser_Enter(object sender, EventArgs e)
        {
            if (TxtUser.Text == "Usuario")
            {
                TxtUser.Text = "";
                TxtUser.ForeColor = Color.Black;
            }
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Correo electrónico")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.Black;
                txtEmail.UseSystemPasswordChar = false;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Contraseña")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void txtConfirmPassword_Enter(object sender, EventArgs e)
        {
            if (txtConfirmPassword.Text == "Confirmar contraseña")
            {
                txtConfirmPassword.Text = "";
                txtConfirmPassword.ForeColor = Color.Black;
                txtConfirmPassword.UseSystemPasswordChar = false;
            }

        }

        private void TxtUser_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtUser.Text))
            {
                TxtUser.Text = "Usuario";
                TxtUser.ForeColor = SystemColors.GrayText;
                errorProvider.SetError(TxtUser, "Llenar Campo");
            }else
                errorProvider.SetError(TxtUser, "" );
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                txtEmail.Text = "Correo electrónico";
                txtEmail.ForeColor = SystemColors.GrayText;
                errorProvider.SetError(txtEmail, "Llenar Campo");
            }
            else
            {
                errorProvider.SetError(txtEmail, "");

            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                txtPassword.Text = "Contraseña";
                txtPassword.ForeColor = SystemColors.GrayText;
                txtPassword.UseSystemPasswordChar = false;
                errorProvider.SetError(txtPassword, "Llenar Campo");
            }
            else
            {
                errorProvider.SetError(txtPassword, "");
            }
        }

        private void txtConfirmPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtConfirmPassword.Text))
            {
                txtConfirmPassword.Text = "Confirmar contraseña";
                txtConfirmPassword.ForeColor = SystemColors.GrayText;
                txtConfirmPassword.UseSystemPasswordChar = false;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text != "Contraseña")
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            if (password != "Contraseña" && confirmPassword != "Confirmar contraseña")
            {
                txtConfirmPassword.UseSystemPasswordChar = true;
                if (password == confirmPassword)
                {
                    // Contraseñas coinciden
                    txtConfirmPassword.ForeColor = Color.Green;

                    // Limpiar el mensaje de error
                    errorProvider.SetError(txtConfirmPassword, "");
                }
                else
                {
                    // Contraseñas no coinciden
                    txtConfirmPassword.ForeColor = Color.Red;

                    // Mostrar mensaje de error
                    errorProvider.SetError(txtConfirmPassword, "Las contraseñas no coinciden");
                }
            }
        }

        private void btn_viewPassword_MouseUp(object sender, MouseEventArgs e)
        {
            if (txtPassword.Text != "Contraseña")
                txtPassword.UseSystemPasswordChar = true;
        }

        private void btn_viewPassword_MouseDown(object sender, MouseEventArgs e)
        {
            if (txtPassword.Text != "Contraseña")
                txtPassword.UseSystemPasswordChar = false;
        }

        private void btn_viewConfirmPass_MouseUp(object sender, MouseEventArgs e)
        {
            if (txtConfirmPassword.Text != "Confirmar contraseña")
                txtConfirmPassword.UseSystemPasswordChar = true;
        }

        private void btn_viewConfirmPass_MouseDown(object sender, MouseEventArgs e)
        {
            if (txtConfirmPassword.Text != "Confirmar contraseña")
                txtConfirmPassword.UseSystemPasswordChar = false;
        }

        private bool ValidarCampos()
        {
            // Verificar si el campo de usuario está lleno
            if (string.IsNullOrEmpty(TxtUser.Text) || TxtUser.Text == "Usuario")
            {
                errorProvider.SetError(TxtUser, "Por favor, ingrese un nombre de usuario");
                return false;
            }
            else
            {
                errorProvider.SetError(TxtUser, "");
            }

            // Verificar si el campo de correo electrónico está lleno y es un formato válido (puedes agregar una validación más robusta)
            if (string.IsNullOrEmpty(txtEmail.Text) || txtEmail.Text == "Correo electrónico" || !IsValidEmail(txtEmail.Text))
            {
                errorProvider.SetError(txtEmail, "Por favor, ingrese un correo electrónico válido");
                return false;
            }
            else
            {
                errorProvider.SetError(txtEmail, "");
            }

            // Verificar si el campo de contraseña está lleno
            if (string.IsNullOrEmpty(txtPassword.Text) || txtPassword.Text == "Contraseña")
            {
                errorProvider.SetError(txtPassword, "Por favor, ingrese una contraseña");
                return false;
            }
            else
            {
                errorProvider.SetError(txtPassword, "");
            }

            // Verificar si el campo de confirmar contraseña está lleno y coincide con la contraseña ingresada
            if (string.IsNullOrEmpty(txtConfirmPassword.Text) || txtConfirmPassword.Text == "Confirmar contraseña" || txtConfirmPassword.Text != txtPassword.Text)
            {
                errorProvider.SetError(txtConfirmPassword, "Las contraseñas no coinciden");
                return false;
            }
            else
            {
                errorProvider.SetError(txtConfirmPassword, "");
            }

            // Todos los campos están llenos y son válidos
            return true;
        }

        private bool IsValidEmail(string email)
        {
            // Puedes implementar una lógica más avanzada para validar el formato del correo electrónico si lo deseas
            return System.Text.RegularExpressions.Regex.IsMatch(email, @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$");
        }

        private void DataBaseConnection()
        {
            try
            {
                string nameUserTxt = TxtUser.Text;
                string emailtxt = txtEmail.Text;
                string passwordtxt = txtPassword.Text;

                setUser(nameUserTxt, passwordtxt, emailtxt);

            }catch(Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void setUser(string nameUserTxt, string passwordtxt, string emailTxt)
        {
            try
            {
                if(loginManager.RegisterUser(nameUserTxt,passwordtxt, emailTxt))
                {
                   MessageBox.Show("Usuario registrado correctamente");
                }
                else
                {
                    MessageBox.Show("Error al registrar usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }


            }catch(Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    
        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                DataBaseConnection();
               
            }
            txtConfirmPassword.Text = "";
            txtEmail.Text = "";
            txtPassword.Text = "";
            TxtUser.Text = "";
        }

    }
}
