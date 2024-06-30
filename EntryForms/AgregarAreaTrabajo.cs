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
    public partial class AgregarAreaTrabajo : Form
    {
        
        private JobAreaDataBase jobAreaDataBase;
        private MySQLQueryManager queryManager;
        private MySQLConnectionManager connectionManager;
        public event EventHandler<AreaTrabajoEvents> NewAreaJob;

        protected virtual void OnJobCenterAdd(AreaTrabajoEvents e)
        {
            NewAreaJob?.Invoke(this, e);
        }


        public AgregarAreaTrabajo(MySQLConnectionManager connectionManager)
        {
            InitializeComponent();
            this.connectionManager = connectionManager;
            this.queryManager = new MySQLQueryManager(connectionManager.GetConnection()); // Inicializar
            this.jobAreaDataBase = new JobAreaDataBase(queryManager);
        }
        
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void panelTitle_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }
        




        private void btn_AddNewArea_Click(object sender, EventArgs e)
        {

            connectionManager.OpenConnection();

            try
            {
                string areaName = Txt_centerNumber.Text;
             

                if (!string.IsNullOrEmpty(areaName))
                {
                 
                    jobAreaDataBase.AddArea(areaName);

                    // Actualizar la vista de las líneas de producción
                    OnJobCenterAdd(new AreaTrabajoEvents(areaName));

                }
                else
                {
                    MessageBox.Show("Por favor ingrese un nombre para la nueva área de trabajo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar el área de trabajo {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Txt_centerNumber.Text = "";

        }

        private void btnCloseWindow_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
