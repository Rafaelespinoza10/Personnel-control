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
    public partial class Form5 : Form
    {
        private int borderSize = 2;
        private ErrorProvider errorProvider;
        private LoginManager loginManager;

        public Form5()
        {

            InitializeComponent();
            this.Padding = new Padding(borderSize);
            this.BackColor = Color.FromArgb(196, 218, 250);

            errorProvider = new ErrorProvider();
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;

            configurarRedondeoTextBox(TxtUser);
            configurarRedondeoTextBox(txtPassword);
            LnInscribirse.LinkClicked += LnInscribirse_LinkClicked;

            string server = "localhost";
            string database = "registros";
            string username = "root";
            string password = Environment.GetEnvironmentVariable("DB_PASSWORD");
            loginManager = new LoginManager(server, database, username, password);

        }

        private void LnInscribirse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            

            Form6 formRegistro = new Form6();
            formRegistro.Show();

   
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        
        private void panelTitleBar_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

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


        private void btn_exit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void TxtUser_Enter(object sender, EventArgs e)
        {
            if(TxtUser.Text == "Usuario")
            {
                TxtUser.Text = "";
                TxtUser.ForeColor = Color.Black;
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

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtPassword.Text))
            {
                txtPassword.Text = "Contraseña";
                txtPassword.ForeColor = SystemColors.GrayText;
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if(txtPassword.Text != "Contraseña")
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void btn_viewPassword_MouseDown(object sender, MouseEventArgs e)
        {
            if(txtPassword.Text != "Contraseña")
            txtPassword.UseSystemPasswordChar = false;

        }

        private void btn_viewPassword_MouseUp(object sender, MouseEventArgs e)
        {
            if (txtPassword.Text != "Contraseña")
                txtPassword.UseSystemPasswordChar = true;
        }

        private void TxtUser_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtUser.Text))
            {
                TxtUser.Text = "Usuario";
                TxtUser.ForeColor = SystemColors.GrayText;
            }
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

            return true;
        }

        private void DataBaseConnection()
        {

            try
            {
            string userNametxbox = TxtUser.Text;
            string passwordtb = txtPassword.Text;

                    if(loginManager.AuthenticateUser(userNametxbox, passwordtb))
                    {

                        this.Hide();
                        Form4 start = new Form4();
                        start.Show();
                    }
                    else
                    {
                        MessageBox.Show("Usuario y/o contraseña incorrecta.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }


            }catch(Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }



        }


        private void btnAccess_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                DataBaseConnection();
                
            }
        }
    }
}
