using Microsoft.Office.Interop.Excel;
using PEASA_App.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PEASA_App
{
    public partial class Form4 : Form
    {
        private int borderSize = 2;
        private string password = Environment.GetEnvironmentVariable("DB_PASSWORD");
        private const string userName = "root";
        private const string databaseName = "registros";
        private const string host = "localhost";

        public Form4()
        {
            InitializeComponent();
            this.Padding = new Padding(borderSize);
            this.BackColor = Color.FromArgb(132, 182, 244);

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
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

        private void Form4_Resize(object sender, EventArgs e)
        {
            AdjustForm();
        }

        private void AdjustForm()
        {
            switch (this.WindowState)
            {
                case FormWindowState.Maximized:
                    this.Padding = new Padding(0, 8, 8, 0);
                    break;
                case FormWindowState.Normal:
                    if (this.Padding.Top == borderSize)
                        this.Padding = new Padding(borderSize);
                    break;
            }
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_Maximizar_Click(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;

            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnCloseWindow_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();   
        }

        //agregamos un panel hijo
        private void childForm(object childform)
        {
            if(this.panelDesktop.Controls.Count > 0)
            {
                this.panelDesktop.Controls.RemoveAt(0);
            }
            Form cf = childform as Form;
            cf.TopLevel = false;
            cf.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(cf);
            this.panelDesktop.Tag = cf;
            cf.Show();

        }

        
        private void btn_ProductionLine_Click(object sender, EventArgs e)
        {
            try
            {
                MySQLConnectionManager connectionManager = new MySQLConnectionManager(host, databaseName, userName, password);

                // Intenta abrir la conexión
                connectionManager.OpenConnection();
                childForm(new Catalogos(connectionManager));
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al intentar establecer la conexión: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Form5 inicio = new Form5();
            inicio.Show();
            this.Hide();
        }

        private void btn_HumanResources_Click(object sender, EventArgs e)
        {
            try
            {
                MySQLConnectionManager connectionManager = new MySQLConnectionManager(host, databaseName, userName, password);

                connectionManager.OpenConnection();
                childForm(new Trabajadores(connectionManager));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al intentar establecer la conexión: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btn_estampados_Click(object sender, EventArgs e)
        {
            try
            {
                MySQLConnectionManager connectionManager = new MySQLConnectionManager(host, databaseName, userName, password);
                connectionManager.OpenConnection();
                childForm(new Estampados(connectionManager));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al intentar establecer la conexion: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Soldadura_Click(object sender, EventArgs e)
        {
            try
            {
                MySQLConnectionManager connectionManager = new MySQLConnectionManager(host, databaseName, userName, password);
                connectionManager.OpenConnection();
                childForm(new Soldadura(connectionManager));

            }catch (Exception ex)
            {
                MessageBox.Show($"Error al intentar establecer la conexion: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Capacitaciones_Click(object sender, EventArgs e)
        {
            try
            {
                MySQLConnectionManager connectionManager = new MySQLConnectionManager(host, databaseName, userName, password);
                connectionManager.OpenConnection();
                childForm(new Capacitaciones(connectionManager));

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al intentar establecer la conexion: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_TiempoExtra_Click(object sender, EventArgs e)
        {
            try
            {

                MySQLConnectionManager connectionManager = new MySQLConnectionManager(host, databaseName, userName, password);
                connectionManager.OpenConnection();
                childForm(new TiempoExtra(connectionManager));


            }catch (Exception ex)
            {
                MessageBox.Show($"Error al intentar establecer la conexión: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}